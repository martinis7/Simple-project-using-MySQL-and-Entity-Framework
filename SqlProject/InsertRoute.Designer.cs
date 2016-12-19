namespace SqlProject
{
    partial class InsertRoute
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
            this.lblRouteId = new System.Windows.Forms.Label();
            this.txtRouteId = new System.Windows.Forms.TextBox();
            this.lblRouteStart = new System.Windows.Forms.Label();
            this.lblRouteEnd = new System.Windows.Forms.Label();
            this.comboBoxStartStop = new System.Windows.Forms.ComboBox();
            this.comboBoxEndStop = new System.Windows.Forms.ComboBox();
            this.checkedListBoxStops = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxBuses = new System.Windows.Forms.CheckedListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRouteId
            // 
            this.lblRouteId.AutoSize = true;
            this.lblRouteId.Location = new System.Drawing.Point(12, 25);
            this.lblRouteId.Name = "lblRouteId";
            this.lblRouteId.Size = new System.Drawing.Size(51, 13);
            this.lblRouteId.TabIndex = 0;
            this.lblRouteId.Text = "Route Id:";
            // 
            // txtRouteId
            // 
            this.txtRouteId.Location = new System.Drawing.Point(116, 22);
            this.txtRouteId.Name = "txtRouteId";
            this.txtRouteId.Size = new System.Drawing.Size(100, 20);
            this.txtRouteId.TabIndex = 1;
            // 
            // lblRouteStart
            // 
            this.lblRouteStart.AutoSize = true;
            this.lblRouteStart.Location = new System.Drawing.Point(12, 90);
            this.lblRouteStart.Name = "lblRouteStart";
            this.lblRouteStart.Size = new System.Drawing.Size(82, 13);
            this.lblRouteStart.TabIndex = 2;
            this.lblRouteStart.Text = "Beginning Stop:";
            // 
            // lblRouteEnd
            // 
            this.lblRouteEnd.AutoSize = true;
            this.lblRouteEnd.Location = new System.Drawing.Point(12, 158);
            this.lblRouteEnd.Name = "lblRouteEnd";
            this.lblRouteEnd.Size = new System.Drawing.Size(54, 13);
            this.lblRouteEnd.TabIndex = 3;
            this.lblRouteEnd.Text = "End Stop:";
            // 
            // comboBoxStartStop
            // 
            this.comboBoxStartStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartStop.FormattingEnabled = true;
            this.comboBoxStartStop.Location = new System.Drawing.Point(116, 87);
            this.comboBoxStartStop.Name = "comboBoxStartStop";
            this.comboBoxStartStop.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStartStop.TabIndex = 4;
            // 
            // comboBoxEndStop
            // 
            this.comboBoxEndStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEndStop.FormattingEnabled = true;
            this.comboBoxEndStop.Location = new System.Drawing.Point(116, 155);
            this.comboBoxEndStop.Name = "comboBoxEndStop";
            this.comboBoxEndStop.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEndStop.TabIndex = 5;
            // 
            // checkedListBoxStops
            // 
            this.checkedListBoxStops.CheckOnClick = true;
            this.checkedListBoxStops.FormattingEnabled = true;
            this.checkedListBoxStops.Location = new System.Drawing.Point(265, 22);
            this.checkedListBoxStops.Name = "checkedListBoxStops";
            this.checkedListBoxStops.Size = new System.Drawing.Size(139, 154);
            this.checkedListBoxStops.TabIndex = 6;
            // 
            // checkedListBoxBuses
            // 
            this.checkedListBoxBuses.CheckOnClick = true;
            this.checkedListBoxBuses.FormattingEnabled = true;
            this.checkedListBoxBuses.Location = new System.Drawing.Point(447, 22);
            this.checkedListBoxBuses.Name = "checkedListBoxBuses";
            this.checkedListBoxBuses.Size = new System.Drawing.Size(139, 154);
            this.checkedListBoxBuses.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(507, 216);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(79, 33);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Routes Stops";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Buses";
            // 
            // InsertRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.checkedListBoxBuses);
            this.Controls.Add(this.checkedListBoxStops);
            this.Controls.Add(this.comboBoxEndStop);
            this.Controls.Add(this.comboBoxStartStop);
            this.Controls.Add(this.lblRouteEnd);
            this.Controls.Add(this.lblRouteStart);
            this.Controls.Add(this.txtRouteId);
            this.Controls.Add(this.lblRouteId);
            this.Name = "InsertRoute";
            this.Text = "InsertRoute";
            this.Load += new System.EventHandler(this.InsertRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRouteId;
        private System.Windows.Forms.TextBox txtRouteId;
        private System.Windows.Forms.Label lblRouteStart;
        private System.Windows.Forms.Label lblRouteEnd;
        private System.Windows.Forms.ComboBox comboBoxStartStop;
        private System.Windows.Forms.ComboBox comboBoxEndStop;
        private System.Windows.Forms.CheckedListBox checkedListBoxStops;
        private System.Windows.Forms.CheckedListBox checkedListBoxBuses;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}