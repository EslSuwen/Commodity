namespace Commodity.Type
{
    partial class DetailsType
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
            this.button1 = new System.Windows.Forms.Button();
            this.tpicture = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 63;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpicture
            // 
            this.tpicture.Enabled = false;
            this.tpicture.Location = new System.Drawing.Point(172, 126);
            this.tpicture.Margin = new System.Windows.Forms.Padding(4);
            this.tpicture.Name = "tpicture";
            this.tpicture.Size = new System.Drawing.Size(132, 25);
            this.tpicture.TabIndex = 62;
            // 
            // tname
            // 
            this.tname.Enabled = false;
            this.tname.Location = new System.Drawing.Point(173, 49);
            this.tname.Margin = new System.Windows.Forms.Padding(4);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(132, 25);
            this.tname.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "品牌图片：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 59;
            this.label1.Text = "品牌名称：";
            // 
            // DetailsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tpicture);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetailsType";
            this.Text = "DetailsType";
            this.Load += new System.EventHandler(this.DetailsType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tpicture;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}