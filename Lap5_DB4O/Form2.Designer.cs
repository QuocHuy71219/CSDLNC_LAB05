
namespace Lap5_DB4O
{
    partial class Form2
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DName = new System.Windows.Forms.TextBox();
            this.DNumber = new System.Windows.Forms.TextBox();
            this.Employees = new System.Windows.Forms.TextBox();
            this.Manager = new System.Windows.Forms.TextBox();
            this.MgrStartDate = new System.Windows.Forms.TextBox();
            this.Projects = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Locations = new System.Windows.Forms.TextBox();
            this.startT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 241);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(800, 212);
            this.dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "DName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNumber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Employees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Locations";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Manager";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "MgrStartDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Projects";
            // 
            // DName
            // 
            this.DName.Location = new System.Drawing.Point(84, 25);
            this.DName.Name = "DName";
            this.DName.Size = new System.Drawing.Size(168, 23);
            this.DName.TabIndex = 8;
            // 
            // DNumber
            // 
            this.DNumber.Location = new System.Drawing.Point(84, 64);
            this.DNumber.Name = "DNumber";
            this.DNumber.Size = new System.Drawing.Size(168, 23);
            this.DNumber.TabIndex = 9;
            // 
            // Employees
            // 
            this.Employees.Location = new System.Drawing.Point(84, 100);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(168, 23);
            this.Employees.TabIndex = 10;
            // 
            // Manager
            // 
            this.Manager.Location = new System.Drawing.Point(360, 61);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(168, 23);
            this.Manager.TabIndex = 12;
            // 
            // MgrStartDate
            // 
            this.MgrStartDate.Location = new System.Drawing.Point(360, 97);
            this.MgrStartDate.Name = "MgrStartDate";
            this.MgrStartDate.Size = new System.Drawing.Size(168, 23);
            this.MgrStartDate.TabIndex = 13;
            // 
            // Projects
            // 
            this.Projects.Location = new System.Drawing.Point(620, 22);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(168, 23);
            this.Projects.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(176, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Locations
            // 
            this.Locations.Location = new System.Drawing.Point(360, 22);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(168, 23);
            this.Locations.TabIndex = 17;
            // 
            // startT
            // 
            this.startT.Location = new System.Drawing.Point(284, 170);
            this.startT.Name = "startT";
            this.startT.Size = new System.Drawing.Size(75, 23);
            this.startT.TabIndex = 18;
            this.startT.Text = "query2";
            this.startT.UseVisualStyleBackColor = true;
            this.startT.Click += new System.EventHandler(this.startT_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.startT);
            this.Controls.Add(this.Locations);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Projects);
            this.Controls.Add(this.MgrStartDate);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.Employees);
            this.Controls.Add(this.DNumber);
            this.Controls.Add(this.DName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DName;
        private System.Windows.Forms.TextBox DNumber;
        private System.Windows.Forms.TextBox Employees;
        private System.Windows.Forms.TextBox Manager;
        private System.Windows.Forms.TextBox MgrStartDate;
        private System.Windows.Forms.TextBox Projects;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox Locations;
        private System.Windows.Forms.Button startT;
    }
}