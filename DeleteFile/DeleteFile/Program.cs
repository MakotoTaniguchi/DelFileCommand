using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootPath = args[0];

            var filePaths = args.Skip(1).ToList();
            foreach (var filePath in filePaths)
            {
                var deleFilePath = string.Format(@"{0}\{1}", rootPath, filePath.Replace(@"/", @"\"));
                System.IO.File.Delete(deleFilePath);
            }
        }
    }
}
