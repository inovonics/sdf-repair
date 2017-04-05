namespace sdf_repair
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
            this.FilePathOpenDialogButton = new System.Windows.Forms.Button();
            this.FilePathField = new System.Windows.Forms.TextBox();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.StartRepairButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilePathOpenDialogButton
            // 
            this.FilePathOpenDialogButton.Location = new System.Drawing.Point(370, 51);
            this.FilePathOpenDialogButton.Name = "FilePathOpenDialogButton";
            this.FilePathOpenDialogButton.Size = new System.Drawing.Size(75, 23);
            this.FilePathOpenDialogButton.TabIndex = 0;
            this.FilePathOpenDialogButton.Text = "Browse";
            this.FilePathOpenDialogButton.UseVisualStyleBackColor = true;
            this.FilePathOpenDialogButton.Click += new System.EventHandler(this.FilePathOpenDialogButton_Click);
            // 
            // FilePathField
            // 
            this.FilePathField.Location = new System.Drawing.Point(12, 54);
            this.FilePathField.Name = "FilePathField";
            this.FilePathField.Size = new System.Drawing.Size(352, 20);
            this.FilePathField.TabIndex = 1;
            this.FilePathField.Text = "C:\\ProgramData\\Inovonics\\TapWatch3\\TapWatch.sdf";
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(13, 35);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(68, 13);
            this.FilePathLabel.TabIndex = 2;
            this.FilePathLabel.Text = "Path to SDF:";
            // 
            // StartRepairButton
            // 
            this.StartRepairButton.Location = new System.Drawing.Point(386, 3);
            this.StartRepairButton.Name = "StartRepairButton";
            this.StartRepairButton.Size = new System.Drawing.Size(75, 23);
            this.StartRepairButton.TabIndex = 3;
            this.StartRepairButton.Text = "Repair";
            this.StartRepairButton.UseVisualStyleBackColor = true;
            this.StartRepairButton.Click += new System.EventHandler(this.StartRepairButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.StartRepairButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 109);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(464, 28);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 81);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 137);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.FilePathField);
            this.Controls.Add(this.FilePathOpenDialogButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FilePathOpenDialogButton;
        private System.Windows.Forms.TextBox FilePathField;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.Button StartRepairButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label ResultLabel;
    }
}

