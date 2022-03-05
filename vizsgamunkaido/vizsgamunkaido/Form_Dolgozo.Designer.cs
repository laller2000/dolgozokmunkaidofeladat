
namespace vizsgamunkaido
{
    partial class Form_Dolgozo
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
            this.dataGridView1_Dolgozok = new System.Windows.Forms.DataGridView();
            this.button1_UJdolgozo = new System.Windows.Forms.Button();
            this.button2_Adatokfrissites = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Dolgozok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Munkaidő nyilvántartó program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "A nyilvántartásban szereplő dolgozó adatai:";
            // 
            // dataGridView1_Dolgozok
            // 
            this.dataGridView1_Dolgozok.AllowUserToAddRows = false;
            this.dataGridView1_Dolgozok.AllowUserToDeleteRows = false;
            this.dataGridView1_Dolgozok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Dolgozok.Location = new System.Drawing.Point(36, 149);
            this.dataGridView1_Dolgozok.Name = "dataGridView1_Dolgozok";
            this.dataGridView1_Dolgozok.ReadOnly = true;
            this.dataGridView1_Dolgozok.RowHeadersWidth = 51;
            this.dataGridView1_Dolgozok.RowTemplate.Height = 24;
            this.dataGridView1_Dolgozok.Size = new System.Drawing.Size(734, 244);
            this.dataGridView1_Dolgozok.TabIndex = 2;
            this.dataGridView1_Dolgozok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Dolgozok_CellContentClick);
            // 
            // button1_UJdolgozo
            // 
            this.button1_UJdolgozo.Location = new System.Drawing.Point(36, 434);
            this.button1_UJdolgozo.Name = "button1_UJdolgozo";
            this.button1_UJdolgozo.Size = new System.Drawing.Size(310, 23);
            this.button1_UJdolgozo.TabIndex = 3;
            this.button1_UJdolgozo.Text = "Új dolgozó felvétele";
            this.button1_UJdolgozo.UseVisualStyleBackColor = true;
            this.button1_UJdolgozo.Click += new System.EventHandler(this.button1_UJdolgozo_Click);
            // 
            // button2_Adatokfrissites
            // 
            this.button2_Adatokfrissites.Location = new System.Drawing.Point(461, 433);
            this.button2_Adatokfrissites.Name = "button2_Adatokfrissites";
            this.button2_Adatokfrissites.Size = new System.Drawing.Size(309, 23);
            this.button2_Adatokfrissites.TabIndex = 4;
            this.button2_Adatokfrissites.Text = "Adatok frissítése";
            this.button2_Adatokfrissites.UseVisualStyleBackColor = true;
            this.button2_Adatokfrissites.Click += new System.EventHandler(this.button2_Adatokfrissites_Click);
            // 
            // Form_Dolgozo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.button2_Adatokfrissites);
            this.Controls.Add(this.button1_UJdolgozo);
            this.Controls.Add(this.dataGridView1_Dolgozok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Dolgozo";
            this.Text = "Dolgozó";
            this.Load += new System.EventHandler(this.Form_Dolgozo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Dolgozok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1_Dolgozok;
        private System.Windows.Forms.Button button1_UJdolgozo;
        private System.Windows.Forms.Button button2_Adatokfrissites;
    }
}

