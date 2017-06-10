namespace OyostateStudentsRecords
{
    partial class frmoption
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
            if(disposing && (components != null))
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnhealth = new System.Windows.Forms.RadioButton();
            this.rdbtnschoolinfor = new System.Windows.Forms.RadioButton();
            this.rdbtnparent = new System.Windows.Forms.RadioButton();
            this.rdbtnbasicdata = new System.Windows.Forms.RadioButton();
            this.btnenter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the part of records you want to update...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnhealth);
            this.groupBox1.Controls.Add(this.rdbtnschoolinfor);
            this.groupBox1.Controls.Add(this.rdbtnparent);
            this.groupBox1.Controls.Add(this.rdbtnbasicdata);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(38, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sections";
            // 
            // rdbtnhealth
            // 
            this.rdbtnhealth.AutoSize = true;
            this.rdbtnhealth.Location = new System.Drawing.Point(31, 174);
            this.rdbtnhealth.Name = "rdbtnhealth";
            this.rdbtnhealth.Size = new System.Drawing.Size(134, 20);
            this.rdbtnhealth.TabIndex = 3;
            this.rdbtnhealth.TabStop = true;
            this.rdbtnhealth.Text = "Health Records";
            this.rdbtnhealth.UseVisualStyleBackColor = true;
            // 
            // rdbtnschoolinfor
            // 
            this.rdbtnschoolinfor.AutoSize = true;
            this.rdbtnschoolinfor.Location = new System.Drawing.Point(31, 129);
            this.rdbtnschoolinfor.Name = "rdbtnschoolinfor";
            this.rdbtnschoolinfor.Size = new System.Drawing.Size(154, 20);
            this.rdbtnschoolinfor.TabIndex = 2;
            this.rdbtnschoolinfor.TabStop = true;
            this.rdbtnschoolinfor.Text = "School Information";
            this.rdbtnschoolinfor.UseVisualStyleBackColor = true;
            // 
            // rdbtnparent
            // 
            this.rdbtnparent.AutoSize = true;
            this.rdbtnparent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnparent.ForeColor = System.Drawing.Color.White;
            this.rdbtnparent.Location = new System.Drawing.Point(31, 91);
            this.rdbtnparent.Name = "rdbtnparent";
            this.rdbtnparent.Size = new System.Drawing.Size(129, 20);
            this.rdbtnparent.TabIndex = 2;
            this.rdbtnparent.TabStop = true;
            this.rdbtnparent.Text = "Parent/Guidian";
            this.rdbtnparent.UseVisualStyleBackColor = true;
            // 
            // rdbtnbasicdata
            // 
            this.rdbtnbasicdata.AutoSize = true;
            this.rdbtnbasicdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnbasicdata.ForeColor = System.Drawing.Color.White;
            this.rdbtnbasicdata.Location = new System.Drawing.Point(31, 47);
            this.rdbtnbasicdata.Name = "rdbtnbasicdata";
            this.rdbtnbasicdata.Size = new System.Drawing.Size(102, 20);
            this.rdbtnbasicdata.TabIndex = 0;
            this.rdbtnbasicdata.TabStop = true;
            this.rdbtnbasicdata.Text = "Basic Data";
            this.rdbtnbasicdata.UseVisualStyleBackColor = true;
            // 
            // btnenter
            // 
            this.btnenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenter.Location = new System.Drawing.Point(33, 7);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(75, 23);
            this.btnenter.TabIndex = 2;
            this.btnenter.Text = "Enter";
            this.btnenter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnenter);
            this.panel1.Location = new System.Drawing.Point(69, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 39);
            this.panel1.TabIndex = 3;
            // 
            // frmoption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(307, 323);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmoption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Option";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnhealth;
        private System.Windows.Forms.RadioButton rdbtnschoolinfor;
        private System.Windows.Forms.RadioButton rdbtnparent;
        private System.Windows.Forms.RadioButton rdbtnbasicdata;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Panel panel1;
    }
}