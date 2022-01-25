using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace DemographicFileOperations
{
    public class FileReader:IDataExtractor
    {
        private string _agePath = "";
        private string _deathPath = "";

        public FileReader(string agePath, string deathPath)
        {
            _agePath = agePath;
            string R1 = (agePath[agePath.Length - 3].ToString() + agePath[agePath.Length - 2].ToString() + agePath[agePath.Length - 1].ToString());
            if (R1 != "csv")
            {
                throw (new Exception("Invalid File Format"));
            }

            _deathPath = deathPath;
            string R2 = (deathPath[deathPath.Length - 3].ToString() + deathPath[deathPath.Length - 2].ToString() + deathPath[deathPath.Length - 1].ToString());
            if (R2 != "csv")
            {
                throw (new Exception("Invalid File Format"));
            }

        }

        public List<string[]> ExtractData()
        {
            List<string[]> readText=new List<string[]>();
            
            if (File.Exists(_agePath))
            {
                readText.Add(File.ReadAllLines(_agePath));

            }

            if (File.Exists(_deathPath))
            {
                readText.Add(File.ReadAllLines(_deathPath));

            }
            return readText;
        }
    }
}
