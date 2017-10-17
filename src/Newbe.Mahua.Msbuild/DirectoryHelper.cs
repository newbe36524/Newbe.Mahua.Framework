using System;
using System.IO;
using System.Linq;

namespace Newbe.Mahua.Msbuild
{
    internal static class DirectoryHelper
    {
        private static readonly MahuaPlatform[] MahuaPlatforms =
            Enum.GetValues(typeof(MahuaPlatform)).Cast<MahuaPlatform>().ToArray();

        internal static void DeleteOtherPlatformFile(string dir, MahuaPlatform keepedMahuaPlatform)
        {
            var othersFiles = MahuaPlatforms.Where(x => x != keepedMahuaPlatform).Select(x => $"Newbe.Mahua.{x:G}.*")
                .ToArray();
            foreach (var othersFile in othersFiles)
            {
                foreach (var file in Directory.GetFiles(dir, othersFile))
                {
                    File.Delete(file);
                }
            }
        }

        /// <summary>
        /// 递归复制文件夹内容
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>
        /// <param name="copySubDirs"></param>
        internal static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            var dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            var dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            var files = dir.GetFiles();
            foreach (var file in files)
            {
                var temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (var subdir in dirs)
                {
                    var temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, true);
                }
            }
        }
    }
}