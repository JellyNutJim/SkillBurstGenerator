using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillBurstGenerator
{
    public partial class CreateNewQuiz : Form
    {
        private LGen lg = new LGen();
        private MCGen mcg = new MCGen();
        public CreateNewQuiz()
        {
            InitializeComponent();
            // Formats
            FormatCombo.Items.Add("lesson");
            FormatCombo.Items.Add("lesson_quiz");
            FormatCombo.Items.Add("multiple_choice");



            lg.TopLevel = false;
            lg.FormBorderStyle = FormBorderStyle.None;
            QuizGenPanel.Controls.Add(lg);

            mcg.TopLevel = false;
            mcg.FormBorderStyle = FormBorderStyle.None;
            QuizGenPanel.Controls.Add(mcg);


        }

        private void mc()
        {
            MCGen q = new MCGen();
            q.TopLevel = false;
            q.FormBorderStyle = FormBorderStyle.None;
            QuizGenPanel.Controls.Add(q);
            q.Visible = true;
            QuizGenPanel.Show();
        }

        private void FormatCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lg.Visible = false;
            mcg.Visible = false;
            
            switch (FormatCombo.SelectedIndex)
            {
                case 0:
                    lg.Visible = true;
                    break;
                case 1:
                    break;
                case 2:
                    mcg.Visible = true;
                    break;
            }
            QuizGenPanel.Show();
        }

        private void FormatLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
