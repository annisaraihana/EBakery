namespace EBakery
{
    partial class InputMenuForm
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
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.btnAksi = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga:";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(138, 32);
            this.tbNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(294, 26);
            this.tbNama.TabIndex = 4;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(138, 134);
            this.tbStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(294, 26);
            this.tbStock.TabIndex = 6;
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(138, 83);
            this.tbHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(294, 26);
            this.tbHarga.TabIndex = 7;
            // 
            // btnAksi
            // 
            this.btnAksi.Location = new System.Drawing.Point(138, 196);
            this.btnAksi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAksi.Name = "btnAksi";
            this.btnAksi.Size = new System.Drawing.Size(142, 38);
            this.btnAksi.TabIndex = 8;
            this.btnAksi.Text = "Tambah";
            this.btnAksi.UseVisualStyleBackColor = true;
            this.btnAksi.Click += new System.EventHandler(this.btnAksi_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(290, 196);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(142, 38);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // InputMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 261);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnAksi);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InputMenuForm";
            this.Text = "Input Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Button btnAksi;
        private System.Windows.Forms.Button btnBatal;
    }
}
