namespace ImportData
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblCsv = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtcsv = new System.Windows.Forms.TextBox();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ImportData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(32, 37);
            this.lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(39, 17);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input";
            // 
            // lblCsv
            // 
            this.lblCsv.AutoSize = true;
            this.lblCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCsv.Location = new System.Drawing.Point(32, 91);
            this.lblCsv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCsv.Name = "lblCsv";
            this.lblCsv.Size = new System.Drawing.Size(66, 17);
            this.lblCsv.TabIndex = 1;
            this.lblCsv.Text = "Input Csv";
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(32, 150);
            this.lblReports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(58, 17);
            this.lblReports.TabIndex = 2;
            this.lblReports.Text = "Reports";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(220, 27);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(468, 23);
            this.txtInput.TabIndex = 3;
            // 
            // txtcsv
            // 
            this.txtcsv.Location = new System.Drawing.Point(220, 82);
            this.txtcsv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcsv.Name = "txtcsv";
            this.txtcsv.Size = new System.Drawing.Size(468, 23);
            this.txtcsv.TabIndex = 4;
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(220, 142);
            this.txtReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(468, 23);
            this.txtReport.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "---";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 79);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "---";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(715, 138);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "---";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ImportData
            // 
            this.ImportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportData.Location = new System.Drawing.Point(115, 214);
            this.ImportData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ImportData.Name = "ImportData";
            this.ImportData.Size = new System.Drawing.Size(171, 28);
            this.ImportData.TabIndex = 9;
            this.ImportData.Text = "Import Data";
            this.ImportData.UseVisualStyleBackColor = true;
            this.ImportData.Click += new System.EventHandler(this.ImportData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 362);
            this.Controls.Add(this.ImportData);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.txtcsv);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.lblCsv);
            this.Controls.Add(this.lblInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblCsv;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtcsv;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ImportData;
    }
}

