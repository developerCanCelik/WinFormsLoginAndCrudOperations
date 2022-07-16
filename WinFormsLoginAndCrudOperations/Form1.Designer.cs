
namespace WinFormsLoginAndCrudOperations
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
            this.txt_kname = new System.Windows.Forms.TextBox();
            this.txt_kpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_kname
            // 
            this.txt_kname.Location = new System.Drawing.Point(169, 120);
            this.txt_kname.Name = "txt_kname";
            this.txt_kname.Size = new System.Drawing.Size(197, 27);
            this.txt_kname.TabIndex = 0;
            // 
            // txt_kpass
            // 
            this.txt_kpass.Location = new System.Drawing.Point(169, 175);
            this.txt_kpass.Name = "txt_kpass";
            this.txt_kpass.Size = new System.Drawing.Size(197, 27);
            this.txt_kpass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "KULLANICI ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞİFRE:";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(169, 229);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(94, 29);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "GİRİŞ";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(429, 385);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kpass);
            this.Controls.Add(this.txt_kname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kname;
        private System.Windows.Forms.TextBox txt_kpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_next;
    }
}

