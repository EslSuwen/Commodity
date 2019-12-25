namespace Commodity.Supplier
{
    partial class DetailsSupplier
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
            this.sname = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contacts = new System.Windows.Forms.TextBox();
            this.synopsis = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 68;
            this.label1.Text = "供货商名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 69;
            this.label2.Text = "联系电话:";
            // 
            // sname
            // 
            this.sname.Enabled = false;
            this.sname.Location = new System.Drawing.Point(180, 44);
            this.sname.Margin = new System.Windows.Forms.Padding(4);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(132, 25);
            this.sname.TabIndex = 70;
            // 
            // phone
            // 
            this.phone.Enabled = false;
            this.phone.Location = new System.Drawing.Point(180, 152);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(132, 25);
            this.phone.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 72;
            this.label5.Text = "联系人：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 73;
            this.label6.Text = "供货商简介：";
            // 
            // contacts
            // 
            this.contacts.Enabled = false;
            this.contacts.Location = new System.Drawing.Point(180, 98);
            this.contacts.Margin = new System.Windows.Forms.Padding(4);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(132, 25);
            this.contacts.TabIndex = 74;
            // 
            // synopsis
            // 
            this.synopsis.Enabled = false;
            this.synopsis.Location = new System.Drawing.Point(180, 206);
            this.synopsis.Margin = new System.Windows.Forms.Padding(4);
            this.synopsis.Name = "synopsis";
            this.synopsis.Size = new System.Drawing.Size(132, 25);
            this.synopsis.TabIndex = 75;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 76;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DetailsSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.synopsis);
            this.Controls.Add(this.contacts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailsSupplier";
            this.Text = "DetailsSupplier";
            this.Load += new System.EventHandler(this.DetailsSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contacts;
        private System.Windows.Forms.TextBox synopsis;
        private System.Windows.Forms.Button button1;
    }
}