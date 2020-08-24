namespace DiaryApp
{
    partial class UserDatePickerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textPanel = new System.Windows.Forms.Panel();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.textPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.textPanel, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(635, 184);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.rightButton);
            this.textPanel.Controls.Add(this.leftButton);
            this.textPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPanel.Location = new System.Drawing.Point(220, 3);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(194, 178);
            this.textPanel.TabIndex = 0;
            this.textPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.textPanel_Paint);
            // 
            // leftButton
            // 
            this.leftButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leftButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.leftButton.FlatAppearance.BorderSize = 0;
            this.leftButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.leftButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.leftButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftButton.ForeColor = System.Drawing.Color.White;
            this.leftButton.Location = new System.Drawing.Point(0, 80);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(20, 20);
            this.leftButton.TabIndex = 1;
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Paint += new System.Windows.Forms.PaintEventHandler(this.leftButton_Paint);
            // 
            // rightButton
            // 
            this.rightButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rightButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rightButton.FlatAppearance.BorderSize = 0;
            this.rightButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.rightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.rightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightButton.ForeColor = System.Drawing.Color.White;
            this.rightButton.Location = new System.Drawing.Point(174, 80);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(20, 20);
            this.rightButton.TabIndex = 2;
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Paint += new System.Windows.Forms.PaintEventHandler(this.rightButton_Paint);
            // 
            // UserDatePickerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UserDatePickerControl";
            this.Size = new System.Drawing.Size(635, 184);
            this.tableLayoutPanel.ResumeLayout(false);
            this.textPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
    }
}
