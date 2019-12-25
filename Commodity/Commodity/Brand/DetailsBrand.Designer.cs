namespace Commodity.Brand
{
    partial class DetailsBrand
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
            this.bpicture = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bwebsite = new System.Windows.Forms.TextBox();
            this.bname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bpicture
            // 
            this.bpicture.Enabled = false;
            this.bpicture.Location = new System.Drawing.Point(168, 101);
            this.bpicture.Margin = new System.Windows.Forms.Padding(4);
            this.bpicture.Name = "bpicture";
            this.bpicture.Size = new System.Drawing.Size(132, 25);
            this.bpicture.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "品牌网址：";
            // 
            // bwebsite
            // 
            this.bwebsite.Enabled = false;
            this.bwebsite.Location = new System.Drawing.Point(168, 169);
            this.bwebsite.Margin = new System.Windows.Forms.Padding(4);
            this.bwebsite.Name = "bwebsite";
            this.bwebsite.Size = new System.Drawing.Size(132, 25);
            this.bwebsite.TabIndex = 54;
            // 
            // bname
            // 
            this.bname.Enabled = false;
            this.bname.Location = new System.Drawing.Point(168, 39);
            this.bname.Margin = new System.Windows.Forms.Padding(4);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(132, 25);
            this.bname.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "品牌图片：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "品牌名称：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 57;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetailsBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bpicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bwebsite);
            this.Controls.Add(this.bname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailsBrand";
            this.Text = "DetailsBrand";
            this.Load += new System.EventHandler(this.DetailsBrand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bpicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bwebsite;
        private System.Windows.Forms.TextBox bname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}