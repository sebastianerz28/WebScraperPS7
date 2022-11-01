namespace Web_Scraper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchButton = new System.Windows.Forms.Button();
            this.SemesterDropdown = new System.Windows.Forms.ComboBox();
            this.SemesterLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CourseTextbox = new System.Windows.Forms.TextBox();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(109, 110);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SemesterDropdown
            // 
            this.SemesterDropdown.FormattingEnabled = true;
            this.SemesterDropdown.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Fall"});
            this.SemesterDropdown.Location = new System.Drawing.Point(109, 66);
            this.SemesterDropdown.Name = "SemesterDropdown";
            this.SemesterDropdown.Size = new System.Drawing.Size(121, 23);
            this.SemesterDropdown.TabIndex = 1;
            this.SemesterDropdown.Text = "Spring";
            // 
            // SemesterLabel
            // 
            this.SemesterLabel.AutoSize = true;
            this.SemesterLabel.Location = new System.Drawing.Point(109, 48);
            this.SemesterLabel.Name = "SemesterLabel";
            this.SemesterLabel.Size = new System.Drawing.Size(98, 15);
            this.SemesterLabel.TabIndex = 2;
            this.SemesterLabel.Text = "Choose Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Year";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023"});
            this.comboBox1.Location = new System.Drawing.Point(236, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "2022-2023";
            // 
            // CourseTextbox
            // 
            this.CourseTextbox.Location = new System.Drawing.Point(380, 66);
            this.CourseTextbox.Name = "CourseTextbox";
            this.CourseTextbox.Size = new System.Drawing.Size(209, 23);
            this.CourseTextbox.TabIndex = 5;
            this.CourseTextbox.Text = "CS 2420";
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Location = new System.Drawing.Point(380, 48);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(74, 15);
            this.CourseLabel.TabIndex = 6;
            this.CourseLabel.Text = "Enter Course";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.CourseTextbox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SemesterLabel);
            this.Controls.Add(this.SemesterDropdown);
            this.Controls.Add(this.SearchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SearchButton;
        private ComboBox SemesterDropdown;
        private Label SemesterLabel;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox CourseTextbox;
        private Label CourseLabel;
    }
}