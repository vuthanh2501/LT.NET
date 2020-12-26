namespace Calendar
{
    partial class AJob
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nmToHours = new System.Windows.Forms.NumericUpDown();
            this.nmToMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nmToMinutes2 = new System.Windows.Forms.NumericUpDown();
            this.nmToHours2 = new System.Windows.Forms.NumericUpDown();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinutes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.nmToHours);
            this.panel1.Controls.Add(this.statusBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nmToMinutes2);
            this.panel1.Controls.Add(this.nmToMinutes);
            this.panel1.Controls.Add(this.nmToHours2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 27);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 22);
            this.textBox1.TabIndex = 1;
            // 
            // nmToHours
            // 
            this.nmToHours.Location = new System.Drawing.Point(304, 3);
            this.nmToHours.Name = "nmToHours";
            this.nmToHours.Size = new System.Drawing.Size(36, 22);
            this.nmToHours.TabIndex = 0;
            this.nmToHours.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nmToMinutes
            // 
            this.nmToMinutes.Location = new System.Drawing.Point(346, 3);
            this.nmToMinutes.Name = "nmToMinutes";
            this.nmToMinutes.Size = new System.Drawing.Size(43, 22);
            this.nmToMinutes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "đến";
            // 
            // nmToMinutes2
            // 
            this.nmToMinutes2.Location = new System.Drawing.Point(476, 2);
            this.nmToMinutes2.Name = "nmToMinutes2";
            this.nmToMinutes2.Size = new System.Drawing.Size(44, 22);
            this.nmToMinutes2.TabIndex = 4;
            // 
            // nmToHours2
            // 
            this.nmToHours2.Location = new System.Drawing.Point(433, 2);
            this.nmToHours2.Name = "nmToHours2";
            this.nmToHours2.Size = new System.Drawing.Size(37, 22);
            this.nmToHours2.TabIndex = 3;
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Location = new System.Drawing.Point(526, 3);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(111, 24);
            this.statusBox.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(643, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(724, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // AJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AJob";
            this.Size = new System.Drawing.Size(810, 36);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinutes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nmToMinutes;
        private System.Windows.Forms.NumericUpDown nmToHours;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.NumericUpDown nmToMinutes2;
        private System.Windows.Forms.NumericUpDown nmToHours2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}
