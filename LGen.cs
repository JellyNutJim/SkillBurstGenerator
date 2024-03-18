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
    public partial class LGen : Form
    {
        private int lessonPartCount = 0;
        public LGen()
        {
            InitializeComponent();
        }

        private void LessonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddNewLesson_Click(object sender, EventArgs e)
        {
            ComboBox c = new ComboBox();
            c.Items.Add("default");
            c.Location = new System.Drawing.Point(15, 150 * lessonPartCount + 50);

            RichTextBox t = new RichTextBox();
            t.Location = new System.Drawing.Point(15, 150 * lessonPartCount + 80);
            t.MinimumSize = new Size(419, 30);

            this.LessonPanel.Controls.Add(c);
            this.LessonPanel.Controls.Add(t);
            lessonPartCount++;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
