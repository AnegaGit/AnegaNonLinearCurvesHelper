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
    public partial class EditGlobalVar : Form
    {
        public EditGlobalVar()
        {
            InitializeComponent();

            ioFileName.Text = GlobalVar.fileNonLinearCurves;
            ioDirectorx.Text = GlobalVar.parameterFolder;
            ioMaxCount.Value = GlobalVar.maxNonLinearCurves;            
        }

        private void ioMaxCount_ValueChanged(object sender, EventArgs e)
        {
            GlobalVar.maxNonLinearCurves = (int)ioMaxCount.Value;
        }

        private void ioFileName_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.fileNonLinearCurves = ioFileName.Text;
        }

        private void ioDirectorx_TextChanged(object sender, EventArgs e)
        {
            GlobalVar.parameterFolder = ioDirectorx.Text;
        }
    }
}
