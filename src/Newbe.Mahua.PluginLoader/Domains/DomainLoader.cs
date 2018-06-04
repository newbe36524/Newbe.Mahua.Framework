using System;
using System.Diagnostics;

namespace Newbe.Mahua.Domains
{
    /// <summary>
    /// Defines the interface for a DomainLoader
    /// </summary>
    public interface IDomainLoader : IDisposable
    {
        /// <summary>
        /// Loads the dlls into the new AppDomain
        /// </summary>
        void Load();

        /// <summary>
        /// Unloads the AppDomain and deletes files in the cache folder.  The cache folder is where dlls are copied, and run, when using shadow copying.
        /// </summary>
        void Unload();

        /// <summary>
        /// Executes a static method on the specified type across the AppDomain
        /// </summary>
        /// <typeparam name="TResult">The result of the function call is cast to TResult</typeparam>
        /// <param name="typeName">The name of the type which exposes the static method</param>
        /// <param name="staticMethodName">The name of the static method</param>
        /// <param name="args">Any parameters to be passedd to the static method</param>
        /// <returns>The return value from the function, casted to TResult.</returns>
        TResult ExecuteStaticMethod<TResult>(string typeName, string staticMethodName, params object[] args);

        /// <summary>
        /// Executes a static method on the specified type across the AppDomain
        /// </summary>
        /// <param name="typeName">The name of the type which exposes the static method</param>
        /// <param name="staticMethodName">The name of the static method</param>
        /// <param name="args">Any arguments to be passedd to the static method</param>
        void ExecuteStaticMethod(string typeName, string staticMethodName, params object[] args);

        /// <summary>
        /// Instantiates a class and calls a method exposed by it.
        /// </summary>
        /// <typeparam name="TResult">The result of the function call is cast to TResult</typeparam>
        /// <param name="typeName">The name of the type which exposes the static method</param>
        /// <param name="methodName">The name of the static method</param>
        /// <param name="args">Any arguments to be passed to the static method</param>
        /// <returns>The return value from the function, casted to TResult</returns>
        TResult Execute<TResult>(string typeName, string methodName, params object[] args);

        /// <summary>
        /// Instantiates a class and calls a method exposed by it.
        /// </summary>
        /// <param name="typeName">The name of the type which exposes the static method</param>
        /// <param name="methodName">The name of the static method</param>
        /// <param name="args">Any arguments to be passed to the static method</param>
        void Execute(string typeName, string methodName, params object[] args);

        /// <summary>
        /// Instantiates a class and returns a handle to it.  This handle must be cast to an interface in order to work across AppDomains.
        /// </summary>
        /// <param name="typeName">The name of the type which is to be instantiated</param>
        /// <returns>A handle to the instantiated object.  This value should be cast to an interface as only interfaces will work across AppDomains.</returns>
        object Create(string typeName);

        /// <summary>
        /// Instantiates a class and returns a handle to it.  This handle must be cast to an interface in order to work across AppDomains.
        /// </summary>
        /// <typeparam name="TInterfaceType">The handle to the class is automatically cast to the interfafce TInterfaceType</typeparam>
        /// <param name="typeName">The name of the type which is to be instantiated</param>
        /// <returns>A handle to the instantiated object.  This value should be cast to an interface as only interfaces will work across AppDomains.</returns>
        TInterfaceType Create<TInterfaceType>(string typeName);
    }

    //[Serializable()]
    /// <summary>
    /// An AppDomain helper class which makes it easy to host relodable AppDomains.  Supports ShadowCopy.
    /// </summary>
    public class DomainLoader : IDomainLoader
    {
        private readonly string _domainName;
        private readonly string _configurationFile;
        private AppDomain _domain;
        private readonly string _relativeSubFolderForDomain;
        private readonly bool _useShadowCopy = false;
        private string _cachePath = String.Empty;

        private IAssemblyLoader Loader
        {
            get => _domain.GetData("AssemblyLoader") as IAssemblyLoader;
            set => _domain?.SetData("AssemblyLoader", value);
        }

        /// <summary>
        /// The name of the new AppDomain
        /// </summary>
        public string DomainName { get; private set; }

        /// <summary>
        /// Creates an AppDomain under the current AppDomain
        /// </summary>
        /// <param name="relativeSubFolderForDomain">The relative path to the subfolder which will be the root folder for the new AppDomain</param>
        /// <param name="useShadowCopy">True to shadow copy files.  This allows dlls to be added, removed or modified while the AppDomain is still loaded.</param>
        public DomainLoader(string relativeSubFolderForDomain, bool useShadowCopy = false)
            : this("", relativeSubFolderForDomain, useShadowCopy)
        {
        }

        /// <summary>
        /// Creates an AppDomain under the current AppDomain
        /// </summary>
        /// <param name="domainName">The name for the domain.  If not assigned, or null or empty, a Guid is assigned.</param>
        /// <param name="relativeSubFolderForDomain">The relative path to the subfolder which will be the root folder for the new AppDomain</param>
        /// <param name="useShadowCopy">True to shadow copy files.  This allows dlls to be added, removed or modified while the AppDomain is still loaded.</param>
        public DomainLoader(string domainName, string relativeSubFolderForDomain, bool useShadowCopy = false)
            : this(domainName, relativeSubFolderForDomain, string.Empty, useShadowCopy)
        {
        }

        public DomainLoader(string domainName, string relativeSubFolderForDomain, string configurationFile,
            bool useShadowCopy = false)
        {
            if (string.IsNullOrEmpty(domainName))
                domainName = Guid.NewGuid().ToString();
            _domainName = domainName;
            _configurationFile = configurationFile;
            if (!relativeSubFolderForDomain.EndsWith("\\"))
                _relativeSubFolderForDomain = relativeSubFolderForDomain + "\\";
            else
                _relativeSubFolderForDomain = relativeSubFolderForDomain;
            _useShadowCopy = useShadowCopy;
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            Unload();
        }

        /// <summary>
        /// Destructs the DomainLoader instance.  Calls Dispose.
        /// </summary>
        ~DomainLoader()
        {
            Dispose(false);
        }

        private void DeleteDirectory(string directory)
        {
            //first delete any files
            foreach (var file in System.IO.Directory.GetFiles(directory))
            {
                try
                {
                    System.IO.File.Delete(file);
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to delete temporary file {0}", file);
                }
            }

            //now delete each subdirectory
            foreach (var dir in System.IO.Directory.GetDirectories(directory))
            {
                DeleteDirectory(dir);
                try
                {
                    System.IO.Directory.Delete(dir);
                }
                catch (Exception)
                {
                    Console.WriteLine("Unable to delete temporary folder");
                }
            }
        }

        /// <summary>
        /// Unloads the AppDomain and deletes files in the cache folder.  The cache folder is where dlls are copied, and run, when using shadow copying.
        /// </summary>
        public void Unload()
        {
            AppDomain.CurrentDomain.SetData("AssemblyLoader", null);
            Loader = null;
            if (_domain != null)
            {
                try
                {
                    AppDomain.Unload(_domain);
                }
                catch (CannotUnloadAppDomainException e)
                {
                    Debug.WriteLine(e.ToString());
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }

                _domain = null;
            }

            if (!string.IsNullOrEmpty(_cachePath) && System.IO.Directory.Exists(_cachePath))
            {
                DeleteDirectory(_cachePath);
            }

            _cachePath = string.Empty;
        }

        /// <summary>
        /// Loads the dlls into the new AppDomain
        /// </summary>
        public void Load()
        {
            DomainName = _domainName;

            AppDomainSetup setup = new AppDomainSetup
            {
                ApplicationBase = AppDomain.CurrentDomain.BaseDirectory,
                PrivateBinPath =
                    System.IO.Path.GetFileName(System.IO.Path.GetDirectoryName(_relativeSubFolderForDomain)),
                ConfigurationFile = _configurationFile,
                ApplicationName = DomainName
            };
            //this allows us to load Tungsten.Domains from our own folder
            //setup.ApplicationBase = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _subFolderForDomain); //this requires Tungsten.Domains. to exist in the Plugins folder
            if (_useShadowCopy)
            {
                _cachePath = System.IO.Path.Combine(_relativeSubFolderForDomain,
                    "cache" + System.IO.Path.DirectorySeparatorChar);
                setup.CachePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _cachePath);
                setup.ShadowCopyFiles = "true";
                setup.ShadowCopyDirectories = null;
            }

            _domain = AppDomain.CreateDomain(DomainName, null, setup);
            var assembly = typeof(AssemblyLoader).Assembly;
            _domain.Load(assembly.GetName());
            Loader = (IAssemblyLoader)_domain.CreateInstanceAndUnwrap(assembly.GetName().Name, typeof(AssemblyLoader).FullName ?? throw new InvalidOperationException());
            _domain.DoCallBack(() =>
            {
                var al = AppDomain.CurrentDomain.GetData("AssemblyLoader");
                Trace.WriteLine("AssemblyLoader Availability = " + (al != null));
            });

            //2.7.2017 - In order to find the files correctly, I had to root the value of _relativeSubFolderForDomain
            var fullPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _relativeSubFolderForDomain);
            Loader.Load(_domain, fullPath, "*.dll");
        }

        /// <summary>
        /// Executes a static method on the specified type across the AppDomain
        /// </summary>
        /// <typeparam name="TResult">The result of the function call is cast to TResult</typeparam>
        /// <param name="typeName">The name of the type which exposes the static method</param>
        /// <param name="staticMethodName">The name of the static method</param>
        /// <param name="args">Any parameters to be passedd to the static method</param>
        /// <returns>The return value from the function, casted to TResult.</returns>
        public TResult ExecuteStaticMethod<TResult>(string typeName, string staticMethodName, params object[] args)
        {
            return Loader.ExecuteStaticMethod<TResult>(typeName, staticMethodName, args);
        }

        /// <summary>
        /// Executes a static method on the specified type across the AppDomain
        /// </summary>
        /// <param name="typeName">The name of the type which exposes the static method</param>
        /// <param name="staticMethodName">The name of the static method</param>
        /// <param name="args">Any arguments to be passedd to the static method</param>
        public void ExecuteStaticMethod(string typeName, string staticMethodName, params object[] args)
        {
            Loader.ExecuteStaticMethod(typeName, staticMethodName, args);
        }

        /// <summary>
        /// Instantiates a class and calls a method exposed by it.
        /// </summary>
        /// <typeparam name="TResult">The result of the function call is cast to TResult</typeparam>
        /// <param name="typeName">The name of the type which exposes the static method</param>
        /// <param name="methodName">The name of the static method</param>
        /// <param name="args">Any arguments to be passed to the static method</param>
        /// <returns>The return value from the function, casted to TResult</returns>
        public TResult Execute<TResult>(string typeName, string methodName, params object[] args)
        {
            return Loader.Execute<TResult>(typeName, methodName, args);
        }

        /// <summary>
        /// Instantiates a class and calls a method exposed by it.
        /// </summary>
        /// <param name="typeName">The name of the type which exposes the static method</param>
        /// <param name="methodName">The name of the static method</param>
        /// <param name="args">Any arguments to be passed to the static method</param>
        public void Execute(string typeName, string methodName, params object[] args)
        {
            Loader.Execute(typeName, methodName, args);
        }

        /// <summary>
        /// Instantiates a class and returns a handle to it.  This handle must be cast to an interface in order to work across AppDomains.
        /// </summary>
        /// <typeparam name="TInterfaceType">The handle to the class is automatically cast to the interfafce TInterfaceType</typeparam>
        /// <param name="typeName">The name of the type which is to be instantiated</param>
        /// <returns>A handle to the instantiated object.  This value should be cast to an interface as only interfaces will work across AppDomains.</returns>
        public TInterfaceType Create<TInterfaceType>(string typeName)
        {
            var result = Loader.Create<TInterfaceType>(typeName);
            if (result == null)
                throw new NotImplementedException();
            return result;
        }

        /// <summary>
        /// Instantiates a class and returns a handle to it.  This handle must be cast to an interface in order to work across AppDomains.
        /// </summary>
        /// <param name="typeName">The name of the type which is to be instantiated</param>
        /// <returns>A handle to the instantiated object.  This value should be cast to an interface as only interfaces will work across AppDomains.</returns>
        public object Create(string typeName)
        {
            var result = Loader.Create(typeName);
            if (result == null)
                throw new NotImplementedException();
            return result;
        }

        /// <summary>
        /// Executes an action in the context of the hosted AppDomain
        /// </summary>
        /// <param name="action">The action to be called in the context of the hosted AppDomain</param>
        public void DoCallback(Action action)
        {
            _domain.DoCallBack(new CrossAppDomainDelegate(action));
        }

        /// <summary>
        /// Sets the value of the specified application domain property
        /// </summary>
        /// <param name="name">The name of a predefined or custom domain property</param>
        /// <param name="data">The value to be assigned to the domain property</param>
        public void SetData(string name, object data)
        {
            _domain?.SetData(name, data);
        }

        /// <summary>
        /// Gets the value stored in the current application domain for the specified name
        /// </summary>
        /// <param name="name">The name of a predefined or custom domain property</param>
        /// <typeparam name="TData">The type of data to be returned</typeparam>
        /// <returns>The data stored in the domain property as cast to T</returns>
        public TData GetData<TData>(string name)
        {
            var result = _domain?.GetData(name);
            if (result != null)
                return (TData)result;
            return default(TData);
        }
    }
}
