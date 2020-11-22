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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void showNonlinearCurvesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ShowCurves());
        }

        private void createNonlinearCurveFromFictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new ReadCurveFromFike());
        }

        private void editParameterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new EditGlobalVar());
        }

        private void ShowFormInPanel(Form formPanel)
        {
            formPanel.TopLevel = false;
            formPanel.AutoScroll = true;
            formPanel.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(formPanel);
            formPanel.Dock = DockStyle.Fill;
            formPanel.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
    }
}
