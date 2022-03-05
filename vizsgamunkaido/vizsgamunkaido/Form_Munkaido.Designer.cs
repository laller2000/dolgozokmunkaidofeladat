
namespace vizsgamunkaido
{
    partial class Form_Munkaido
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
            this.dataGridView1_Munkaido = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_Osszestul = new System.Windows.Forms.TextBox();
            this.textBox2_Fizetes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Munkaido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A kiválasztott dolgozó munkaidő nyilvántartása ";
            // 
            // dataGridView1_Munkaido
            // 
            this.dataGridView1_Munkaido.AllowUserToAddRows = false;
            this.dataGridView1_Munkaido.AllowUserToDeleteRows = false;
            this.dataGridView1_Munkaido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Munkaido.Location = new System.Drawing.Point(63, 93);
            this.dataGridView1_Munkaido.Name = "dataGridView1_Munkaido";
            this.dataGridView1_Munkaido.ReadOnly = true;
            this.dataGridView1_Munkaido.RowHeadersWidth = 51;
            this.dataGridView1_Munkaido.RowTemplate.Height = 24;
            this.dataGridView1_Munkaido.Size = new System.Drawing.Size(659, 233);
            this.dataGridView1_Munkaido.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Összes túlóra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Túlóra kifizetés (Ft):";
            // 
            // textBox1_Osszestul
            // 
            this.textBox1_Osszestul.Location = new System.Drawing.Point(481, 359);
            this.textBox1_Osszestul.Name = "textBox1_Osszestul";
            this.textBox1_Osszestul.Size = new System.Drawing.Size(200, 22);
            this.textBox1_Osszestul.TabIndex = 4;
            // 
            // textBox2_Fizetes
            // 
            this.textBox2_Fizetes.Location = new System.Drawing.Point(481, 399);
            this.textBox2_Fizetes.Name = "textBox2_Fizetes";
            this.textBox2_Fizetes.Size = new System.Drawing.Size(200, 22);
            this.textBox2_Fizetes.TabIndex = 5;
            // 
            // Form_Munkaido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2_Fizetes);
            this.Controls.Add(this.textBox1_Osszestul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1_Munkaido);
            this.Controls.Add(this.label1);
            this.Name = "Form_Munkaido";
            this.Text = "Munkaidő";
            this.Load += new System.EventHandler(this.Form_Munkaido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Munkaido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1_Munkaido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_Osszestul;
        private System.Windows.Forms.TextBox textBox2_Fizetes;
    }
}