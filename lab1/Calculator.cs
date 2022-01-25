using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab1
{
    public class Calculator
    {
        private double _firstValue = 0;
        private double _secondValue = 0;
        private string _operation;
        private string _prevOperation;
        private int _mem;
        private bool checkSecondValue = false;
        public Calculator()
        {

        }
        public void getOperation(object sender, string text)
        {

            Button tmp = (Button)sender;
            _operation = tmp.Text;
            _firstValue = Convert.ToDouble(text);
            checkSecondValue = true;

        }
        public Result input(object sender, string text)
        {
            Result result = new Result();
            result.clear = false;
            if (checkSecondValue)
            {
                result.clear = true;
                checkSecondValue = false;
            }
            Button tmp = (Button)sender;
            if (text == "0")
                result.text = tmp.Text;
            else
                result.text = text + tmp.Text;

            return result;
        }
        public string equals(string text)
        {
            if (_operation != "=")
            {
                _secondValue = Convert.ToDouble(text);

            }
            else
            {
                _firstValue = Convert.ToDouble(text);
                _operation = _prevOperation;
            }

            double dFirstValue = Convert.ToDouble(_firstValue);
            double dSecondValue = Convert.ToDouble(_secondValue);
            double Res = 0;
            string sRes = "";
            if (_operation == "+")
            {
                Res = dFirstValue + dSecondValue;
                sRes = Res.ToString();
            }
            if (_operation == "-")
            {
                Res = dFirstValue - dSecondValue;
                sRes = Res.ToString();
            }
            if (_operation == "*")
            {
                Res = dFirstValue * dSecondValue;
                sRes = Res.ToString();
            }
            if (_operation == "➗")
            {
                if (dSecondValue == 0)
                {
                    sRes = "Math Error";
                }
                else
                {
                    Res = dFirstValue / dSecondValue;
                    sRes = Res.ToString();
                }
            }
            _prevOperation = _operation;
            _operation = "=";
            checkSecondValue = true;

            return sRes;

        }
        public string sqrt(string text)
        {
            string sRes;
            if (int.Parse(text) < 0)
            {
                sRes = "Math Error";
            }
            else
            {
                double dFirstValue = Convert.ToDouble(text);
                sRes = Math.Sqrt(dFirstValue).ToString();
            }
            return sRes;
        }
        public void saveMem(string text)
        {
            _mem = int.Parse(text);
        }
        public string addMem(string text)
        {
            int tmp = int.Parse(text);
            return (_mem + tmp).ToString();
        }
        public string subMem(string text)
        {
            int tmp = int.Parse(text);
            return (_mem - tmp).ToString();
        }
        public string SwitchSign(string text)
        {
            string sRes;
            int Itext = int.Parse(text) * -1;
            text = Itext.ToString();
            return text;
        }
        public double power2(string text)
        {
            _firstValue = int.Parse(text);
            double dFirstValue = Convert.ToDouble(_firstValue);
            dFirstValue = Math.Pow(dFirstValue,2);
            return dFirstValue;
        }
        public double divide1ByX(string text)
        {
            _firstValue = int.Parse(text);
            double dFirstValue = Convert.ToDouble(_firstValue);
            dFirstValue = 1/dFirstValue;
            return dFirstValue;
        }
        
        public double clear(string text)
        {
            _firstValue = 0;
            _secondValue = 0;
            _operation = "";
            checkSecondValue = false;
            return _firstValue;
        }

    }
}
