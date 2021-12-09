using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        int score;
        int combo;
        int maxcombo = 0;
        int addscore = 0;
        private void TestForm_Load(object sender, EventArgs e)
        {

            labelUname.Text = User.uname;
            labelUScore.Text = User.uscore;
            addscore = Convert.ToInt32(User.uscore);

            this.Location = new Point(200, 200);
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
            pictureBox2.Visible = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Main newForm = new Main();
            newForm.Show();
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
        async Task addscAsync()
        {
            
            addscore = addscore + 5;
            User.uscore = addscore.ToString();
            labelUScore.Text = labelUScore.Text + "+ 5";
            await Task.Delay(1000);
            labelUScore.Text = addscore.ToString();
            User.upd();
        }
        private void pictureBoxPen_ClickAsync(object sender, EventArgs e)
        {
            Result.Visible = true;
            locResult(pictureBoxPen.Location);
            if (Word.Text == "Pencil")
            { score++; combo++; pictureBoxTrue.Visible = true; Result.ForeColor = Color.Lime; Result.Text = "Greate"; _ = sortAsync();  }
            else
            { combo = 0; Result.ForeColor = Color.Red; Result.Text = "false";  }
            sc();
            if (combo == 5)
            { 
                addscAsync();
            }
        }
        private void pictureBoxApple_Click(object sender, EventArgs e)
        {
            Result.Visible = true;
            locResult(pictureBoxApple.Location);
            if (Word.Text == "Apple")
            { score++; combo++; pictureBoxTrue.Visible = true; Result.ForeColor = Color.Lime; Result.Text = "Greate"; _ = sortAsync();  }
            else
            { combo = 0; Result.ForeColor = Color.Red; Result.Text = "false"; }
            sc();
            if (combo == 5)
            {
                addscAsync();
            }
        }

        private void pictureBoxMouse_Click(object sender, EventArgs e)
        {
            Result.Visible = true;
            locResult(pictureBoxMouse.Location);
            if (Word.Text == "Mouse")
            { score++; combo++; pictureBoxTrue.Visible = true; Result.ForeColor = Color.Lime; Result.Text = "Greate"; _ = sortAsync();  }
            else
            { combo = 0; Result.ForeColor = Color.Red; Result.Text = "false"; }
            sc();
            if (combo == 5)
            {
                addscAsync();
            }
        }

        private void pictureBoxCheese_Click(object sender, EventArgs e)
        {
            Result.Visible = true;
            locResult(pictureBoxCheese.Location);
            if (Word.Text == "Cheese")
            { score++; combo++; pictureBoxTrue.Visible = true; Result.ForeColor = Color.Lime; Result.Text = "Greate"; _ = sortAsync();  }
            else
            { combo = 0; Result.ForeColor = Color.Red; Result.Text = "false";  }
            sc();
            if (combo == 5)
            {

               
                addscAsync();
            }
        }
        void sc()
        {
            Score.Text = Convert.ToString(score);
            Combo.Text = Convert.ToString(combo);
            if (maxcombo < combo)
            {maxcombo = combo; MaxComdo.Text = Convert.ToString(maxcombo);}             
        }
        private void pictureBoxStart_Click(object sender, EventArgs e)
        {
            _ = sortAsync();           
            pictureBoxStart.Visible = false;
        }
        async Task sortAsync()
        {
            
            pictureBoxPen.Visible = false;
            pictureBoxMouse.Visible = false;
            pictureBoxCheese.Visible = false;
            pictureBoxApple.Visible = false;
            pictureBox2.Visible = true;

            await Task.Delay(1000);
            Random rand = new Random();
            int[] loc = new[] { 632, 132, 382, 882 };
            for (int i = loc.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
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
                var temp = word[j];
                word[j] = word[i];
                word[i] = temp;
                Word.Text = word[i];
            }
            pictureBox2.Visible = false;
            Result.Visible = false;
            
            pictureBoxPen.Visible = true;
            pictureBoxMouse.Visible = true;
            pictureBoxCheese.Visible = true;
            pictureBoxApple.Visible = true;
            pictureBoxTrue.Visible = false;

        }

        private void pictureBoxStart_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxStart.BackgroundImage = Properties.Resources.Start;
        }

        private void pictureBoxStart_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxStart.BackgroundImage = Properties.Resources.Start2;
            //Sizer(pictureBoxStart);
        }

        private void Word_Click(object sender, EventArgs e)
        {
            
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
          
        }

        private void pictureBoxTrue_Click(object sender, EventArgs e)
        {
           
        }
        public void Sizer(PictureBox a)
        {
            a.Size = new Size(240, 264);
        }
        public void UnSizer(PictureBox a)
        {
            a.Size = new Size(230, 254);
        }

        private void pictureBoxPen_MouseMove(object sender, MouseEventArgs e)
        {
            Sizer(pictureBoxPen);
        }

        private void pictureBoxPen_MouseLeave(object sender, EventArgs e)
        {
            UnSizer(pictureBoxPen);
        }

        private void pictureBoxApple_MouseMove(object sender, MouseEventArgs e)
        {
            Sizer(pictureBoxApple);
        }

        private void pictureBoxApple_MouseLeave(object sender, EventArgs e)
        {
            UnSizer(pictureBoxApple);
        }

        private void pictureBoxMouse_MouseLeave(object sender, EventArgs e)
        {
            UnSizer(pictureBoxMouse);
        }

        private void pictureBoxMouse_MouseMove(object sender, MouseEventArgs e)
        {
            Sizer(pictureBoxMouse);
        }

        private void pictureBoxCheese_MouseLeave(object sender, EventArgs e)
        {
            UnSizer(pictureBoxCheese);
        }

        private void pictureBoxCheese_MouseMove(object sender, MouseEventArgs e)
        {
            Sizer(pictureBoxCheese);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combo_Click(object sender, EventArgs e)
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
