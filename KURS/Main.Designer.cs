
namespace KURS
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.dataGridViewBoard = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.LabelScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::KURS.Properties.Resources.test1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxExit.Image = global::KURS.Properties.Resources.Exit;
            this.pictureBoxExit.Location = new System.Drawing.Point(1069, 580);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(136, 137);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxExit.TabIndex = 18;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            this.pictureBoxExit.MouseLeave += new System.EventHandler(this.pictureBoxExit_MouseLeave);
            this.pictureBoxExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxExit_MouseMove);
            // 
            // dataGridViewBoard
            // 
            this.dataGridViewBoard.AllowUserToResizeColumns = false;
            this.dataGridViewBoard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewBoard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBoard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            this.dataGridViewBoard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewBoard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(115)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBoard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBoard.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBoard.EnableHeadersVisualStyles = false;
            this.dataGridViewBoard.GridColor = System.Drawing.Color.BlanchedAlmond;
            this.dataGridViewBoard.Location = new System.Drawing.Point(980, 12);
            this.dataGridViewBoard.Name = "dataGridViewBoard";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBoard.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBoard.Size = new System.Drawing.Size(244, 150);
            this.dataGridViewBoard.TabIndex = 19;
            this.dataGridViewBoard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBoard_CellClick);
            this.dataGridViewBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBoard_CellContentClick);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Add.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.YellowGreen;
            this.Add.Location = new System.Drawing.Point(1174, 168);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(50, 41);
            this.Add.TabIndex = 20;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Enter
            // 
            this.Enter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Enter.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(924, 12);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(50, 50);
            this.Enter.TabIndex = 21;
            this.Enter.Text = "→";
            this.Enter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 20F);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(974, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 33);
            this.label4.TabIndex = 22;
            this.label4.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(977, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 41);
            this.textBox1.TabIndex = 24;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Showcard Gothic", 20F);
            this.name.ForeColor = System.Drawing.Color.Gold;
            this.name.Location = new System.Drawing.Point(1063, 212);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(88, 33);
            this.name.TabIndex = 26;
            this.name.Text = "name";
            // 
            // LabelScore
            // 
            this.LabelScore.AutoSize = true;
            this.LabelScore.BackColor = System.Drawing.Color.Transparent;
            this.LabelScore.Font = new System.Drawing.Font("Showcard Gothic", 20F);
            this.LabelScore.ForeColor = System.Drawing.Color.Gold;
            this.LabelScore.Location = new System.Drawing.Point(1063, 245);
            this.LabelScore.Name = "LabelScore";
            this.LabelScore.Size = new System.Drawing.Size(31, 33);
            this.LabelScore.TabIndex = 28;
            this.LabelScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 20F);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(974, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(924, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KURS.Properties.Resources.Front;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 729);
            this.Controls.Add(this.LabelScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridViewBoard);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Eng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.DataGridView dataGridViewBoard;
        private System.Windows.Forms.Button Add;
#pragma warning disable CS0108 // "Main.Enter" скрывает наследуемый член "Control.Enter". Если скрытие было намеренным, используйте ключевое слово new.
        private System.Windows.Forms.Button Enter;
#pragma warning restore CS0108 // "Main.Enter" скрывает наследуемый член "Control.Enter". Если скрытие было намеренным, используйте ключевое слово new.
#pragma warning disable CS0108 // "Main.Name" скрывает наследуемый член "Control.Name". Если скрытие было намеренным, используйте ключевое слово new.
#pragma warning restore CS0108 // "Main.Name" скрывает наследуемый член "Control.Name". Если скрытие было намеренным, используйте ключевое слово new.
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label LabelScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

