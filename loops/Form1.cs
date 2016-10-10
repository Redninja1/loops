using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer = 0;
            int multiplyBy = int.Parse(textBox3.Text);                                 
            
            int loopStart;
                loopStart = int.Parse(textBox1.Text);
                
            int loopEnd;    
                loopEnd = int.Parse(textBox2.Text);

             listBox1.Items.Clear();

            for (int i = loopStart; i <= loopEnd; i++)

                   
            {
                     
                      answer = multiplyBy * i;
                      listBox1.Items.Add(i + " times " + multiplyBy + " = " + answer.ToString());
                     
                
            }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
