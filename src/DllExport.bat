@echo off
:: Copyright (c) 2016-2018  Denis Kuzmin [ entry.reg@gmail.com ] :: github.com/3F
:: https://github.com/3F/DllExport
:: ---
:: Based on hMSBuild logic and includes GetNuTool core.
:: https://github.com/3F/hMSBuild
:: https://github.com/3F/GetNuTool
setlocal enableDelayedExpansion
set "aa=1.6.1"
set "wAction="
set "ab=DllExport"
set "ac=tools/net.r_eg.DllExport.Wizard.targets"
set "ad=packages"
set "ae=https://www.nuget.org/api/v2/package/"
set "af=build_info.txt"
set "wRootPath=%cd%"
set wMgrArgs="%*"
set /a ag=0
set /a ah=0
set "ai="
set "aj="
set "ak="
set "al="
set "am="
set "an="
set ao=0
set ap=2
set aq=3
set "ar=%* "
set "as=%~dpnx0"
set at=%ar:"=%
set au=%at%
set au=%au:-help =%
set au=%au:-h =%
set au=%au:-? =%
if not "%at%"=="%au%" goto bb
goto bc
:bb
echo.
@echo DllExport - v1.6.1.51910 [ e6c3d30 ]
@echo Copyright (c) 2009-2015  Robert Giesecke
@echo Copyright (c) 2016-2018  Denis Kuzmin [ entry.reg@gmail.com :: github.com/3F ]
echo.
echo Distributed under the MIT license
@echo https://github.com/3F/DllExport
echo Wizard - based on hMSBuild logic and includes GetNuTool core - https://github.com/3F
echo.
@echo.
@echo Usage: DllExport [args to DllExport] [args to GetNuTool core]
echo ------
echo.
echo Arguments:
echo ----------
echo  -action {type}        - Specified action for Wizard. Where {type}:
echo                           * Configure - To configure DllExport for specific projects.
echo                           * Update    - To update pkg reference for already configured projects.
echo                           * Restore   - To restore configured DllExport.
echo                           * Export    - To export configured projects data.
echo                           * Recover   - To re-configure projects via predefined/exported data.
echo                           * Unset     - To unset all data from specified projects.
echo                           * Upgrade   - Aggregates an Update action with additions for upgrading.
echo.
echo  -sln-dir {path}       - Path to directory with .sln files to be processed.
echo  -sln-file {path}      - Optional predefined .sln file to process via the restore operations etc.
echo  -metalib {path}       - Relative path from PkgPath to DllExport meta library.
echo  -dxp-target {path}    - Relative path to entrypoint wrapper of the main core.
echo  -dxp-version {num}    - Specific version of DllExport. Where {num}:
echo                           * Versions: 1.6.0 ...
echo                           * Keywords: 
echo                             `actual` to use unspecified local version or to get latest available;
echo.
echo  -msb {path}           - Full path to specific msbuild.
echo  -packages {path}      - A common directory for packages.
echo  -server {url}         - Url for searching remote packages.
echo  -proxy {cfg}          - To use proxy. The format: [usr[:pwd]@]host[:port]
echo  -pkg-link {uri}       - Direct link to package from the source via specified URI.
echo  -force                - Aggressive behavior, e.g. like removing pkg when updating.
echo  -mgr-up               - Updates this manager to version from '-dxp-version'.
echo  -wz-target {path}     - Relative path to entrypoint wrapper of the main wizard.
echo  -pe-exp-list {module} - To list all available exports from PE32/PE32+ module.
echo  -eng                  - Try to use english language for all build messages.
echo  -GetNuTool {args}     - Access to GetNuTool core. https://github.com/3F/GetNuTool
echo  -debug                - To show additional information.
echo  -version              - Displays version for which (together with) it was compiled.
echo  -build-info           - Displays actual build information from selected DllExport.
echo  -help                 - Displays this help. Aliases: -help -h -?
echo.
echo. 
echo -------- 
echo Samples:
echo -------- 
echo  DllExport -action Configure
echo  DllExport -action Restore -sln-file "Conari.sln"
echo  DllExport -proxy guest:1234@10.0.2.15:7428 -action Configure
echo.
echo  DllExport -build-info
echo  DllExport -restore -sln-dir -sln-dir ..\ -debug
echo.
echo  DllExport -GetNuTool -unpack
echo  DllExport -GetNuTool /p:ngpackages="Conari;regXwild"
echo  DllExport -pe-exp-list bin\Debug\regXwild.dll
exit /B 0
:bc
call :bd ar _is
if [!_is!]==[1] (
if defined wAction goto be
goto bb
)
set /a av=1 & set aw=20
:bf
if "!ar:~0,8!"=="-action " (
call :bg %1 & shift
set wAction=%2
call :bg %2 & shift
)
if "!ar:~0,9!"=="-sln-dir " (
call :bg %1 & shift
set wSlnDir=%2
call :bg %2 & shift
)
if "!ar:~0,10!"=="-sln-file " (
call :bg %1 & shift
set wSlnFile=%2
call :bg %2 & shift
)
if "!ar:~0,9!"=="-metalib " (
call :bg %1 & shift
set wMetaLib=%2
call :bg %2 & shift
)
if "!ar:~0,12!"=="-dxp-target " (
call :bg %1 & shift
set wDxpTarget=%2
call :bg %2 & shift
)
if "!ar:~0,13!"=="-dxp-version " (
call :bg %1 & shift
set aa=%2
call :bg %2 & shift
)
if "!ar:~0,5!"=="-msb " (
call :bg %1 & shift
set ai=%2
call :bg %2 & shift
)
if "!ar:~0,10!"=="-packages " (
call :bg %1 & shift
set ad=%2
set "ad=!ad:"=!"
call :bg %2 & shift
)
if "!ar:~0,8!"=="-server " (
call :bg %1 & shift
set ae=%2
call :bg %2 & shift
)
if "!ar:~0,7!"=="-proxy " (
call :bg %1 & shift
set an=%2
call :bg %2 & shift
)
if "!ar:~0,10!"=="-pkg-link " (
call :bg %1 & shift
set aj=%2
call :bg %2 & shift
)
if "!ar:~0,7!"=="-force " (
call :bg %1 & shift
set /a al=1
)
if "!ar:~0,8!"=="-mgr-up " (
call :bg %1 & shift
set /a am=1
)
if "!ar:~0,11!"=="-wz-target " (
call :bg %1 & shift
set ac=%2
call :bg %2 & shift
)
if "!ar:~0,13!"=="-pe-exp-list " (
call :bg %1 & shift
set ak=%2
call :bg %2 & shift
)
if "!ar:~0,5!"=="-eng " (
call :bg %1 & shift
chcp 437 >nul
)
if "!ar:~0,11!"=="-GetNuTool " (
call :bg %1 & shift
goto bh
)
if "!ar:~0,7!"=="-debug " (
call :bg %1 & shift
set /a ag=1
)
if "!ar:~0,9!"=="-version " (
@echo v1.6.1.51910 [ e6c3d30 ]
exit /B 0
)
if "!ar:~0,12!"=="-build-info " (
call :bg %1 & shift
set /a ah=1
)
set /a "av+=1"
if !av! LSS %aw% goto bf
goto be
:bg
set ar=!!ar:%1 ^=!!
call :bi ar
set "ar=!ar! "
exit /B 0
:be
call :bj "dxpName = '%ab%'"
call :bj "dxpVersion = '!aa!'"
if defined aa (
if "!aa!"=="actual" (
set "aa="
)
)
if z%wAction%==zUpgrade (
call :bj "Upgrade is on"
set /a am=1
set /a al=1
)
call :bi ad
set "ad=!ad!\\"
set "ax=!ab!"
set "wPkgPath=!ad!!ab!"
if defined aa (
set "ax=!ax!/!aa!"
set "wPkgPath=!wPkgPath!.!aa!"
)
if defined al (
if exist "!wPkgPath!" (
call :bj "Removing old version '!wPkgPath!' before continue. '-force' key rule."
rmdir /S/Q "!wPkgPath!"
)
)
set ay="!wPkgPath!\\!ac!"
call :bj "dxpTarget = '!ay!'"
if not exist !ay! (
if exist "!wPkgPath!" (
call :bj "Wizard was not found. Trying to replace obsolete version '!wPkgPath!' ..."
rmdir /S/Q "!wPkgPath!"
)
call :bj "-pkg-link = '!aj!'"
call :bj "-server = '!ae!'"
if defined aj (
set ae=!aj!
if "!wPkgPath::=!"=="!wPkgPath!" ( 
set "az=../" 
)
set "ax=:!az!!wPkgPath!"
)
call :bj "_remoteUrl = '!ax!'"
call :bj "ngpath = '!ad!'"
if defined ai (
set a0=-msbuild !ai!
)
set a1=!a0! /p:ngserver="!ae!" /p:ngpackages="!ax!" /p:proxycfg="!an!"
if "!ag!"=="1" (
call :bk !a1!
) else (
call :bk !a1! >nul
)
)
if defined ak (
!wPkgPath!\\tools\\PeViewer.exe -list -pemodule "!ak!"
exit /B %ERRORLEVEL%
)
if "!ah!"=="1" (
call :bj "buildInfo = '!wPkgPath!\\!af!'"
if not exist "!wPkgPath!\\!af!" (
echo information about build is not available.
exit /B %ap%
)
type "!wPkgPath!\\!af!"
exit /B 0
)
if not exist !ay! (
echo Something went wrong. Try to use another keys.
exit /B %ap%
)
call :bj "-sln-dir = '!wSlnDir!'"
call :bj "-sln-file = '!wSlnFile!'"
call :bj "-metalib = '!wMetaLib!'"
call :bj "-dxp-target = '!wDxpTarget!'"
call :bj "wRootPath = !wRootPath!"
call :bj "wAction = !wAction!"
if defined ai (
set "ai=%ai:"=%"
call :bj "Use specific MSBuild tools '!ai!'"
set a2=!ai!
goto bl
)
call :bm
if "!ERRORLEVEL!"=="0" goto bl
echo MSBuild tools was not found. Try with `-msb` key. `-help` for details.
exit /B %ap%
:bl
call :bd a2 _is
if [!_is!]==[1] (
echo Something went wrong. Use `-debug` key for details.
exit /B %ap%
)
set a3="!a2!"
call :bj "Target: '!a2!' !ay!"
!a3! /nologo /v:m /m:4 !ay!
if defined am (
(copy /B/Y "!wPkgPath!\\DllExport.bat" "%as%" > nul) & echo Manager has been updated. & exit /B 0
)
exit /B 0
:bm
call :bj "trying via MSBuild tools from .NET Framework - .net 4.0, ..."
for %%v in (4.0, 3.5, 2.0) do (
call :bn %%v Y & if [!Y!]==[1] exit /B 0
)
call :bj "msbnetf: unfortunately we didn't find anything."
exit /B %ap%
:bn
call :bj "checking of version: %1"
for /F "usebackq tokens=2* skip=2" %%a in (
`reg query "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\%1" /v MSBuildToolsPath 2^> nul`
) do if exist %%b (
call :bj "found: %%b"
set a2=%%b
call :bo
set /a %2=1
exit /B 0
)
set /a %2=0
exit /B 0
:bh
call :bj "direct access to GetNuTool..."
call :bk !ar!
exit /B 0
:bo
set a2=!a2!\MSBuild.exe
exit /B 0
:bj
if "!ag!"=="1" (
set a4=%1
set a4=!a4:~0,-1! 
set a4=!a4:~1!
echo.[%TIME% ] !a4!
)
exit /B 0
:bi
call :a6 %%%1%%
set %1=%a5%
exit /B 0
:a6
set "a5=%*"
exit /B 0
:bd
setlocal enableDelayedExpansion
set "a6=!%1!"
if not defined a6 endlocal & set /a %2=1 & exit /B 0
set a6=%a6: =%
set "a6= %a6%"
if [^%a6:~1,1%]==[] endlocal & set /a %2=1 & exit /B 0
endlocal & set /a %2=0
exit /B 0
:bk
setlocal disableDelayedExpansion 
@echo off
:: GetNuTool - Executable version
:: Copyright (c) 2015-2018  Denis Kuzmin [ entry.reg@gmail.com ]
:: https://github.com/3F/GetNuTool
set a7=gnt.core
set a8="%temp%\%random%%random%%a7%"
set "ar=%* "
set a=%ar:~0,30%
set a=%a:"=%
if "%a:~0,8%"=="-unpack " goto bp
if "%a:~0,9%"=="-msbuild " goto bq
for %%v in (4.0, 14.0, 12.0, 3.5, 2.0) do (
for /F "usebackq tokens=2* skip=2" %%a in (
`reg query "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\%%v" /v MSBuildToolsPath 2^> nul`
) do if exist %%b (
set a9="%%b\MSBuild.exe"
goto br
)
)
echo MSBuild was not found, try: gnt -msbuild "fullpath" args 1>&2
exit /B 2
:bq
call :bs %1
shift
set a9=%1
call :bs %1
:br
call :bt
%a9% %a8% /nologo /p:wpath="%~dp0/" /v:m %ar%
del /Q/F %a8%
exit /B 0
:bs
call set ar=%%ar:%1 ^=%%
exit /B 0
:bp
set a8="%~dp0\%a7%"
echo Generate minified version in %a8% ...
:bt
<nul set /P ="">%a8%
<nul set /P =^<!-- GetNuTool - github.com/3F/GetNuTool --^>^<!-- Copyright (c) 2015-2018  Denis Kuzmin [ entry.reg@gmail.com ] --^>^<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003"^>^<PropertyGroup^>^<ngconfig Condition="'$(ngconfig)' == ''"^>packages.config^</ngconfig^>^<ngserver Condition="'$(ngserver)' == ''"^>https://www.nuget.org/api/v2/package/^</ngserver^>^<ngpackages Condition="'$(ngpackages)' == ''"^>^</ngpackages^>^<ngpath Condition="'$(ngpath)' == ''"^>packages^</ngpath^>^</PropertyGroup^>^<Target Name="get" BeforeTargets="Build" DependsOnTargets="header"^>^<PrepareList config="$(ngconfig)" plist="$(ngpackages)" wpath="$(wpath)"^>^<Output PropertyName="plist" TaskParameter="Result"/^>^</PrepareList^>^<NGDownload plist="$(plist)" url="$(ngserver)" wpath="$(wpath)" defpath="$(ngpath)" proxy="$(proxycfg)" debug="$(debug)"/^>^</Target^>^<Target Name="pack" DependsOnTargets="header"^>^<NGPack dir="$(ngin)" dout="$(ngout)" wpath="$(wpath)" vtool="$(GetNuTool)" debug="$(debug)"/^>^</Target^>^<PropertyGroup^>^<TaskCoreDllPath Condition="Exists('$(MSBuildToolsPath)\Microsoft.Build.Tasks.v$(MSBuildToolsVersion).dll')"^>$(MSBuildToolsPath)\Microsoft.Build.Tasks.v$(MSBuildToolsVersion).dll^</TaskCoreDllPath^>^<TaskCoreDllPath Condition="'$(TaskCoreDllPath)' == '' and Exists('$(MSBuildToolsPath)\Microsoft.Build.Tasks.Core.dll')"^>$(MSBuildToolsPath)\Microsoft.Build.Tasks.Core.dll^</TaskCoreDllPath^>^</PropertyGroup^>^<UsingTask TaskName="PrepareList" TaskFactory="CodeTaskFactory" AssemblyFile="$(TaskCoreDllPath)"^>^<ParameterGr>> %a8%
<nul set /P =oup^>^<config ParameterType="System.String" Required="true"/^>^<plist ParameterType="System.String"/^>^<wpath ParameterType="System.String"/^>^<Result ParameterType="System.String" Output="true"/^>^</ParameterGroup^>^<Task^>^<Reference Include="System.Xml"/^>^<Reference Include="System.Xml.Linq"/^>^<Using Namespace="System"/^>^<Using Namespace="System.Collections.Generic"/^>^<Using Namespace="System.IO"/^>^<Using Namespace="System.Xml.Linq"/^>^<Code Type="Fragment" Language="cs"^>^<![CDATA[if(!String.IsNullOrEmpty(plist)){Result=plist;return true;}var _err=Console.Error;Action^<string,Queue^<string^>^> h=delegate(string cfg,Queue^<string^> list){foreach(var pkg in XDocument.Load(cfg).Descendants("package")){var id=pkg.Attribute("id");var version=pkg.Attribute("version");var output=pkg.Attribute("output");if(id==null){_err.WriteLine("Some 'id' does not exist in '{0}'",cfg);return;}var link=id.Value;if(version!=null){link+="/"+version.Value;}if(output!=null){list.Enqueue(link+":"+output.Value);continue;}list.Enqueue(link);}};var ret=new Queue^<string^>();foreach(var cfg in config.Split('^|',';')){var lcfg=Path.Combine(wpath,cfg??"");if(File.Exists(lcfg)){h(lcfg,ret);}else{_err.WriteLine(".config '{0}' was not found.",lcfg);}}if(ret.Count ^< 1){_err.WriteLine("List of packages is empty. Use .config or /p:ngpackages=\"...\"\n");}else{Result=String.Join(";",ret.ToArray());}]]^>^</Code^>^</Task^>^</UsingTask^>^<UsingTask TaskName="NGDownload" TaskFactory="CodeTaskFactory" AssemblyFile="$(TaskCoreDllPath)"^>^<ParameterGroup^>^<plist ParameterType="System.String">> %a8%
<nul set /P =/^>^<url ParameterType="System.String" Required="true"/^>^<wpath ParameterType="System.String"/^>^<defpath ParameterType="System.String"/^>^<proxy ParameterType="System.String"/^>^<debug ParameterType="System.Boolean"/^>^</ParameterGroup^>^<Task^>^<Reference Include="WindowsBase"/^>^<Using Namespace="System"/^>^<Using Namespace="System.IO"/^>^<Using Namespace="System.IO.Packaging"/^>^<Using Namespace="System.Net"/^>^<Code Type="Fragment" Language="cs"^>^<![CDATA[if(plist==null){return false;}ServicePointManager.SecurityProtocol ^|=SecurityProtocolType.Tls11 ^| SecurityProtocolType.Tls12;var ignore=new string[]{"/_rels/","/package/","/[Content_Types].xml"};Action^<string,object^> dbg=delegate(string s,object p){if(debug){Console.WriteLine(s,p);}};Func^<string,WebProxy^> getProxy=delegate(string cfg){var auth=cfg.Split('@');if(auth.Length ^<=1){return new WebProxy(auth[0],false);}var login=auth[0].Split(':');return new WebProxy(auth[1],false){Credentials=new NetworkCredential(login[0],(login.Length ^> 1)?login[1]: null)};};Func^<string,string^> loc=delegate(string p){return Path.Combine(wpath,p??"");};Action^<string,string,string^> get=delegate(string link,string name,string path){var to=Path.GetFullPath(loc(path??name));if(Directory.Exists(to)){Console.WriteLine("`{0}` is already exists: \"{1}\"",name,to);return;}Console.Write("Getting `{0}` ... ",link);var tmp=Path.Combine(Path.GetTempPath(),Guid.NewGuid().ToString());using(var l=new WebClient()){try{if(proxy!=null){l.Proxy=getProxy(proxy);}l.Headers.Add("User-Agent","GetNuTool");l.UseDefaultCredentia>> %a8%
<nul set /P =ls=true;l.DownloadFile(url+link,tmp);}catch(Exception ex){Console.Error.WriteLine(ex.Message);return;}}Console.WriteLine("Extracting into \"{0}\"",to);using(var pkg=ZipPackage.Open(tmp,FileMode.Open,FileAccess.Read)){foreach(var part in pkg.GetParts()){var uri=Uri.UnescapeDataString(part.Uri.OriginalString);if(ignore.Any(x=^> uri.StartsWith(x,StringComparison.Ordinal))){continue;}var dest=Path.Combine(to,uri.TrimStart('/'));dbg("- `{0}`",uri);var dir=Path.GetDirectoryName(dest);if(!Directory.Exists(dir)){Directory.CreateDirectory(dir);}using(var src=part.GetStream(FileMode.Open,FileAccess.Read))using(var target=File.OpenWrite(dest)){try{src.CopyTo(target);}catch(FileFormatException ex){dbg("[x]?crc: {0}",dest);}}}}File.Delete(tmp);};foreach(var pkg in plist.Split(';')){var ident=pkg.Split(new char[]{':'},2);var link=ident[0];var path=(ident.Length ^> 1)?ident[1]: null;var name=link.Replace('/','.');if(!String.IsNullOrEmpty(defpath)){path=Path.Combine(defpath,path??name);}get(link,name,path);}]]^>^</Code^>^</Task^>^</UsingTask^>^<UsingTask TaskName="NGPack" TaskFactory="CodeTaskFactory" AssemblyFile="$(TaskCoreDllPath)"^>^<ParameterGroup^>^<dir ParameterType="System.String" Required="true"/^>^<dout ParameterType="System.String"/^>^<wpath ParameterType="System.String"/^>^<vtool ParameterType="System.String" Required="true"/^>^<debug ParameterType="System.Boolean"/^>^</ParameterGroup^>^<Task^>^<Reference Include="System.Xml"/^>^<Reference Include="System.Xml.Linq"/^>^<Reference Include="WindowsBase"/^>^<Using Namespace="System"/^>^<Using Namespace="System.Collections.Generic">> %a8%
<nul set /P =/^>^<Using Namespace="System.IO"/^>^<Using Namespace="System.Linq"/^>^<Using Namespace="System.IO.Packaging"/^>^<Using Namespace="System.Xml.Linq"/^>^<Using Namespace="System.Text.RegularExpressions"/^>^<Code Type="Fragment" Language="cs"^>^<![CDATA[var EXT_NUSPEC=".nuspec";var EXT_NUPKG=".nupkg";var TAG_META="metadata";var DEF_CONTENT_TYPE="application/octet";var MANIFEST_URL="http://schemas.microsoft.com/packaging/2010/07/manifest";var ID="id";var VER="version";Action^<string,object^> dbg=delegate(string s,object p){if(debug){Console.WriteLine(s,p);}};var _err=Console.Error;dir=Path.Combine(wpath,dir);if(!Directory.Exists(dir)){_err.WriteLine("`{0}` was not found.",dir);return false;}dout=Path.Combine(wpath,dout??"");var nuspec=Directory.GetFiles(dir,"*"+EXT_NUSPEC,SearchOption.TopDirectoryOnly).FirstOrDefault();if(nuspec==null){_err.WriteLine("{0} was not found in `{1}`",EXT_NUSPEC,dir);return false;}Console.WriteLine("Found {0}: `{1}`",EXT_NUSPEC,nuspec);var root=XDocument.Load(nuspec).Root.Elements().FirstOrDefault(x=^> x.Name.LocalName==TAG_META);if(root==null){_err.WriteLine("{0} does not contain {1}.",nuspec,TAG_META);return false;}var metadata=new Dictionary^<string,string^>();foreach(var tag in root.Elements()){metadata[tag.Name.LocalName.ToLower()]=tag.Value;}if(metadata[ID].Length ^> 100 ^|^|!Regex.IsMatch(metadata[ID],@"^\w+([_.-]\w+)*$",RegexOptions.IgnoreCase ^| RegexOptions.ExplicitCapture)){_err.WriteLine("The format of `{0}` is not correct.",ID);return false;}var ignore=new string[]{Path.Combine(dir,"_rels"),Path.Combine(dir,"package">> %a8%
<nul set /P =),Path.Combine(dir,"[Content_Types].xml")};var pout=String.Format("{0}.{1}{2}",metadata[ID],metadata[VER],EXT_NUPKG);if(!String.IsNullOrWhiteSpace(dout)){if(!Directory.Exists(dout)){Directory.CreateDirectory(dout);}pout=Path.Combine(dout,pout);}Console.WriteLine("Started packing `{0}` ...",pout);using(var pkg=Package.Open(pout,FileMode.Create)){var manifestUri=new Uri(String.Format("/{0}{1}",metadata[ID],EXT_NUSPEC),UriKind.Relative);pkg.CreateRelationship(manifestUri,TargetMode.Internal,MANIFEST_URL);foreach(var file in Directory.GetFiles(dir,"*.*",SearchOption.AllDirectories)){if(ignore.Any(x=^> file.StartsWith(x,StringComparison.Ordinal))){continue;}string pUri;if(file.StartsWith(dir,StringComparison.OrdinalIgnoreCase)){pUri=file.Substring(dir.Length).TrimStart(Path.DirectorySeparatorChar);}else{pUri=file;}dbg("- `{0}`",pUri);var escaped=String.Join("/",pUri.Split('\\','/').Select(p=^> Uri.EscapeDataString(p)));var uri=PackUriHelper.CreatePartUri(new Uri(escaped,UriKind.Relative));var part=pkg.CreatePart(uri,DEF_CONTENT_TYPE,CompressionOption.Maximum);using(var tstream=part.GetStream())using(var fs=new FileStream(file,FileMode.Open,FileAccess.Read)){fs.CopyTo(tstream);}}Func^<string,string^> getmeta=delegate(string key){return(metadata.ContainsKey(key))?metadata[key]:"";};var _p=pkg.PackageProperties;_p.Creator=getmeta("authors");_p.Description=getmeta("description");_p.Identifier=metadata[ID];_p.Version=metadata[VER];_p.Keywords=getmeta("tags");_p.Title=getmeta("title");_p.LastModifiedBy="GetNuTool v"+vtool;}]]^>^</Code^>^</Task^>^</UsingTask^>^<T>> %a8%
<nul set /P =arget Name="Build" DependsOnTargets="get"/^>^<PropertyGroup^>^<GetNuTool^>1.6.2.1354_e910e5c^</GetNuTool^>^<wpath Condition="'$(wpath)' == ''"^>$(MSBuildProjectDirectory)^</wpath^>^</PropertyGroup^>^<Target Name="header"^>^<Message Text="%%0D%%0AGetNuTool v$(GetNuTool) - github.com/3F%%0D%%0A=========%%0D%%0A" Importance="high"/^>^</Target^>^</Project^>>> %a8%
exit /B 0