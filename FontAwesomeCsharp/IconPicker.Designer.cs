namespace FontAwesomeCsharp
{
    partial class IconPicker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.IconsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.ContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconsGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IconsGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 534);
            this.panel2.TabIndex = 9;
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Controls.Add(this.panel2);
            this.ContainerPanel.Controls.Add(this.panel1);
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(874, 587);
            this.ContainerPanel.TabIndex = 0;
            // 
            // IconsGridView
            // 
            this.IconsGridView.AllowUserToAddRows = false;
            this.IconsGridView.AllowUserToDeleteRows = false;
            this.IconsGridView.AllowUserToResizeColumns = false;
            this.IconsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IconsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.IconsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IconsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconsGridView.Location = new System.Drawing.Point(0, 0);
            this.IconsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IconsGridView.MultiSelect = false;
            this.IconsGridView.Name = "IconsGridView";
            this.IconsGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IconsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.IconsGridView.RowHeadersVisible = false;
            this.IconsGridView.RowHeadersWidth = 51;
            this.IconsGridView.RowTemplate.Height = 60;
            this.IconsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IconsGridView.ShowCellErrors = false;
            this.IconsGridView.ShowCellToolTips = false;
            this.IconsGridView.ShowEditingIcon = false;
            this.IconsGridView.ShowRowErrors = false;
            this.IconsGridView.Size = new System.Drawing.Size(874, 534);
            this.IconsGridView.TabIndex = 10;
            this.IconsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IconsGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search In Icons";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(143, 15);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(186, 27);
            this.SearchBox.TabIndex = 4;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 53);
            this.panel1.TabIndex = 8;
            // 
            // IconPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 587);
            this.Controls.Add(this.ContainerPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IconPicker";
            this.Text = "IconPicker";
            this.Load += new System.EventHandler(this.IconPicker_Load);
            this.panel2.ResumeLayout(false);
            this.ContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconsGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView IconsGridView;
        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
    }
}