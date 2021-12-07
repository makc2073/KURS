using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.test2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.test1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TestForm newForm = new TestForm();
            newForm.Show();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxExit_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxExit.Size = new Size(146, 147);
        }

        private void pictureBoxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxExit.Size = new Size(136, 137);
        }
    }
}
