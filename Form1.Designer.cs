namespace WindowsFormsApplication3
{
    partial class Screen1
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
            this.SurveyB = new System.Windows.Forms.Button();
            this.ResultsB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SurveyB
            // 
            this.SurveyB.Location = new System.Drawing.Point(159, 32);
            this.SurveyB.Name = "SurveyB";
            this.SurveyB.Size = new System.Drawing.Size(281, 45);
            this.SurveyB.TabIndex = 0;
            this.SurveyB.Text = "Fill out survey";
            this.SurveyB.UseVisualStyleBackColor = true;
            this.SurveyB.Click += new System.EventHandler(this.SurveyB_Click);
            // 
            // ResultsB
            // 
            this.ResultsB.Location = new System.Drawing.Point(159, 120);
            this.ResultsB.Name = "ResultsB";
            this.ResultsB.Size = new System.Drawing.Size(281, 46);
            this.ResultsB.TabIndex = 1;
            this.ResultsB.Text = "View survey results";
            this.ResultsB.UseVisualStyleBackColor = true;
            this.ResultsB.Click += new System.EventHandler(this.ResultsB_Click);
            // 
            // Screen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 203);
            this.Controls.Add(this.ResultsB);
            this.Controls.Add(this.SurveyB);
            this.Name = "Screen1";
            this.Text = "Screen 1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SurveyB;
        private System.Windows.Forms.Button ResultsB;
    }
}

