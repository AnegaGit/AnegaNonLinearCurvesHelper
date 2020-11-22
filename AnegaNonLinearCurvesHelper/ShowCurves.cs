using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnegaNonLinearCurvesHelper
{
    public partial class ShowCurves : Form
    {
        public ShowCurves()
        {
            InitializeComponent();
            selectTrend.Items.Clear();
            for (int i = 0; i < GlobalVar.maxNonLinearCurves; i++)
            {
                selectTrend.Items.Add(i);
            }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            openFileDialogJson.InitialDirectory = GlobalVar.parameterFolder;
            DialogResult result = openFileDialogJson.ShowDialog();
            if (result == DialogResult.OK)
            {
                NonLinearCurves.LoadParameter(openFileDialogJson.FileName);
            }
        
        }

        private void selectTrend_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCurve = selectTrend.SelectedIndex;
            listTrend.Clear();
            float trendValue;
            curveTrend.Series["TrendData"].Points.Clear();

            for (int i = 0; i < 101; i++)
            {
                trendValue = NonLinearCurves.GetValue(selectedCurve, i);
                curveTrend.Series["TrendData"].Points.AddXY(i, trendValue);
                listTrend.Text += String.Format("{0,3} ==> {1,3:0.00}", i, trendValue) + Environment.NewLine;
            }
            curveTrend.Show();
        }
    }
}
