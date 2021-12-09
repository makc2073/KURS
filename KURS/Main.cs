using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        void view1()
        {
            string connectionString = "Data Source=10.10.1.24;Initial Catalog=MakcKURS;User ID=pro-41;Password=Pro_41student";
            string sql = "SELECT Name, Score FROM Users";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Создаем объект DataAdapter
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                // Создаем объект Dataset
                DataSet ds = new DataSet();
                // Заполняем Dataset
                adapter.Fill(ds);
                // Отображаем данные
                dataGridViewBoard.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(200, 200);
            view1();

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



        private void Add_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=10.10.1.24;Initial Catalog=MakcKURS;User ID=pro-41;Password=Pro_41student";
            string sqlExpression = "INSERT INTO Users (Name, Score) VALUES ('" + textBox1.Text + "', 0)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();

            }
            view1();
        }

        private void dataGridViewBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               
        }
        public string n;
        public string s;
        public int c;
       
        private void Enter_Click(object sender, EventArgs e)
        {
            n = dataGridViewBoard.Rows[c].Cells[0].Value.ToString();
            name.Text = n;
            s = dataGridViewBoard.Rows[c].Cells[1].Value.ToString();
            LabelScore.Text = s;
            
            User.uname = n;
            User.uscore = s;
        }
        
        
        private void dataGridViewBoard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            c = dataGridViewBoard.CurrentCell.RowIndex;
        }

      
    }
}
