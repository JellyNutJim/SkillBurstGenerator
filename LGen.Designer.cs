namespace SkillBurstGenerator
{
    partial class LGen
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
            this.ExportButton = new System.Windows.Forms.Button();
            this.DeleteQButton = new System.Windows.Forms.Button();
            this.EditQButton = new System.Windows.Forms.Button();
            this.AddQButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.LessonPanel = new System.Windows.Forms.Panel();
            this.AddNewLesson = new System.Windows.Forms.Button();
            this.QuestionPanel.SuspendLayout();
            this.LessonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(640, 673);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 44;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // DeleteQButton
            // 
            this.DeleteQButton.Location = new System.Drawing.Point(417, 673);
            this.DeleteQButton.Name = "DeleteQButton";
            this.DeleteQButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteQButton.TabIndex = 43;
            this.DeleteQButton.Text = "Delete";
            this.DeleteQButton.UseVisualStyleBackColor = true;
            // 
            // EditQButton
            // 
            this.EditQButton.Location = new System.Drawing.Point(336, 673);
            this.EditQButton.Name = "EditQButton";
            this.EditQButton.Size = new System.Drawing.Size(75, 23);
            this.EditQButton.TabIndex = 42;
            this.EditQButton.Text = "Edit";
            this.EditQButton.UseVisualStyleBackColor = true;
            // 
            // AddQButton
            // 
            this.AddQButton.Location = new System.Drawing.Point(255, 673);
            this.AddQButton.Name = "AddQButton";
            this.AddQButton.Size = new System.Drawing.Size(75, 23);
            this.AddQButton.TabIndex = 41;
            this.AddQButton.Text = "Add";
            this.AddQButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Questions";
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionPanel.Controls.Add(this.vScrollBar1);
            this.QuestionPanel.Location = new System.Drawing.Point(15, 131);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(126, 565);
            this.QuestionPanel.TabIndex = 39;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(158, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 363);
            this.vScrollBar1.TabIndex = 0;
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Location = new System.Drawing.Point(10, 76);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(121, 21);
            this.TypeCombo.TabIndex = 6;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(7, 51);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Quiz Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(10, 28);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 34;
            // 
            // LessonPanel
            // 
            this.LessonPanel.AutoScroll = true;
            this.LessonPanel.Controls.Add(this.AddNewLesson);
            this.LessonPanel.Location = new System.Drawing.Point(170, 12);
            this.LessonPanel.Name = "LessonPanel";
            this.LessonPanel.Size = new System.Drawing.Size(529, 655);
            this.LessonPanel.TabIndex = 45;
            // 
            // AddNewLesson
            // 
            this.AddNewLesson.Location = new System.Drawing.Point(13, 15);
            this.AddNewLesson.Name = "AddNewLesson";
            this.AddNewLesson.Size = new System.Drawing.Size(75, 23);
            this.AddNewLesson.TabIndex = 35;
            this.AddNewLesson.Text = "Add New Lesson Area";
            this.AddNewLesson.UseVisualStyleBackColor = true;
            this.AddNewLesson.Click += new System.EventHandler(this.AddNewLesson_Click);
            // 
            // LGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 715);
            this.Controls.Add(this.TypeCombo);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.LessonPanel);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.DeleteQButton);
            this.Controls.Add(this.EditQButton);
            this.Controls.Add(this.AddQButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "LGen";
            this.Text = "LGen";
            this.QuestionPanel.ResumeLayout(false);
            this.LessonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button DeleteQButton;
        private System.Windows.Forms.Button EditQButton;
        private System.Windows.Forms.Button AddQButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel LessonPanel;
        private System.Windows.Forms.Button AddNewLesson;
    }
}