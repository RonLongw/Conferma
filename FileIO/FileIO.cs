using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileIO.Interfaces;

namespace FileService
{
    public class FileIO : IFileIO
    {
        public string ReadTextFileContents(string fileName)
        {
            var sb = new StringBuilder();

            foreach (var line in File.ReadLines(fileName))
            {
                sb.Append(line);
            }

            return sb.ToString();
        }

        public void WriteToTextFile(string fileName, string text)
        {
            File.WriteAllText(fileName, text);
        }
    }
}
