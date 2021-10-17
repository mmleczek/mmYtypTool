
namespace OpenYtyp
{
    partial class JenkinsHashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JenkinsHashForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textToHashOutTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textToHashTb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hashToTextOutTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hashToTextTb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textToHashOutTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textToHashTb);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text to hash";
            // 
            // textToHashOutTb
            // 
            this.textToHashOutTb.Location = new System.Drawing.Point(49, 45);
            this.textToHashOutTb.Name = "textToHashOutTb";
            this.textToHashOutTb.ReadOnly = true;
            this.textToHashOutTb.Size = new System.Drawing.Size(198, 20);
            this.textToHashOutTb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input:";
            // 
            // textToHashTb
            // 
            this.textToHashTb.Location = new System.Drawing.Point(49, 19);
            this.textToHashTb.Name = "textToHashTb";
            this.textToHashTb.Size = new System.Drawing.Size(198, 20);
            this.textToHashTb.TabIndex = 1;
            this.textToHashTb.TextChanged += new System.EventHandler(this.textToHashTb_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hashToTextOutTb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.hashToTextTb);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 71);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hash to text";
            // 
            // hashToTextOutTb
            // 
            this.hashToTextOutTb.Location = new System.Drawing.Point(49, 45);
            this.hashToTextOutTb.Name = "hashToTextOutTb";
            this.hashToTextOutTb.ReadOnly = true;
            this.hashToTextOutTb.Size = new System.Drawing.Size(198, 20);
            this.hashToTextOutTb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Input:";
            // 
            // hashToTextTb
            // 
            this.hashToTextTb.Location = new System.Drawing.Point(49, 19);
            this.hashToTextTb.Name = "hashToTextTb";
            this.hashToTextTb.Size = new System.Drawing.Size(198, 20);
            this.hashToTextTb.TabIndex = 1;
            this.hashToTextTb.TextChanged += new System.EventHandler(this.hashToTextTb_TextChanged);
            // 
            // JenkinsHashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 170);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JenkinsHashForm";
            this.ShowIcon = false;
            this.Text = "JenkinsHash";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textToHashOutTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textToHashTb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox hashToTextOutTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hashToTextTb;
    }
}