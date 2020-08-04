namespace ResourcesFolderTest
{
    partial class Form1
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
            this.OpenPDFBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenPDFBtn
            // 
            this.OpenPDFBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenPDFBtn.Location = new System.Drawing.Point(314, 185);
            this.OpenPDFBtn.Name = "OpenPDFBtn";
            this.OpenPDFBtn.Size = new System.Drawing.Size(150, 75);
            this.OpenPDFBtn.TabIndex = 0;
            this.OpenPDFBtn.Text = "Open PDF";
            this.OpenPDFBtn.UseVisualStyleBackColor = true;
            this.OpenPDFBtn.Click += new System.EventHandler(this.OpenPDFBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenPDFBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenPDFBtn;
    }
}

