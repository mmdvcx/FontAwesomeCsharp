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
            this.awesomeIcon1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.awesomeIcon1.FlatAppearance.BorderSize = 0;
            this.awesomeIcon1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.awesomeIcon1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.awesomeIcon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.awesomeIcon1.Font = new System.Drawing.Font("Font Awesome 6 Pro Regular", 132.4171F);
            this.awesomeIcon1.FontType = FontAwesomeCsharp.AwesomeIcon.FontIconTypes.Regular;
            this.awesomeIcon1.IconAutoSize = true;
            this.awesomeIcon1.IconSize = 132.4171F;
            this.awesomeIcon1.Location = new System.Drawing.Point(0, 0);
            this.awesomeIcon1.Name = "awesomeIcon1";
            this.awesomeIcon1.Size = new System.Drawing.Size(373, 333);
            this.awesomeIcon1.TabIndex = 0;
            this.awesomeIcon1.Text = "";
            this.awesomeIcon1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 333);
            this.Controls.Add(this.awesomeIcon1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesomeCsharp.AwesomeIcon awesomeIcon1;
    }
}

