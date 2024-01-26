using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__Assessment
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

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(word))
            {
                listBox1.Items.Add(word);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a word or phrase.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string word = textBox1.Text.Trim();

                if (!string.IsNullOrEmpty(word))
                {
                    listBox1.Items[listBox1.SelectedIndex] = word;
                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a word or phrase.");
                }
            }
            else
            {
                MessageBox.Show("Please select a word or phrase to change.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please select a word or phrase to remove.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    
    

