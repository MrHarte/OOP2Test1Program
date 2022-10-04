namespace OOP2Test1Program
{
    partial class Test1Form
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
            this.Task1Label = new System.Windows.Forms.Label();
            this.Task2Label = new System.Windows.Forms.Label();
            this.Task3Label = new System.Windows.Forms.Label();
            this.Task4Label = new System.Windows.Forms.Label();
            this.Task5Label = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task1Label
            // 
            this.Task1Label.Location = new System.Drawing.Point(12, 9);
            this.Task1Label.Name = "Task1Label";
            this.Task1Label.Size = new System.Drawing.Size(150, 15);
            this.Task1Label.TabIndex = 0;
            this.Task1Label.Text = "Result Task 1: incomplete";
            // 
            // Task2Label
            // 
            this.Task2Label.Location = new System.Drawing.Point(12, 24);
            this.Task2Label.Name = "Task2Label";
            this.Task2Label.Size = new System.Drawing.Size(150, 15);
            this.Task2Label.TabIndex = 1;
            this.Task2Label.Text = "Result Task 2: incomplete";
            // 
            // Task3Label
            // 
            this.Task3Label.Location = new System.Drawing.Point(12, 39);
            this.Task3Label.Name = "Task3Label";
            this.Task3Label.Size = new System.Drawing.Size(150, 15);
            this.Task3Label.TabIndex = 2;
            this.Task3Label.Text = "Result Task 3: incomplete";
            // 
            // Task4Label
            // 
            this.Task4Label.Location = new System.Drawing.Point(12, 54);
            this.Task4Label.Name = "Task4Label";
            this.Task4Label.Size = new System.Drawing.Size(150, 15);
            this.Task4Label.TabIndex = 3;
            this.Task4Label.Text = "Result Task 4: incomplete";
            // 
            // Task5Label
            // 
            this.Task5Label.Location = new System.Drawing.Point(12, 69);
            this.Task5Label.Name = "Task5Label";
            this.Task5Label.Size = new System.Drawing.Size(150, 15);
            this.Task5Label.TabIndex = 4;
            this.Task5Label.Text = "Result Task 5: incomplete";
            // 
            // CheckButton
            // 
            this.CheckButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckButton.Location = new System.Drawing.Point(12, 87);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(150, 23);
            this.CheckButton.TabIndex = 5;
            this.CheckButton.Text = "Check Tasks";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Test1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 121);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.Task5Label);
            this.Controls.Add(this.Task4Label);
            this.Controls.Add(this.Task3Label);
            this.Controls.Add(this.Task2Label);
            this.Controls.Add(this.Task1Label);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Test1Form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label Task1Label;
        private Label Task2Label;
        private Label Task3Label;
        private Label Task4Label;
        private Label Task5Label;
        private Button CheckButton;
    }
}