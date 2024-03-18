using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBurstGenerator
{
    internal class Question
    {
        public string question;
        public int answer_count;
        public Boolean long_form;
        public ArrayList answers;
        public int correct_index;

        public Question(string q, int c, Boolean lf, ArrayList ans, int cor)
        {
            question = q;
            answer_count = c;
            long_form = lf;
            answers = ans;
            correct_index = cor;
        }
    }
}
