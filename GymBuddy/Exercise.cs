using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBuddy
{
    class Exercise
    {
        string type;
        string reps;
        public Exercise(string exer,string reps)
        {
            this.type = exer;
            this.reps = reps;

        }

        public string ToString() 
        {
            string exerStr = "";
            exerStr += "Exercise: " + type + ".\n";
            exerStr += "Reps: " + reps + ".";
            return exerStr;
        }
    }
}
