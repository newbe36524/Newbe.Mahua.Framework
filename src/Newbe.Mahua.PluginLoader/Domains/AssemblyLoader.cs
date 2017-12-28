using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Newbe.Mahua.Domains
{
    internal interface IAssemblyLoader
    {
        void Load(AppDomain domain, string filename);
        void Load(AppDomain domain, string path, string searchPattern);

        TResult ExecuteStaticMethod<TResult>(string typeName, string staticMethodName, params object[] args);
        void ExecuteStaticMethod(string typeName, string staticMethodName, params object[] args);
        TResult Execute<TResult>(string typeName, string methodName, params object[] args);
        void Execute(string typeName, string methodName, params object[] args);

        object Create(string typeName);
        T Create<T>(string typeName);
    }

    //<Serializable()>
    internal class AssemblyLoader : MarshalByRefObject, IAssemblyLoader
    {
        private List<System.Reflection.Assembly> Assemblies { get; set; } = new List<Assembly>();

        /// <summary>
        /// Loads a dll into the new AppDomain
        /// </summary>
        public void Load(AppDomain domain, string filename)
        {
            string sAssembly = null;
            try
            {
                sAssembly = System.IO.Path.GetFileNameWithoutExtension(filename);
                var asm = domain.Load(sAssembly);
                Assemblies.Add(asm);
            }
            catch (Exception eX)
            {
                Debug.WriteLine("AssemblyHelper.LoadObject(" + sAssembly + "):  " + eX.Message);
            }
        }
        /// <summary>
        /// Loads dlls into the new AppDomain
        /// </summary>
        public void Load(AppDomain domain, string path, string searchPattern)
        {
            //load all existing plugins
            Assemblies.Clear();
            foreach (var filename in System.IO.Directory.GetFiles(path, searchPattern))
            {
                Load(domain, filename);
            }
        }

        private Type FindType(string typeName)
        {
            return Assemblies.Select(asm => asm.GetType(typeName)).FirstOrDefault(t => t != null);
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
            if (string.IsNullOrEmpty(typeName))
                throw new NotImplementedException();
            var type = FindType(typeName);
            if (type == null)
                throw new NotImplementedException();
            var result = (TResult)type.InvokeMember(staticMethodName, BindingFlags.Static | BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, args);
            return result;
        }
        /// <summary>
        /// Executes a static method on the specified type across the AppDomain
        /// </summary>
        /// <param name="typeName">The name of the type which exposes the static method</param>
        /// <param name="staticMethodName">The name of the static method</param>
        /// <param name="args">Any arguments to be passedd to the static method</param>
        public void ExecuteStaticMethod(string typeName, string staticMethodName, params object[] args)
        {
            if (string.IsNullOrEmpty(typeName))
                throw new NotImplementedException();
            var type = FindType(typeName);
            if (type == null)
                throw new NotImplementedException();
            type.InvokeMember(staticMethodName, BindingFlags.Static | BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, args);
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
            if (string.IsNullOrEmpty(typeName))
                throw new NotImplementedException();
            var type = FindType(typeName);
            if (type == null)
                throw new NotImplementedException();
            var instance = Activator.CreateInstance(type);
            var result = (TResult)type.InvokeMember(methodName, BindingFlags.Instance | BindingFlags.FlattenHierarchy | BindingFlags.Public, null, instance, args);
            return result;
        }
        /// <summary>
        /// Instantiates a class and calls a method exposed by it.
        /// </summary>
        /// <param name="typeName">The name of the type which exposes the static method</param>
        /// <param name="methodName">The name of the static method</param>
        /// <param name="args">Any arguments to be passed to the static method</param>
        public void Execute(string typeName, string methodName, params object[] args)
        {
            if (string.IsNullOrEmpty(typeName))
                throw new NotImplementedException();
            var type = FindType(typeName);
            if (type == null)
                throw new NotImplementedException();
            var instance = Activator.CreateInstance(type);
            type.InvokeMember(methodName, BindingFlags.Instance | BindingFlags.FlattenHierarchy | BindingFlags.Public, null, instance, args);
        }
        /// <summary>
        /// Instantiates a class and returns a handle to it.  This handle must be cast to an interface in order to work across AppDomains.
        /// </summary>
        /// <typeparam name="TInterfaceType">The handle to the class is automatically cast to the interfafce TInterfaceType</typeparam>
        /// <param name="typeName">The name of the type which is to be instantiated</param>
        /// <returns>A handle to the instantiated object.  This value should be cast to an interface as only interfaces will work across AppDomains.</returns>
        public TInterfaceType Create<TInterfaceType>(string typeName)
        {
            return (TInterfaceType)Create(typeName);
        }
        /// <summary>
        /// Instantiates a class and returns a handle to it.  This handle must be cast to an interface in order to work across AppDomains.
        /// </summary>
        /// <param name="typeName">The name of the type which is to be instantiated</param>
        /// <returns>A handle to the instantiated object.  This value should be cast to an interface as only interfaces will work across AppDomains.</returns>
        public object Create(string typeName)
        {
            foreach (var asm in Assemblies)
            {
                foreach (var type in asm.GetExportedTypes())
                {
                    if (type.FullName == typeName)
                        return Activator.CreateInstance(type);
                }
            }
            return null;
        }
    }
}
