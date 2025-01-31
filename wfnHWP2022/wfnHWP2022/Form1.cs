using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfnHWP2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openHWP();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        } //button1_Click

        private void openHWP()
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    axHwpCtrl1.Open(dlg.FileName);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
    }
}
