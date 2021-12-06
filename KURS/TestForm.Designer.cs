
namespace KURS
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Word = new System.Windows.Forms.Label();
            this.pictureBoxPen = new System.Windows.Forms.PictureBox();
            this.pictureBoxApple = new System.Windows.Forms.PictureBox();
            this.pictureBoxMouse = new System.Windows.Forms.PictureBox();
            this.pictureBoxCheese = new System.Windows.Forms.PictureBox();
            this.Result = new System.Windows.Forms.Label();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::KURS.Properties.Resources.Back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 584);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Word
            // 
            this.Word.AutoSize = true;
            this.Word.BackColor = System.Drawing.Color.Transparent;
            this.Word.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Word.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Word.Location = new System.Drawing.Point(536, 151);
            this.Word.Name = "Word";
            this.Word.Size = new System.Drawing.Size(0, 48);
            this.Word.TabIndex = 2;
            this.Word.Click += new System.EventHandler(this.Word_Click);
            // 
            // pictureBoxPen
            // 
            this.pictureBoxPen.Image = global::KURS.Properties.Resources.Pencil;
            this.pictureBoxPen.Location = new System.Drawing.Point(132, 324);
            this.pictureBoxPen.Name = "pictureBoxPen";
            this.pictureBoxPen.Size = new System.Drawing.Size(230, 254);
            this.pictureBoxPen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPen.TabIndex = 3;
            this.pictureBoxPen.TabStop = false;
            this.pictureBoxPen.Click += new System.EventHandler(this.pictureBoxPen_Click);
            // 
            // pictureBoxApple
            // 
            this.pictureBoxApple.Image = global::KURS.Properties.Resources.Apple;
            this.pictureBoxApple.Location = new System.Drawing.Point(382, 324);
            this.pictureBoxApple.Name = "pictureBoxApple";
            this.pictureBoxApple.Size = new System.Drawing.Size(230, 254);
            this.pictureBoxApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxApple.TabIndex = 4;
            this.pictureBoxApple.TabStop = false;
            this.pictureBoxApple.Click += new System.EventHandler(this.pictureBoxApple_Click);
            // 
            // pictureBoxMouse
            // 
            this.pictureBoxMouse.Image = global::KURS.Properties.Resources.Мouse;
            this.pictureBoxMouse.Location = new System.Drawing.Point(632, 324);
            this.pictureBoxMouse.Name = "pictureBoxMouse";
            this.pictureBoxMouse.Size = new System.Drawing.Size(230, 254);
            this.pictureBoxMouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMouse.TabIndex = 5;
            this.pictureBoxMouse.TabStop = false;
            this.pictureBoxMouse.Click += new System.EventHandler(this.pictureBoxMouse_Click);
            // 
            // pictureBoxCheese
            // 
            this.pictureBoxCheese.Image = global::KURS.Properties.Resources.Сheese;
            this.pictureBoxCheese.Location = new System.Drawing.Point(882, 324);
            this.pictureBoxCheese.Name = "pictureBoxCheese";
            this.pictureBoxCheese.Size = new System.Drawing.Size(230, 254);
            this.pictureBoxCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCheese.TabIndex = 6;
            this.pictureBoxCheese.TabStop = false;
            this.pictureBoxCheese.Click += new System.EventHandler(this.pictureBoxCheese_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.Color.Transparent;
            this.Result.Font = new System.Drawing.Font("Impact", 50F);
            this.Result.ForeColor = System.Drawing.Color.Lime;
            this.Result.Location = new System.Drawing.Point(148, 230);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 82);
            this.Result.TabIndex = 7;
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxStart.Image = global::KURS.Properties.Resources.Start;
            this.pictureBoxStart.Location = new System.Drawing.Point(515, 360);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(198, 167);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStart.TabIndex = 8;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.Click += new System.EventHandler(this.pictureBoxStart_Click);
            this.pictureBoxStart.MouseLeave += new System.EventHandler(this.pictureBoxStart_MouseLeave);
            this.pictureBoxStart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxStart_MouseMove);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::KURS.Properties.Resources.Front2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 733);
            this.ControlBox = false;
            this.Controls.Add(this.Result);
            this.Controls.Add(this.pictureBoxCheese);
            this.Controls.Add(this.pictureBoxMouse);
            this.Controls.Add(this.pictureBoxApple);
            this.Controls.Add(this.pictureBoxPen);
            this.Controls.Add(this.Word);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxStart);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "TestForm";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.TestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Word;
        private System.Windows.Forms.PictureBox pictureBoxPen;
        private System.Windows.Forms.PictureBox pictureBoxApple;
        private System.Windows.Forms.PictureBox pictureBoxMouse;
        private System.Windows.Forms.PictureBox pictureBoxCheese;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.PictureBox pictureBoxStart;
    }
}