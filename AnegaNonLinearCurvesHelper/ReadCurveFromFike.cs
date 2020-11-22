using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AnegaNonLinearCurvesHelper
{
    public partial class ReadCurveFromFike : Form
    {
        Bitmap picture;
        public ReadCurveFromFike()
        {
            InitializeComponent();
        }

        private void ButtonLoad_Click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                picture = (Bitmap)Image.FromFile(openFileDialog.FileName);
                ProcessPicture(true);
            }
        }


        private void ButtonLoadInt_Click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                picture = (Bitmap)Image.FromFile(openFileDialog.FileName);
                ProcessPicture(false);
            }
        }

        private void ProcessPicture(bool asFloat)
        {
            int xPixel;
            float yProzent;
            Color thisPixel;
            int darkestColor;

            string result = "";
            pictureBox.Image = picture;
            int xSize = picture.Width - 1;
            int ySize = picture.Height - 1;
            for (int i = 0; i <= 100; i++)
            {
                xPixel = (int)(1d * xSize / 100 * i);
                darkestColor = 765;
                for (int j = ySize; j >= 0; j--)
                {
                    thisPixel = picture.GetPixel(xPixel, j);
                    if (thisPixel.ToArgb() != Color.White.ToArgb() || darkestColor < 765)
                    {
                        if (thisPixel.R + thisPixel.G + thisPixel.B < darkestColor)
                        {
                            darkestColor = thisPixel.R + thisPixel.G + thisPixel.B;
                        }
                        else
                        {
                            yProzent = Math.Abs((1f * j * 100 / ySize) - 100);

                            if (asFloat)
                                result += "," + string.Format(CultureInfo.InvariantCulture, "{0:0.00}", yProzent);
                            else
                                result += "," + string.Format(CultureInfo.InvariantCulture, "{0:0}", yProzent);
                            break;
                        }
                    }
                    if (j == 0)
                    {
                        result += ",n";
                    }
                }
            }
            textBoxResult.Text = result.Substring(1);
        }
    }
}
