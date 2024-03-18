namespace SkillBurstGenerator
{
    partial class CreateNewQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewQuiz));
            this.QuizGenPanel = new System.Windows.Forms.Panel();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.FormatCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // QuizGenPanel
            // 
            this.QuizGenPanel.Location = new System.Drawing.Point(12, 55);
            this.QuizGenPanel.Name = "QuizGenPanel";
            this.QuizGenPanel.Size = new System.Drawing.Size(747, 754);
            this.QuizGenPanel.TabIndex = 2;
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Location = new System.Drawing.Point(12, 9);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(66, 13);
            this.FormatLabel.TabIndex = 39;
            this.FormatLabel.Text = "Quiz Format:";
            this.FormatLabel.Click += new System.EventHandler(this.FormatLabel_Click);
            // 
            // FormatCombo
            // 
            this.FormatCombo.FormattingEnabled = true;
            this.FormatCombo.Location = new System.Drawing.Point(12, 25);
            this.FormatCombo.Name = "FormatCombo";
            this.FormatCombo.Size = new System.Drawing.Size(121, 21);
            this.FormatCombo.TabIndex = 38;
            this.FormatCombo.SelectedIndexChanged += new System.EventHandler(this.FormatCombo_SelectedIndexChanged);
            // 
            // CreateNewQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 834);
            this.Controls.Add(this.FormatLabel);
            this.Controls.Add(this.FormatCombo);
            this.Controls.Add(this.QuizGenPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewQuiz";
            this.Text = "CreateNewQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel QuizGenPanel;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.ComboBox FormatCombo;
    }
}