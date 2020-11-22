using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

namespace AnegaNonLinearCurvesHelper
{

    static class NonLinearCurves
    {
        private static float[,] curves = new float[GlobalVar.maxNonLinearCurves, 101];
        private static string parameterFile = GlobalVar.parameterFolder + "\\" + GlobalVar.fileNonLinearCurves;
        private static NonlinearCurvesParameter loadedParameter = new NonlinearCurvesParameter();

        public static void LoadParameter(string fileName)
        {
            try
            {
                StreamReader stream = new StreamReader(fileName);
                string jsonFile = stream.ReadToEnd();
                stream.Close();
                loadedParameter = JsonConvert.DeserializeObject<NonlinearCurvesParameter>(jsonFile);
                curves = loadedParameter.curves;
            }
            catch
            {
                MessageBox.Show("Error on load file "+fileName);              
            }
        }

        public static float GetValue(int curveId, int pos0_100)
        {
            pos0_100 = GlobalFunc.KeepInRange(pos0_100, 0, 100);
            curveId = GlobalFunc.KeepInRange(curveId, 0, GlobalVar.maxNonLinearCurves - 1);
            float result;
            try
            {
                result = curves[curveId, pos0_100];
            }
            catch
            {
                result = pos0_100;
            }
            return result;
        }
        public static float GetValue(int curveId, double pos0_1)
        {
            int pos0_100 = (int)(pos0_1 * 100);
            return GetValue(curveId, pos0_100);
        }

        public static double GetValue0_1(int curveId, double pos0_1)
        {
            double pos = pos0_1 * 100;
            int pos0_100 = (int)pos;
            int pos0_101 = pos0_100++;
            pos0_100 = GlobalFunc.KeepInRange(pos0_100, 0, 100);
            pos0_101 = GlobalFunc.KeepInRange(pos0_101, 0, 100);
            curveId = GlobalFunc.KeepInRange(curveId, 0, GlobalVar.maxNonLinearCurves - 1);
            double result;
            try
            {
                float v1 = curves[curveId, pos0_100];
                float v2 = curves[curveId, pos0_101];
                result = (v1 + (pos - pos0_1) * (v2 - v1)) / 100d;
            }
            catch
            {
                result = pos0_100;
            }
            return result;

        }
    }

    class NonlinearCurvesParameter
    {
        public float[,] curves = new float[GlobalVar.maxNonLinearCurves, 101];
    }
}
