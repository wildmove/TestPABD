namespace TestPABD
{
    partial class Form2
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
            this.DataBuku = new System.Windows.Forms.Label();
            this.IdBuku = new System.Windows.Forms.Label();
            this.JudulBuku = new System.Windows.Forms.Label();
            this.Penulis = new System.Windows.Forms.Label();
            this.Penerbit = new System.Windows.Forms.Label();
            this.TahunTerbit = new System.Windows.Forms.Label();
            this.Harga = new System.Windows.Forms.Label();
            this.JumlahStok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DataBuku
            // 
            this.DataBuku.AutoSize = true;
            this.DataBuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBuku.Location = new System.Drawing.Point(282, 25);
            this.DataBuku.Name = "DataBuku";
            this.DataBuku.Size = new System.Drawing.Size(206, 46);
            this.DataBuku.TabIndex = 0;
            this.DataBuku.Text = "Data Buku";
            // 
            // IdBuku
            // 
            this.IdBuku.AutoSize = true;
            this.IdBuku.Location = new System.Drawing.Point(34, 167);
            this.IdBuku.Name = "IdBuku";
            this.IdBuku.Size = new System.Drawing.Size(51, 16);
            this.IdBuku.TabIndex = 1;
            this.IdBuku.Text = "Id Buku";
            // 
            // JudulBuku
            // 
            this.JudulBuku.AutoSize = true;
            this.JudulBuku.Location = new System.Drawing.Point(34, 201);
            this.JudulBuku.Name = "JudulBuku";
            this.JudulBuku.Size = new System.Drawing.Size(72, 16);
            this.JudulBuku.TabIndex = 2;
            this.JudulBuku.Text = "Judul Buku";
            // 
            // Penulis
            // 
            this.Penulis.AutoSize = true;
            this.Penulis.Location = new System.Drawing.Point(34, 240);
            this.Penulis.Name = "Penulis";
            this.Penulis.Size = new System.Drawing.Size(51, 16);
            this.Penulis.TabIndex = 3;
            this.Penulis.Text = "Penulis";
            // 
            // Penerbit
            // 
            this.Penerbit.AutoSize = true;
            this.Penerbit.Location = new System.Drawing.Point(34, 277);
            this.Penerbit.Name = "Penerbit";
            this.Penerbit.Size = new System.Drawing.Size(57, 16);
            this.Penerbit.TabIndex = 4;
            this.Penerbit.Text = "Penerbit";
            // 
            // TahunTerbit
            // 
            this.button1.Location = new System.Drawing.Point(419, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JumlahStok);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.TahunTerbit);
            this.Controls.Add(this.Penerbit);
            this.Controls.Add(this.Penulis);
            this.Controls.Add(this.JudulBuku);
            this.Controls.Add(this.IdBuku);
            this.Controls.Add(this.DataBuku);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataBuku;
        private System.Windows.Forms.Label IdBuku;
        private System.Windows.Forms.Label JudulBuku;
        private System.Windows.Forms.Label Penulis;
        private System.Windows.Forms.Label Penerbit;
        private System.Windows.Forms.Label TahunTerbit;
        private System.Windows.Forms.Label Harga;
        private System.Windows.Forms.Label JumlahStok;
    }
}