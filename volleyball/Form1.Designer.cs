namespace Volleyball_Problem
{
    partial class Form1
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
            this.txthasil = new System.Windows.Forms.TextBox();
            this.Buttonhasil = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txthasil
            // 
            this.txthasil.Location = new System.Drawing.Point(341, 144);
            this.txthasil.Margin = new System.Windows.Forms.Padding(2);
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(68, 20);
            this.txthasil.TabIndex = 22;
            // 
            // Buttonhasil
            // 
            this.Buttonhasil.BackColor = System.Drawing.Color.Gray;
            this.Buttonhasil.ForeColor = System.Drawing.Color.White;
            this.Buttonhasil.Location = new System.Drawing.Point(19, 98);
            this.Buttonhasil.Name = "Buttonhasil";
            this.Buttonhasil.Size = new System.Drawing.Size(75, 60);
            this.Buttonhasil.TabIndex = 21;
            this.Buttonhasil.Text = "Result";
            this.Buttonhasil.UseVisualStyleBackColor = false;
            this.Buttonhasil.Click += new System.EventHandler(this.Buttonhasil_Click_1);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(79, 61);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(120, 20);
            this.txt2.TabIndex = 20;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged_1);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(79, 22);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(120, 20);
            this.txt1.TabIndex = 19;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Score B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Score A";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 177);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.Buttonhasil);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthasil;
        private System.Windows.Forms.Button Buttonhasil;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

