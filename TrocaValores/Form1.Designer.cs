namespace TrocaValores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnClicar = new Button();
            LblValor1 = new Label();
            LblValor2 = new Label();
            TxtValor1 = new TextBox();
            TxtValor2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // BtnClicar
            // 
            BtnClicar.BackColor = Color.Black;
            BtnClicar.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClicar.ForeColor = Color.Red;
            BtnClicar.Image = Properties.Resources.Ícone_Botão;
            BtnClicar.Location = new Point(362, 230);
            BtnClicar.Name = "BtnClicar";
            BtnClicar.Size = new Size(96, 78);
            BtnClicar.TabIndex = 0;
            BtnClicar.Text = "Trocar";
            BtnClicar.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnClicar.UseVisualStyleBackColor = false;
            BtnClicar.Click += BtnClicar_Click;
            // 
            // LblValor1
            // 
            LblValor1.AutoSize = true;
            LblValor1.BackColor = Color.Black;
            LblValor1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblValor1.ForeColor = Color.Red;
            LblValor1.Location = new Point(58, 28);
            LblValor1.Name = "LblValor1";
            LblValor1.Size = new Size(36, 19);
            LblValor1.TabIndex = 1;
            LblValor1.Text = "Pix1";
            // 
            // LblValor2
            // 
            LblValor2.AutoSize = true;
            LblValor2.BackColor = Color.Black;
            LblValor2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblValor2.ForeColor = Color.Red;
            LblValor2.Location = new Point(58, 96);
            LblValor2.Name = "LblValor2";
            LblValor2.Size = new Size(36, 19);
            LblValor2.TabIndex = 2;
            LblValor2.Text = "Pix2";
            LblValor2.Click += LblValor2_Click;
            // 
            // TxtValor1
            // 
            TxtValor1.BackColor = SystemColors.InactiveCaptionText;
            TxtValor1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtValor1.ForeColor = Color.Red;
            TxtValor1.Location = new Point(100, 21);
            TxtValor1.Name = "TxtValor1";
            TxtValor1.Size = new Size(100, 26);
            TxtValor1.TabIndex = 3;
            TxtValor1.TextChanged += TxtValor1_TextChanged;
            // 
            // TxtValor2
            // 
            TxtValor2.BackColor = SystemColors.InactiveCaptionText;
            TxtValor2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtValor2.ForeColor = Color.Red;
            TxtValor2.Location = new Point(100, 93);
            TxtValor2.Name = "TxtValor2";
            TxtValor2.Size = new Size(100, 26);
            TxtValor2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.cleide;
            pictureBox1.Location = new Point(2, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cleide2;
            pictureBox2.Location = new Point(583, 167);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 109);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.dia;
            pictureBox3.Location = new Point(100, 318);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(217, 127);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.friozinho;
            pictureBox4.Location = new Point(503, 308);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(210, 137);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.playtv;
            pictureBox5.Location = new Point(559, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(243, 149);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            BackgroundImage = Properties.Resources.GS2zNRaWYAAUeT1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(TxtValor2);
            Controls.Add(TxtValor1);
            Controls.Add(LblValor2);
            Controls.Add(LblValor1);
            Controls.Add(BtnClicar);
            Name = "Form1";
            Text = "Sexta Feira Play TV";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnClicar;
        private Label LblValor1;
        private Label LblValor2;
        private TextBox TxtValor1;
        private TextBox TxtValor2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
