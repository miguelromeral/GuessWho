using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public struct Probability
    {
        public Question Question;
        public double Percent;

        public Probability(Question q, double p)
        {
            Question = q;
            Percent = p;
        }
    }
}
