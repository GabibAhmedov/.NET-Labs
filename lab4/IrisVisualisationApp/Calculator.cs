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
   public class Calculator
    {            
        public Calculator()
        {

        }
       public void CalculateAverages(List<IMathVector> Species1,List<IMathVector> Species2, List<IMathVector> Species3,DataFormer data)
        {
            var tmpArr=new MathVector(4,0);

            for (int i=0;i< Species1[i].Dimensions; i++)
            {
                for (int j = 0; j < Species1.Count; j++)
                tmpArr[i] = tmpArr[i]+ Species1[j][i];
            }
            for (int i = 0; i < Species1[i].Dimensions; i++)
            {
                tmpArr[i] = tmpArr[i]/Species1.Count;
            }
            data.AvgVector1 = tmpArr;
            tmpArr.ClearVec();


            for (int i = 0; i < Species2[i].Dimensions; i++)
            {
                for (int j = 0; j < Species2.Count; j++)
                    tmpArr[i] = tmpArr[i] + Species2[j][i];
            }
            for (int i = 0; i < Species2[i].Dimensions; i++)
            {
                tmpArr[i] = tmpArr[i] / Species2.Count;
            }
            data.AvgVector2 = tmpArr;
            tmpArr.ClearVec();


            for (int i = 0; i < Species3[i].Dimensions; i++)
            {
                for (int j = 0; j < Species3.Count; j++)
                    tmpArr[i] = tmpArr[i] + Species3[j][i];
            }
            for (int i = 0; i < Species3[i].Dimensions; i++)
            {
                tmpArr[i] = tmpArr[i] / Species3.Count;
            }
            data.AvgVector3 = tmpArr;
            tmpArr.ClearVec();
        }
        public void CalculateDistance(MathVector AvgVector1, MathVector AvgVector2, MathVector AvgVector3,DataFormer data)
        {
            data.DistBetween12=AvgVector1.CalcDistance(AvgVector2);
            data.DistBetween13=AvgVector1.CalcDistance(AvgVector3);
            data.DistBetween23=AvgVector2.CalcDistance(AvgVector3);
        }
    }
}
