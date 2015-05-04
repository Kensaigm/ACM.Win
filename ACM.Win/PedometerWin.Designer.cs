namespace ACM.Win
{
    partial class PedometerWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GoalTextBox = new System.Windows.Forms.TextBox();
            this.StepsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step Goal for Today:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Steps Today:";
            // 
            // GoalTextBox
            // 
            this.GoalTextBox.Location = new System.Drawing.Point(209, 24);
            this.GoalTextBox.Name = "GoalTextBox";
            this.GoalTextBox.Size = new System.Drawing.Size(147, 22);
            this.GoalTextBox.TabIndex = 2;
            // 
            // StepsTextBox
            // 
            this.StepsTextBox.Location = new System.Drawing.Point(210, 53);
            this.StepsTextBox.Name = "StepsTextBox";
            this.StepsTextBox.Size = new System.Drawing.Size(146, 22);
            this.StepsTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(63, 134);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 17);
            this.ResultLabel.TabIndex = 5;
            // 
            // PedometerWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 255);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StepsTextBox);
            this.Controls.Add(this.GoalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PedometerWin";
            this.Text = "Pedometer Metrics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GoalTextBox;
        private System.Windows.Forms.TextBox StepsTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ResultLabel;
    }
}