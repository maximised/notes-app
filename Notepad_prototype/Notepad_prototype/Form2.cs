using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_prototype
{
    public partial class Form2 : Form
    {
        public string keyword;

        public Form2()
        {
            InitializeComponent();
            this.TextChanged += textBox1_TextChanged; 
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            keyword = textBox1.Text;  //keyword is what user types in box
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (keyword != string.Empty) 
            { 
                // This is where the functionality of the find button will be implemented
            }
        }
    }
}
