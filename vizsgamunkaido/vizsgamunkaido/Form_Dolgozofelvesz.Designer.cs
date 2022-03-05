
namespace vizsgamunkaido
{
    partial class Form_Dolgozofelvesz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_Vezeteknev = new System.Windows.Forms.TextBox();
            this.textBox2_Keresztnev = new System.Windows.Forms.TextBox();
            this.textBox3_Adoszam = new System.Windows.Forms.TextBox();
            this.textBox4_Anyjaneve = new System.Windows.Forms.TextBox();
            this.button1_Rogzit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vezetéknév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keresztnév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adószám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Anyja neve:";
            // 
            // textBox1_Vezeteknev
            // 
            this.textBox1_Vezeteknev.Location = new System.Drawing.Point(291, 58);
            this.textBox1_Vezeteknev.Name = "textBox1_Vezeteknev";
            this.textBox1_Vezeteknev.Size = new System.Drawing.Size(276, 22);
            this.textBox1_Vezeteknev.TabIndex = 4;
            // 
            // textBox2_Keresztnev
            // 
            this.textBox2_Keresztnev.Location = new System.Drawing.Point(291, 137);
            this.textBox2_Keresztnev.Name = "textBox2_Keresztnev";
            this.textBox2_Keresztnev.Size = new System.Drawing.Size(276, 22);
            this.textBox2_Keresztnev.TabIndex = 5;
            // 
            // textBox3_Adoszam
            // 
            this.textBox3_Adoszam.Location = new System.Drawing.Point(280, 223);
            this.textBox3_Adoszam.Name = "textBox3_Adoszam";
            this.textBox3_Adoszam.Size = new System.Drawing.Size(276, 22);
            this.textBox3_Adoszam.TabIndex = 6;
            // 
            // textBox4_Anyjaneve
            // 
            this.textBox4_Anyjaneve.Location = new System.Drawing.Point(280, 277);
            this.textBox4_Anyjaneve.Name = "textBox4_Anyjaneve";
            this.textBox4_Anyjaneve.Size = new System.Drawing.Size(276, 22);
            this.textBox4_Anyjaneve.TabIndex = 7;
            // 
            // button1_Rogzit
            // 
            this.button1_Rogzit.Location = new System.Drawing.Point(377, 341);
            this.button1_Rogzit.Name = "button1_Rogzit";
            this.button1_Rogzit.Size = new System.Drawing.Size(121, 70);
            this.button1_Rogzit.TabIndex = 8;
            this.button1_Rogzit.Text = "Rögzít";
            this.button1_Rogzit.UseVisualStyleBackColor = true;
            this.button1_Rogzit.Click += new System.EventHandler(this.button1_Rogzit_Click);
            // 
            // Form_Dolgozofelvesz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_Rogzit);
            this.Controls.Add(this.textBox4_Anyjaneve);
            this.Controls.Add(this.textBox3_Adoszam);
            this.Controls.Add(this.textBox2_Keresztnev);
            this.Controls.Add(this.textBox1_Vezeteknev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Dolgozofelvesz";
            this.Text = "Dolgozófelvesz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_Vezeteknev;
        private System.Windows.Forms.TextBox textBox2_Keresztnev;
        private System.Windows.Forms.TextBox textBox3_Adoszam;
        private System.Windows.Forms.TextBox textBox4_Anyjaneve;
        private System.Windows.Forms.Button button1_Rogzit;
    }
}