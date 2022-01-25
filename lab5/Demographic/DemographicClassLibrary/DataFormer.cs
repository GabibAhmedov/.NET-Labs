using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemographicFileOperations
{
    public class DataFormer
    {
        private IDataExtractor _dataExtractor;
        public Dictionary<int, double> _InitialAgeDictionary { get; } = new Dictionary<int, double>();
        public Dictionary<int[], double> _DeathRulesMaleDictionary { get; } = new Dictionary<int[], double>();
        public Dictionary<int[], double> _DeathRulesFemaleDictionary { get; } = new Dictionary<int[], double>();

        public DataFormer(IDataExtractor dataExtractor)
        {
            _dataExtractor = dataExtractor;
        }

        public void ArrangeData()
        {
            string[] InitialAgeText = _dataExtractor.ExtractData()[0];
            for (int i = 1; i < InitialAgeText.Length; i++)
            {
                string[] sVec = InitialAgeText[i].Split(',');
                _InitialAgeDictionary.Add(Convert.ToInt32(sVec[0]), Convert.ToDouble(sVec[1]));
            }

            string[] DeathRulesText = _dataExtractor.ExtractData()[1];
            for (int i = 1; i < DeathRulesText.Length; i++)
            {
                string[] sVec = DeathRulesText[i].Split(',');
                _DeathRulesMaleDictionary.Add(
                    Enumerable.Range(Convert.ToInt32(sVec[0]), (Convert.ToInt32(sVec[1])- Convert.ToInt32(sVec[0]) + 1)).ToArray(), Convert.ToDouble(sVec[2])
                    );
                _DeathRulesFemaleDictionary.Add(
                    Enumerable.Range(Convert.ToInt32(sVec[0]), (Convert.ToInt32(sVec[1]) - Convert.ToInt32(sVec[0]) + 1)).ToArray(), Convert.ToDouble(sVec[3])
                    );

            }
        }

    }
}
