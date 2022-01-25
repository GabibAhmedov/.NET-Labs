using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;
using VectorException;
using System.IO;


namespace IrisVisualisationApp
{
    public class FileReader
    {
        private string _path = "";

        public FileReader(string path)
        {
            _path = path;
        }
        /// <summary>
		/// Считать файл в массив строк (количество координат).
		/// </summary>
        public string[] ReadFile()
        {
            string[] readText = { "", "" };
            //Result result;
            if (File.Exists(_path))
            {
                readText = File.ReadAllLines(_path);
                
            }
            return readText;
            
        }
    }
}


