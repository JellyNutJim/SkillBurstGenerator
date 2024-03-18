using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SkillBurstGenerator
{
    public partial class MCGen : Form
    {
        public MCGen()
        {
            InitializeComponent();
            
            // Types - Subset of Formats
            TypeCombo.Items.Add("question_time");
            TypeCombo.Items.Add("total_time");
            TypeCombo.Items.Add("untimed");
            
            QuestionPanel.AutoScroll = true;
        }

        private ArrayList questionData = new ArrayList();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void QuizMaker_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            createNewMCQuestion();
        }

        private void createNewMCQuestion()
        {
            string questionTitle = QuestionBox.Text;
            Boolean longform = LongFormCheckBox.Checked;
            ArrayList answers = new ArrayList();
            if (A1Box.Text != "") { answers.Add(A1Box.Text);}
            if (A2Box.Text != "") { answers.Add(A2Box.Text); }
            if (A3Box.Text != "") { answers.Add(A3Box.Text); }
            if (A4Box.Text != "") { answers.Add(A4Box.Text); }

            int correctIndex = 0;
            switch (CorrectIndexGroup.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked).Name)
            {
                case "A1Correct":
                    correctIndex = 0;
                    break;
                case "A2Correct":
                    correctIndex = 1;
                    break;
                case "A3Correct":
                    correctIndex = 2;
                    break;
                case "A4Correct":
                    correctIndex = 3;
                    break;
            }

            int qIndex = questionData.Count;

            Question q = new Question(questionTitle, answers.Count, longform, answers, correctIndex);
            questionData.Add(q);
            updateQuestionList();
        }

        private void updateQuestionList()
        {
            int i = questionData.Count;

            Button b = new Button();
            b.Text = "Question " + (i);
            b.Name = "q" + i;
            b.Click += (s, EventArgs) => { QuestionButton_click(s, EventArgs, i-1); };
            b.Location = new System.Drawing.Point(10, 25*(i-1));
            i++;
            this.QuestionPanel.Controls.Add(b);
            QuestionPanel.Show();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            MultipleChoiceQuiz quiz = new MultipleChoiceQuiz
            {
                name = nameBox.Text,
                format = "multiple_choice",
                time = Convert.ToInt32(Math.Round(TimeBox.Value, 0)),
                number_of_questions = questionData.Count,
                type = TypeCombo.Text,
                questions = questionData
            };
            string json = JsonConvert.SerializeObject(quiz, Formatting.Indented);
            File.WriteAllText(@PathBox.Text, json);
        }

        private void QuestionButton_click(object sender, EventArgs e, int i)
        {
            Console.WriteLine(sender);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
