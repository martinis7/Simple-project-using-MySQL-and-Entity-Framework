namespace SqlProject
{
    partial class SqlManager
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.TablesList = new System.Windows.Forms.ComboBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.RoutesAndBussesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(732, 220);
            this.dataGridView.TabIndex = 0;
            // 
            // TablesList
            // 
            this.TablesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TablesList.Location = new System.Drawing.Point(12, 12);
            this.TablesList.Name = "TablesList";
            this.TablesList.Size = new System.Drawing.Size(121, 21);
            this.TablesList.TabIndex = 2;
            this.TablesList.SelectedIndexChanged += new System.EventHandler(this.TablesList_SelectedIndexChanged);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(139, 10);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(84, 23);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Insert Driver";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(229, 10);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(90, 23);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update Driver";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(325, 10);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(79, 23);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete Driver";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RoutesAndBussesButton
            // 
            this.RoutesAndBussesButton.Location = new System.Drawing.Point(623, 10);
            this.RoutesAndBussesButton.Name = "RoutesAndBussesButton";
            this.RoutesAndBussesButton.Size = new System.Drawing.Size(121, 23);
            this.RoutesAndBussesButton.TabIndex = 6;
            this.RoutesAndBussesButton.Text = "Routes and buses";
            this.RoutesAndBussesButton.UseVisualStyleBackColor = true;
            this.RoutesAndBussesButton.Click += new System.EventHandler(this.RoutesAndBussesButton_Click);
            // 
            // SqlManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 281);
            this.Controls.Add(this.RoutesAndBussesButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.TablesList);
            this.Controls.Add(this.dataGridView);
            this.Name = "SqlManager";
            this.Text = "Bus SQL Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox TablesList;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button RoutesAndBussesButton;
    }
}

