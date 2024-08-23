namespace AulasWindowsForms
{
    partial class FrmRestoDivisao
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
            BtnRestoDaDivisao = new Button();
            LblDividendo = new Label();
            LblDivisor = new Label();
            LblResto = new Label();
            TxtResto = new TextBox();
            TxtDividendo = new TextBox();
            TxtDivisor = new TextBox();
            SuspendLayout();
            // 
            // BtnRestoDaDivisao
            // 
            BtnRestoDaDivisao.Location = new Point(21, 76);
            BtnRestoDaDivisao.Name = "BtnRestoDaDivisao";
            BtnRestoDaDivisao.Size = new Size(190, 23);
            BtnRestoDaDivisao.TabIndex = 2;
            BtnRestoDaDivisao.Text = "Resto Divisao";
            BtnRestoDaDivisao.UseVisualStyleBackColor = true;
            BtnRestoDaDivisao.Click += BtnRestoDaDivisao_Click;
            // 
            // LblDividendo
            // 
            LblDividendo.AutoSize = true;
            LblDividendo.Location = new Point(21, 22);
            LblDividendo.Name = "LblDividendo";
            LblDividendo.Size = new Size(64, 15);
            LblDividendo.TabIndex = 1;
            LblDividendo.Text = "Dividendo:";
            // 
            // LblDivisor
            // 
            LblDivisor.AutoSize = true;
            LblDivisor.Location = new Point(255, 22);
            LblDivisor.Name = "LblDivisor";
            LblDivisor.Size = new Size(46, 15);
            LblDivisor.TabIndex = 2;
            LblDivisor.Text = "Divisor:";
            // 
            // LblResto
            // 
            LblResto.AutoSize = true;
            LblResto.Location = new Point(255, 80);
            LblResto.Name = "LblResto";
            LblResto.Size = new Size(39, 15);
            LblResto.TabIndex = 3;
            LblResto.Text = "Resto:";
            // 
            // TxtResto
            // 
            TxtResto.Enabled = false;
            TxtResto.Location = new Point(311, 76);
            TxtResto.Name = "TxtResto";
            TxtResto.ReadOnly = true;
            TxtResto.Size = new Size(100, 23);
            TxtResto.TabIndex = 4;
            TxtResto.TabStop = false;
            // 
            // TxtDividendo
            // 
            TxtDividendo.Location = new Point(111, 19);
            TxtDividendo.Name = "TxtDividendo";
            TxtDividendo.Size = new Size(100, 23);
            TxtDividendo.TabIndex = 0;
            // 
            // TxtDivisor
            // 
            TxtDivisor.Location = new Point(311, 22);
            TxtDivisor.Name = "TxtDivisor";
            TxtDivisor.Size = new Size(100, 23);
            TxtDivisor.TabIndex = 1;
            // 
            // FrmRestoDivisao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 116);
            Controls.Add(TxtDivisor);
            Controls.Add(TxtDividendo);
            Controls.Add(TxtResto);
            Controls.Add(LblResto);
            Controls.Add(LblDivisor);
            Controls.Add(LblDividendo);
            Controls.Add(BtnRestoDaDivisao);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmRestoDivisao";
            Text = "FrmRestoDivisao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRestoDaDivisao;
        private Label LblDividendo;
        private Label LblDivisor;
        private Label LblResto;
        private TextBox TxtResto;
        private TextBox TxtDividendo;
        private TextBox TxtDivisor;
    }
}