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
            Random rand = new Random();
            int[] loc = new[] { 632, 132, 382, 882 };
            for (int i = loc.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                // обменять значения data[j] и data[i]
                var temp = loc[j];
                loc[j] = loc[i];
                loc[i] = temp;
                pictureBoxPen.Location = new Point(loc[0], 324);
                pictureBoxMouse.Location = new Point(loc[1], 324);
                pictureBoxCheese.Location = new Point(loc[2], 324);
                pictureBoxApple.Location = new Point(loc[3], 324);
            }
            pictureBoxStart.Visible = true;
            pictureBoxPen.Visible = false;
            pictureBoxMouse.Visible = false;
            pictureBoxCheese.Visible = false;
            pictureBoxApple.Visible = false;
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

        void locResult(Point c)
        {
            c.Y = 230;
            Result.Location = c;
        }

        private void pictureBoxPen_Click(object sender, EventArgs e)
        {
            locResult(pictureBoxPen.Location);
            if (Word.Text == "Pencil")
            { Result.ForeColor = Color.Lime; Result.Text = "Greate"; sort();}
            else
            { Result.ForeColor = Color.Red; Result.Text = "false"; }
        }
        private void pictureBoxApple_Click(object sender, EventArgs e)
        {
            locResult(pictureBoxApple.Location);
            if (Word.Text == "Apple")
            { Result.ForeColor = Color.Lime; Result.Text = "Greate"; sort(); }
            else
            { Result.ForeColor = Color.Red; Result.Text = "false"; }
        }

        private void pictureBoxMouse_Click(object sender, EventArgs e)
        {
            locResult(pictureBoxMouse.Location);
            if (Word.Text == "Mouse")
            { Result.ForeColor = Color.Lime; Result.Text = "Greate"; sort(); }
            else
            { Result.ForeColor = Color.Red; Result.Text = "false"; }
        }

        private void pictureBoxCheese_Click(object sender, EventArgs e)
        {
            locResult(pictureBoxCheese.Location);
            if (Word.Text == "Cheese")
            { Result.ForeColor = Color.Lime; Result.Text = "Greate"; sort(); }
            else
            { Result.ForeColor = Color.Red; Result.Text = "false";  }
        }



        private void pictureBoxStart_Click(object sender, EventArgs e)
        {
            
            sort();
            pictureBoxPen.Visible = true;
            pictureBoxMouse.Visible = true;
            pictureBoxCheese.Visible = true;
            pictureBoxApple.Visible = true;
            pictureBoxStart.Visible = false;
        }
        void sort()
        {
          
            Random rand = new Random();
            int[] loc = new[] { 632, 132, 382, 882 };
            for (int i = loc.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                // обменять значения data[j] и data[i]
                var temp = loc[j];
                loc[j] = loc[i];
                loc[i] = temp;
                pictureBoxPen.Location = new Point(loc[0], 324);
                pictureBoxMouse.Location = new Point(loc[1], 324);
                pictureBoxCheese.Location = new Point(loc[2], 324);
                pictureBoxApple.Location = new Point(loc[3], 324);
            }

            String[] word = new[] { "Cheese", "Mouse", "Pencil", "Apple" };
            for (int i = word.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                // обменять значения data[j] и data[i]
                var temp = word[j];
                word[j] = word[i];
                word[i] = temp;
                Word.Text = word[i];
            }
        }

        private void pictureBoxStart_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxStart.BackgroundImage = Properties.Resources.Start;
        }

        private void pictureBoxStart_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxStart.BackgroundImage = Properties.Resources.Start2;
        }

        private void Word_Click(object sender, EventArgs e)
        {

        }
      
    }
}
