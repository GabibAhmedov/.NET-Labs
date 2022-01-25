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

    public class DataFormer
    {
        private string _indicator1 = "";
        private string _indicator2 = "";
        private string _indicator3 = "";
        private List<IMathVector> _species1 = new List<IMathVector>();
        private List<IMathVector> _species2 = new List<IMathVector>();
        private List<IMathVector> _species3 = new List<IMathVector>();
        private MathVector _AvgVector1 =new MathVector();
        private MathVector _AvgVector2 =new MathVector();
        private MathVector _AvgVector3 =new MathVector();
        private double _DistBetween12;
        private double _DistBetween13;
        private double _DistBetween23;
        public MathVector AvgVector1
        {
            get
            {
                return _AvgVector1;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                    _AvgVector1 = new MathVector(value);
            }
        }
        public MathVector AvgVector2
        {
            get
            {
                return _AvgVector2;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                    _AvgVector2 = new MathVector(value);
            }
        }
        public MathVector AvgVector3
        {
            get
            {
                return _AvgVector3;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                    _AvgVector3 = new MathVector(value);
            }
        }
        public double DistBetween12
        {
            get
            {
                return _DistBetween12;
            }
            set
            {
                _DistBetween12=value;
            }
        }
        public double DistBetween13
        {
            get
            {
                return _DistBetween13;
            }
            set
            {
                _DistBetween13 = value;
            }

        }
        public double DistBetween23
        {
            get
            {
                return _DistBetween23;
            }
            set
            {
                _DistBetween23 = value;
            }
        }

        public string Indicator1
        {
            get { return _indicator1; }
        }
        public string Indicator2
        {
            get { return _indicator2; }
        }
        public string Indicator3
        {
            get { return _indicator3; }
        }
        public List<IMathVector> GetSpecies1
        {
            get { return _species1; }
        }
        public List<IMathVector> GetSpecies2
        {
            get { return _species2; }
        }
        public List<IMathVector> GetSpecies3
        {
            get { return _species3; }
        }

        public void FindIndicators(string path, string[] text)
        {
            
            string[] tmpVec = text[1].Split(',');
            _indicator1 = tmpVec[tmpVec.Length - 1];          
            string CurrIndicator = "";
            string PrevIndicator = "";
            for (int i = 1; i < text.Length; i++)
            {
                tmpVec = text[i].Split(',');
                CurrIndicator = tmpVec[tmpVec.Length - 1];
                if (CurrIndicator != PrevIndicator)
                {
                    if (CurrIndicator != _indicator1 && CurrIndicator != _indicator3 && _indicator2 == "")
                    {
                        _indicator2 = CurrIndicator;
                    }
                    if (CurrIndicator != _indicator1 && CurrIndicator != _indicator2 && _indicator3 == "")
                    {
                        _indicator3 = CurrIndicator;
                    }

                    if (CurrIndicator != _indicator2 && CurrIndicator != _indicator3 && _indicator1 == "")
                    {
                        _indicator1 = CurrIndicator;
                    }

                }
                PrevIndicator = CurrIndicator;
            }
            //textBox1.Text = Indicator1 + Indicator2 + Indicator3;
            
        }
        public void  ArrangeData(string path)
        {
            var fileReader = new FileReader(path);           
            string[] text = fileReader.ReadFile();
            FindIndicators(path,text);
            string CurrIndicator = "";
            string PrevIndicator = "";
            for (int i = 1; i < text.Length; i++)
            {
                string[] sVec=text[i].Split(',');
                CurrIndicator = sVec[sVec.Length - 1];
                /*for (int j=0;j<sVec.Length-1;j++)*/
                {
                    if (CurrIndicator == Indicator1)
                    {
                        System.Array.Resize(ref sVec, sVec.Length - 1);                       
                        _species1.Add( new MathVector(sVec));
                    }
                    else 
                    if(CurrIndicator == Indicator2)
                    {
                        System.Array.Resize(ref sVec, sVec.Length - 1);
                        _species2.Add(new MathVector(sVec));

                    }
                    else
                    {
                        System.Array.Resize(ref sVec, sVec.Length - 1);
                        _species3.Add(new MathVector(sVec));
                    }

                }
            }
        }
    }
}
