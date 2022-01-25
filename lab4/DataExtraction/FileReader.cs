using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;
using VectorException;
using System.IO;

namespace DataExtraction
{
    public class FileReader:IDataExtractor
    {
        private string _path = "";

        public FileReader(string path)
        {
            _path = path;
            string R = (path[path.Length - 3].ToString() + path[path.Length - 2].ToString() + path[path.Length - 1].ToString());           
            if (R != "csv")
            {
                throw (new Exception("Invalid File Format"));
            }
        }

        public string[] ExtractData()
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
