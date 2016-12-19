namespace SqlProject
{
    partial class DeleteDriver
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
            this.DriverIdLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.comboBoxDriverId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DriverIdLabel
            // 
            this.DriverIdLabel.AutoSize = true;
            this.DriverIdLabel.Location = new System.Drawing.Point(24, 35);
            this.DriverIdLabel.Name = "DriverIdLabel";
            this.DriverIdLabel.Size = new System.Drawing.Size(50, 13);
            this.DriverIdLabel.TabIndex = 0;
            this.DriverIdLabel.Text = "Driver Id:";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 86);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(79, 33);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(149, 86);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(79, 33);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // comboBoxDriverId
            // 
            this.comboBoxDriverId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDriverId.FormattingEnabled = true;
            this.comboBoxDriverId.Location = new System.Drawing.Point(107, 32);
            this.comboBoxDriverId.Name = "comboBoxDriverId";
            this.comboBoxDriverId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDriverId.TabIndex = 4;
            // 
            // DeleteDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 131);
            this.Controls.Add(this.comboBoxDriverId);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DriverIdLabel);
            this.Name = "DeleteDriver";
            this.Text = "DeleteDriver";
            this.Load += new System.EventHandler(this.DeleteDriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DriverIdLabel;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox comboBoxDriverId;
    }
}