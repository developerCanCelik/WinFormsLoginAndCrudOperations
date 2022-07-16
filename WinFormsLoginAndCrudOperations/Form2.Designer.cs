
namespace WinFormsLoginAndCrudOperations
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
            this.lbl_kname = new System.Windows.Forms.Label();
            this.data_grid_view = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_urun = new System.Windows.Forms.TextBox();
            this.txt_stok = new System.Windows.Forms.TextBox();
            this.txt_kategori = new System.Windows.Forms.TextBox();
            this.lbl_urun = new System.Windows.Forms.Label();
            this.lbl_stok = new System.Windows.Forms.Label();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_kname
            // 
            this.lbl_kname.AutoSize = true;
            this.lbl_kname.Location = new System.Drawing.Point(389, 28);
            this.lbl_kname.Name = "lbl_kname";
            this.lbl_kname.Size = new System.Drawing.Size(50, 20);
            this.lbl_kname.TabIndex = 0;
            this.lbl_kname.Text = "label1";
            // 
            // data_grid_view
            // 
            this.data_grid_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view.Location = new System.Drawing.Point(24, 66);
            this.data_grid_view.Name = "data_grid_view";
            this.data_grid_view.RowHeadersWidth = 51;
            this.data_grid_view.RowTemplate.Height = 29;
            this.data_grid_view.Size = new System.Drawing.Size(748, 231);
            this.data_grid_view.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(235, 376);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "EKLE";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(357, 376);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 29);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "SİL";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(486, 376);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 29);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "SEÇ";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_urun
            // 
            this.txt_urun.Location = new System.Drawing.Point(100, 319);
            this.txt_urun.Name = "txt_urun";
            this.txt_urun.Size = new System.Drawing.Size(125, 27);
            this.txt_urun.TabIndex = 5;
            // 
            // txt_stok
            // 
            this.txt_stok.Location = new System.Drawing.Point(368, 319);
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Size = new System.Drawing.Size(125, 27);
            this.txt_stok.TabIndex = 6;
            // 
            // txt_kategori
            // 
            this.txt_kategori.Location = new System.Drawing.Point(631, 319);
            this.txt_kategori.Name = "txt_kategori";
            this.txt_kategori.Size = new System.Drawing.Size(125, 27);
            this.txt_kategori.TabIndex = 7;
            // 
            // lbl_urun
            // 
            this.lbl_urun.AutoSize = true;
            this.lbl_urun.Location = new System.Drawing.Point(24, 322);
            this.lbl_urun.Name = "lbl_urun";
            this.lbl_urun.Size = new System.Drawing.Size(70, 20);
            this.lbl_urun.TabIndex = 8;
            this.lbl_urun.Text = "Ürün Adı:";
            // 
            // lbl_stok
            // 
            this.lbl_stok.AutoSize = true;
            this.lbl_stok.Location = new System.Drawing.Point(271, 322);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(91, 20);
            this.lbl_stok.TabIndex = 9;
            this.lbl_stok.Text = "Stok Miktarı:";
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Location = new System.Drawing.Point(525, 322);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(100, 20);
            this.lbl_kategori.TabIndex = 10;
            this.lbl_kategori.Text = "Categori İsmi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hoşgeldiniz:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_kategori);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.lbl_urun);
            this.Controls.Add(this.txt_kategori);
            this.Controls.Add(this.txt_stok);
            this.Controls.Add(this.txt_urun);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.data_grid_view);
            this.Controls.Add(this.lbl_kname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kname;
        private System.Windows.Forms.DataGridView data_grid_view;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_urun;
        private System.Windows.Forms.TextBox txt_stok;
        private System.Windows.Forms.TextBox txt_kategori;
        private System.Windows.Forms.Label lbl_urun;
        private System.Windows.Forms.Label lbl_stok;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.Label label1;
    }
}