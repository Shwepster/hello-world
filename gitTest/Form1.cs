using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gitTest
{
    public partial class Window1 : Form
    {
        Student student;

        public Window1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student = new Student(textBox1.Text, int.Parse(textBox2.Text));

            label4.Text = student.Name + student.Age + " years old";
        }

  
    }
}
