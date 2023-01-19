namespace TestProject
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
            this.awesomeIcon1 = new FontAwesomeCsharp.AwesomeIcon();
            this.SuspendLayout();
            // 
            // awesomeIcon1
            // 
            this.awesomeIcon1.Font = new System.Drawing.Font("Font Awesome 6 Pro Regular", 30F);
            this.awesomeIcon1.IconAutoSize = true;
            this.awesomeIcon1.IconFont = FontAwesomeCsharp.AwesomeIcon.FontIconTypes.Brands;
            this.awesomeIcon1.IconSize = 159.8313F;
            this.awesomeIcon1.Location = new System.Drawing.Point(12, 12);
            this.awesomeIcon1.Name = "awesomeIcon1";
            this.awesomeIcon1.Size = new System.Drawing.Size(349, 309);
            this.awesomeIcon1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 333);
            this.Controls.Add(this.awesomeIcon1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesomeCsharp.AwesomeIcon awesomeIcon1;
    }
}

