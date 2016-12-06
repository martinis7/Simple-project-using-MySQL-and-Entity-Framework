namespace SqlProject
{
    partial class UpdateDriver
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.DriverIdtxt = new System.Windows.Forms.TextBox();
            this.FirstNametxt = new System.Windows.Forms.TextBox();
            this.LastNametxt = new System.Windows.Forms.TextBox();
            this.PhoneNumbertxt = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DriverIdComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DriverIdLabel
            // 
            this.DriverIdLabel.AutoSize = true;
            this.DriverIdLabel.Location = new System.Drawing.Point(28, 61);
            this.DriverIdLabel.Name = "DriverIdLabel";
            this.DriverIdLabel.Size = new System.Drawing.Size(50, 13);
            this.DriverIdLabel.TabIndex = 0;
            this.DriverIdLabel.Text = "Driver Id:";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(28, 100);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLabel.TabIndex = 1;
            this.FirstNameLabel.Text = "First Name:";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(28, 139);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(28, 176);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.PhoneNumberLabel.TabIndex = 3;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // DriverIdtxt
            // 
            this.DriverIdtxt.Location = new System.Drawing.Point(126, 58);
            this.DriverIdtxt.Name = "DriverIdtxt";
            this.DriverIdtxt.Size = new System.Drawing.Size(100, 20);
            this.DriverIdtxt.TabIndex = 4;
            // 
            // FirstNametxt
            // 
            this.FirstNametxt.Location = new System.Drawing.Point(126, 97);
            this.FirstNametxt.Name = "FirstNametxt";
            this.FirstNametxt.Size = new System.Drawing.Size(100, 20);
            this.FirstNametxt.TabIndex = 5;
            // 
            // LastNametxt
            // 
            this.LastNametxt.Location = new System.Drawing.Point(126, 136);
            this.LastNametxt.Name = "LastNametxt";
            this.LastNametxt.Size = new System.Drawing.Size(100, 20);
            this.LastNametxt.TabIndex = 6;
            // 
            // PhoneNumbertxt
            // 
            this.PhoneNumbertxt.Location = new System.Drawing.Point(126, 173);
            this.PhoneNumbertxt.Name = "PhoneNumbertxt";
            this.PhoneNumbertxt.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumbertxt.TabIndex = 7;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(178, 223);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(79, 33);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 223);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(79, 33);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DriverIdComboBox
            // 
            this.DriverIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DriverIdComboBox.FormattingEnabled = true;
            this.DriverIdComboBox.Location = new System.Drawing.Point(74, 12);
            this.DriverIdComboBox.Name = "DriverIdComboBox";
            this.DriverIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.DriverIdComboBox.TabIndex = 10;
            this.DriverIdComboBox.SelectedIndexChanged += new System.EventHandler(this.DriverIdComboBox_SelectedIndexChanged);
            // 
            // UpdateDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 268);
            this.Controls.Add(this.DriverIdComboBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.PhoneNumbertxt);
            this.Controls.Add(this.LastNametxt);
            this.Controls.Add(this.FirstNametxt);
            this.Controls.Add(this.DriverIdtxt);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.DriverIdLabel);
            this.Name = "UpdateDriver";
            this.Text = "UpdateDriver";
            this.Load += new System.EventHandler(this.UpdateDriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DriverIdLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox DriverIdtxt;
        private System.Windows.Forms.TextBox FirstNametxt;
        private System.Windows.Forms.TextBox LastNametxt;
        private System.Windows.Forms.TextBox PhoneNumbertxt;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox DriverIdComboBox;
    }
}