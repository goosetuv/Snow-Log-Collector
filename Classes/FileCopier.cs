using System.IO;
using System.Linq;

namespace SnowLogCollector.Classes
{
    public class FileCopier
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(FileCopier));

        /// <summary>
        /// Copy files from one location to another
        /// </summary>
        /// <param name="targetPath">Location of original files</param>
        /// <param name="destinationPath">Location to copy the files</param>
        /// <param name="logFunction">The part of the application the log refers to... kind of</param>
        /// <param name="fileLimit">The amount of files to take</param> 
        public void Copy(string targetPath, string destinationPath, string logFunction, int fileLimit = 5)
        {
            if(Directory.Exists(targetPath))
            {
                foreach(var i in Directory.GetFiles(targetPath)
                    .Select(x => new FileInfo(x))
                    .OrderByDescending(x => x.LastWriteTime)
                    .Take(fileLimit)
                    .ToArray())
                {
                    // Set the full path of our file in the new destiation
                    string destinationFile = Path.Combine(destinationPath, logFunction + "_" + i.Name);

                    // Check if it exists already
                    if(!File.Exists(destinationFile))
                    {
                        // Copy the file to the new destiation
                        File.Copy(i.FullName, destinationFile, true);
                        log.Debug(string.Format("{0} copied to {1}", i.FullName, destinationPath));
                    } else
                    {
                        // File already exists, cannot copy, skip
                        log.Debug(string.Format("{0} already exists in {1}, skipping...", i.FullName, destinationPath));
                    }
                    
                }
            }
        }
    }
}
