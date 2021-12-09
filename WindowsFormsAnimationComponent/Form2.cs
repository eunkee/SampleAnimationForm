using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindowHelper.AnimateWindow(this.Handle, 200, 
                AnimateWindowHelper.AnimateWindowFlags.AW_HIDE 
                | AnimateWindowHelper.AnimateWindowFlags.AW_CENTER);
        }
    }
}
