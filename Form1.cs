using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            clickPicture.Visible = true;
        }

        private void clickLabel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clickLabel.Visible = false;
        }

        private void clickPicture_Click(object sender, EventArgs e)
        {
            clickPicture.Visible = false;
        }

        private void clickPicture_DoubleClick(object sender, EventArgs e)
        {
            clickPicture.Visible = false;
            var newvar = new Class1();
            newvar.Name = "";
        }

        private void clickLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
