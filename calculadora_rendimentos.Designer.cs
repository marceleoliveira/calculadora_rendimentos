namespace App04
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.aporteGroupBox = new System.Windows.Forms.GroupBox();
            this.aporteTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mesesGroupBox = new System.Windows.Forms.GroupBox();
            this.prazoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.taxaGroupBox = new System.Windows.Forms.GroupBox();
            this.taxaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.aporteGroupBox.SuspendLayout();
            this.mesesGroupBox.SuspendLayout();
            this.taxaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // aporteGroupBox
            // 
            this.aporteGroupBox.Controls.Add(this.aporteTextBox);
            this.aporteGroupBox.Controls.Add(this.label3);
            this.aporteGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aporteGroupBox.Location = new System.Drawing.Point(12, 30);
            this.aporteGroupBox.Name = "aporteGroupBox";
            this.aporteGroupBox.Size = new System.Drawing.Size(200, 116);
            this.aporteGroupBox.TabIndex = 2;
            this.aporteGroupBox.TabStop = false;
            this.aporteGroupBox.Text = "APORTE";
            // 
            // aporteTextBox
            // 
            this.aporteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aporteTextBox.Location = new System.Drawing.Point(44, 65);
            this.aporteTextBox.Name = "aporteTextBox";
            this.aporteTextBox.Size = new System.Drawing.Size(100, 29);
            this.aporteTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "R$";
            // 
            // mesesGroupBox
            // 
            this.mesesGroupBox.Controls.Add(this.prazoTextBox);
            this.mesesGroupBox.Controls.Add(this.label2);
            this.mesesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesesGroupBox.Location = new System.Drawing.Point(245, 30);
            this.mesesGroupBox.Name = "mesesGroupBox";
            this.mesesGroupBox.Size = new System.Drawing.Size(200, 116);
            this.mesesGroupBox.TabIndex = 3;
            this.mesesGroupBox.TabStop = false;
            this.mesesGroupBox.Text = "PRAZO";
            // 
            // prazoTextBox
            // 
            this.prazoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prazoTextBox.Location = new System.Drawing.Point(6, 65);
            this.prazoTextBox.Name = "prazoTextBox";
            this.prazoTextBox.Size = new System.Drawing.Size(100, 29);
            this.prazoTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "MESES";
            // 
            // taxaGroupBox
            // 
            this.taxaGroupBox.Controls.Add(this.taxaTextBox);
            this.taxaGroupBox.Controls.Add(this.label1);
            this.taxaGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxaGroupBox.Location = new System.Drawing.Point(479, 30);
            this.taxaGroupBox.Name = "taxaGroupBox";
            this.taxaGroupBox.Size = new System.Drawing.Size(200, 116);
            this.taxaGroupBox.TabIndex = 4;
            this.taxaGroupBox.TabStop = false;
            this.taxaGroupBox.Text = "TAXA";
            // 
            // taxaTextBox
            // 
            this.taxaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxaTextBox.Location = new System.Drawing.Point(6, 65);
            this.taxaTextBox.Name = "taxaTextBox";
            this.taxaTextBox.Size = new System.Drawing.Size(100, 29);
            this.taxaTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "%a.m.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(245, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor total ao final do período: R$";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(345, 265);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 29);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lucro real do período:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(345, 316);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 29);
            this.textBox5.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 386);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.taxaGroupBox);
            this.Controls.Add(this.mesesGroupBox);
            this.Controls.Add(this.aporteGroupBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de rendimentos";
            this.aporteGroupBox.ResumeLayout(false);
            this.aporteGroupBox.PerformLayout();
            this.mesesGroupBox.ResumeLayout(false);
            this.mesesGroupBox.PerformLayout();
            this.taxaGroupBox.ResumeLayout(false);
            this.taxaGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox aporteGroupBox;
        private System.Windows.Forms.GroupBox mesesGroupBox;
        private System.Windows.Forms.GroupBox taxaGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aporteTextBox;
        private System.Windows.Forms.TextBox prazoTextBox;
        private System.Windows.Forms.TextBox taxaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
    }
}

