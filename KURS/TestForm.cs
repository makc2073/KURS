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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
      


        private void TestForm_Load(object sender, EventArgs e)
        {

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            this.Close();
            Main newForm = new Main();
            newForm.Show();
            this.Visible = false;

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.Back2;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources.Back;
        }
    }
}
