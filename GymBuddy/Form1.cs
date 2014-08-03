using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymBuddy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void addExer_Click(object sender, EventArgs e)
        {
            string reps = repsBox.Text;
            string exer = exerBox.Text;
            Exercise ex = new Exercise(reps, exer);
            Console.WriteLine(exer);
        }

        private void exerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void repsBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
