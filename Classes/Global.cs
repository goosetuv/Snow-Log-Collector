using System.IO;
using System.Linq;

namespace SLC
{
    public class Global
    {
        public static void LogFileCopier(string Path, int Limit, string Destination)
        {
            if (Directory.Exists(Path))
            {
                foreach (var i in Directory.GetFiles(Path)
                    .Select(x => new FileInfo(x))
                    .OrderByDescending(x => x.LastWriteTime)
                    .Take(Limit)
                    .ToArray())
                {
                    File.Copy(i.FullName, Destination + i.Name);
                }
            }
        }
    }
}
