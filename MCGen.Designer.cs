namespace SkillBurstGenerator
{
    partial class MCGen
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimeBox = new System.Windows.Forms.NumericUpDown();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.AddQButton = new System.Windows.Forms.Button();
            this.newqslabel = new System.Windows.Forms.Label();
            this.QuestionBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditQButton = new System.Windows.Forms.Button();
            this.DeleteQButton = new System.Windows.Forms.Button();
            this.LongFormCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.A1Box = new System.Windows.Forms.TextBox();
            this.A2Box = new System.Windows.Forms.TextBox();
            this.A3Box = new System.Windows.Forms.TextBox();
            this.A4Box = new System.Windows.Forms.TextBox();
            this.A1Corect = new System.Windows.Forms.RadioButton();
            this.A2Correct = new System.Windows.Forms.RadioButton();
            this.A3Correct = new System.Windows.Forms.RadioButton();
            this.A4Correct = new System.Windows.Forms.RadioButton();
            this.ExportButton = new System.Windows.Forms.Button();
            this.CorrectIndexGroup = new System.Windows.Forms.GroupBox();
            this.MultipleChoicePanel = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBox)).BeginInit();
            this.QuestionPanel.SuspendLayout();
            this.CorrectIndexGroup.SuspendLayout();
            this.MultipleChoicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Location = new System.Drawing.Point(21, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quiz Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(6, 21);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type:";
            this.typeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Location = new System.Drawing.Point(6, 37);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(121, 21);
            this.TypeCombo.TabIndex = 6;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(7, 73);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(33, 13);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Required Correct:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(7, 154);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TimeBox);
            this.groupBox1.Controls.Add(this.TypeCombo);
            this.groupBox1.Controls.Add(this.typeLabel);
            this.groupBox1.Controls.Add(this.TimeLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 194);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format Requirements";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(8, 91);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(120, 20);
            this.TimeBox.TabIndex = 33;
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionPanel.Controls.Add(this.vScrollBar1);
            this.QuestionPanel.Location = new System.Drawing.Point(17, 287);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(104, 406);
            this.QuestionPanel.TabIndex = 12;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(158, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 363);
            this.vScrollBar1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Questions";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddQButton
            // 
            this.AddQButton.Location = new System.Drawing.Point(204, 334);
            this.AddQButton.Name = "AddQButton";
            this.AddQButton.Size = new System.Drawing.Size(75, 23);
            this.AddQButton.TabIndex = 14;
            this.AddQButton.Text = "Add";
            this.AddQButton.UseVisualStyleBackColor = true;
            this.AddQButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // newqslabel
            // 
            this.newqslabel.AutoSize = true;
            this.newqslabel.Location = new System.Drawing.Point(11, 6);
            this.newqslabel.Name = "newqslabel";
            this.newqslabel.Size = new System.Drawing.Size(97, 13);
            this.newqslabel.TabIndex = 15;
            this.newqslabel.Text = "Add new Question:";
            this.newqslabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // QuestionBox
            // 
            this.QuestionBox.Location = new System.Drawing.Point(14, 45);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(460, 59);
            this.QuestionBox.TabIndex = 16;
            this.QuestionBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Question:";
            // 
            // EditQButton
            // 
            this.EditQButton.Location = new System.Drawing.Point(577, 334);
            this.EditQButton.Name = "EditQButton";
            this.EditQButton.Size = new System.Drawing.Size(75, 23);
            this.EditQButton.TabIndex = 18;
            this.EditQButton.Text = "Edit";
            this.EditQButton.UseVisualStyleBackColor = true;
            // 
            // DeleteQButton
            // 
            this.DeleteQButton.Location = new System.Drawing.Point(658, 334);
            this.DeleteQButton.Name = "DeleteQButton";
            this.DeleteQButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteQButton.TabIndex = 19;
            this.DeleteQButton.Text = "Delete";
            this.DeleteQButton.UseVisualStyleBackColor = true;
            // 
            // LongFormCheckBox
            // 
            this.LongFormCheckBox.AutoSize = true;
            this.LongFormCheckBox.Location = new System.Drawing.Point(13, 118);
            this.LongFormCheckBox.Name = "LongFormCheckBox";
            this.LongFormCheckBox.Size = new System.Drawing.Size(76, 17);
            this.LongFormCheckBox.TabIndex = 21;
            this.LongFormCheckBox.Text = "Long Form";
            this.LongFormCheckBox.UseVisualStyleBackColor = true;
            this.LongFormCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Answers (leave blank to reduce answers):";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // A1Box
            // 
            this.A1Box.Location = new System.Drawing.Point(13, 174);
            this.A1Box.Name = "A1Box";
            this.A1Box.Size = new System.Drawing.Size(299, 20);
            this.A1Box.TabIndex = 23;
            // 
            // A2Box
            // 
            this.A2Box.Location = new System.Drawing.Point(13, 208);
            this.A2Box.Name = "A2Box";
            this.A2Box.Size = new System.Drawing.Size(299, 20);
            this.A2Box.TabIndex = 24;
            // 
            // A3Box
            // 
            this.A3Box.Location = new System.Drawing.Point(14, 245);
            this.A3Box.Name = "A3Box";
            this.A3Box.Size = new System.Drawing.Size(298, 20);
            this.A3Box.TabIndex = 25;
            // 
            // A4Box
            // 
            this.A4Box.Location = new System.Drawing.Point(14, 278);
            this.A4Box.Name = "A4Box";
            this.A4Box.Size = new System.Drawing.Size(298, 20);
            this.A4Box.TabIndex = 26;
            // 
            // A1Corect
            // 
            this.A1Corect.AutoSize = true;
            this.A1Corect.Location = new System.Drawing.Point(6, 21);
            this.A1Corect.Name = "A1Corect";
            this.A1Corect.Size = new System.Drawing.Size(59, 17);
            this.A1Corect.TabIndex = 27;
            this.A1Corect.TabStop = true;
            this.A1Corect.Text = "Correct";
            this.A1Corect.UseVisualStyleBackColor = true;
            // 
            // A2Correct
            // 
            this.A2Correct.AutoSize = true;
            this.A2Correct.Location = new System.Drawing.Point(6, 55);
            this.A2Correct.Name = "A2Correct";
            this.A2Correct.Size = new System.Drawing.Size(59, 17);
            this.A2Correct.TabIndex = 28;
            this.A2Correct.TabStop = true;
            this.A2Correct.Text = "Correct";
            this.A2Correct.UseVisualStyleBackColor = true;
            // 
            // A3Correct
            // 
            this.A3Correct.AutoSize = true;
            this.A3Correct.Location = new System.Drawing.Point(6, 92);
            this.A3Correct.Name = "A3Correct";
            this.A3Correct.Size = new System.Drawing.Size(59, 17);
            this.A3Correct.TabIndex = 29;
            this.A3Correct.TabStop = true;
            this.A3Correct.Text = "Correct";
            this.A3Correct.UseVisualStyleBackColor = true;
            // 
            // A4Correct
            // 
            this.A4Correct.AutoSize = true;
            this.A4Correct.Location = new System.Drawing.Point(6, 125);
            this.A4Correct.Name = "A4Correct";
            this.A4Correct.Size = new System.Drawing.Size(59, 17);
            this.A4Correct.TabIndex = 30;
            this.A4Correct.TabStop = true;
            this.A4Correct.Text = "Correct";
            this.A4Correct.UseVisualStyleBackColor = true;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(658, 670);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(75, 23);
            this.ExportButton.TabIndex = 31;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // CorrectIndexGroup
            // 
            this.CorrectIndexGroup.Controls.Add(this.A2Correct);
            this.CorrectIndexGroup.Controls.Add(this.A1Corect);
            this.CorrectIndexGroup.Controls.Add(this.A4Correct);
            this.CorrectIndexGroup.Controls.Add(this.A3Correct);
            this.CorrectIndexGroup.Location = new System.Drawing.Point(318, 157);
            this.CorrectIndexGroup.Name = "CorrectIndexGroup";
            this.CorrectIndexGroup.Size = new System.Drawing.Size(156, 154);
            this.CorrectIndexGroup.TabIndex = 32;
            this.CorrectIndexGroup.TabStop = false;
            this.CorrectIndexGroup.Text = "Select Correct Answer";
            // 
            // MultipleChoicePanel
            // 
            this.MultipleChoicePanel.Controls.Add(this.QuestionBox);
            this.MultipleChoicePanel.Controls.Add(this.CorrectIndexGroup);
            this.MultipleChoicePanel.Controls.Add(this.newqslabel);
            this.MultipleChoicePanel.Controls.Add(this.label4);
            this.MultipleChoicePanel.Controls.Add(this.A4Box);
            this.MultipleChoicePanel.Controls.Add(this.LongFormCheckBox);
            this.MultipleChoicePanel.Controls.Add(this.A3Box);
            this.MultipleChoicePanel.Controls.Add(this.label5);
            this.MultipleChoicePanel.Controls.Add(this.A2Box);
            this.MultipleChoicePanel.Controls.Add(this.A1Box);
            this.MultipleChoicePanel.Location = new System.Drawing.Point(204, 9);
            this.MultipleChoicePanel.Name = "MultipleChoicePanel";
            this.MultipleChoicePanel.Size = new System.Drawing.Size(529, 319);
            this.MultipleChoicePanel.TabIndex = 33;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(496, 334);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 34;
            this.BackBtn.Text = "Deselect";
            this.BackBtn.UseVisualStyleBackColor = true;
            // 
            // PathBox
            // 
            this.PathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathBox.Location = new System.Drawing.Point(226, 670);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(426, 20);
            this.PathBox.TabIndex = 42;
            this.PathBox.Text = "c:\\temp\\MyTest.json";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(188, 672);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(32, 13);
            this.PathLabel.TabIndex = 43;
            this.PathLabel.Text = "Path:";
            // 
            // MCGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 717);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.MultipleChoicePanel);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.DeleteQButton);
            this.Controls.Add(this.EditQButton);
            this.Controls.Add(this.AddQButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "MCGen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuizMaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBox)).EndInit();
            this.QuestionPanel.ResumeLayout(false);
            this.CorrectIndexGroup.ResumeLayout(false);
            this.CorrectIndexGroup.PerformLayout();
            this.MultipleChoicePanel.ResumeLayout(false);
            this.MultipleChoicePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddQButton;
        private System.Windows.Forms.Label newqslabel;
        private System.Windows.Forms.RichTextBox QuestionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EditQButton;
        private System.Windows.Forms.Button DeleteQButton;
        private System.Windows.Forms.CheckBox LongFormCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox A1Box;
        private System.Windows.Forms.TextBox A2Box;
        private System.Windows.Forms.TextBox A3Box;
        private System.Windows.Forms.TextBox A4Box;
        private System.Windows.Forms.RadioButton A1Corect;
        private System.Windows.Forms.RadioButton A2Correct;
        private System.Windows.Forms.RadioButton A3Correct;
        private System.Windows.Forms.RadioButton A4Correct;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.GroupBox CorrectIndexGroup;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.NumericUpDown TimeBox;
        private System.Windows.Forms.Panel MultipleChoicePanel;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label PathLabel;
    }
}

