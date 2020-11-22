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
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();

            ioVersion.Text = "Version: "+ GetVersion();
        }

        public static string GetVersion()
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.Reflection.AssemblyName myAssemblyName = myAssembly.GetName();
            return myAssemblyName.Version.ToString();
        }
    }
}
