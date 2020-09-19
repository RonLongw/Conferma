using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO.Interfaces
{
    interface IFileIO
    {
        string ReadTextFileContents(string fileName);

        void WriteToTextFile(string fileName, string text);
    }
}
