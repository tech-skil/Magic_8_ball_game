using System;
using System.Collections.Generic;
using System.ComponentModel;    
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_8_ballame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<String> answers = new List<String>();
        // magic 8 ball game using c# .Net
        public Form1()
        {
            InitializeComponent();
            // Positive 
            answers.Add("It is decidedly so.");
            answers.Add("Without a doubt.");
            answers.Add("Yes definitely.");
            answers.Add("You may rely on it.");
            answers.Add("As I see it, yes.");
            answers.Add("Very likely.");
            answers.Add("The outlook is good.");
            answers.Add("Signs point to yes.");
            answers.Add("Yes.");
            answers.Add("Most likely.");
            // Non-committal 
            answers.Add("Ask again later.");
            answers.Add("Cannot predict now.");
            answers.Add("Concentrate and ask again.");
            answers.Add("Better not tell you now.");
            answers.Add("Better not tell you now.");
            // Negative (No answer)
            answers.Add("My reply is no.");
            answers.Add("My sources say no.");
            answers.Add("Outlook not so good.");
            answers.Add("Very doubtful.");
            answers.Add("Don't count on it.");

    }

    private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible=false;
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==string.Empty)
            {
                Form_Alert form = new Form_Alert();
                form.Show();
            }
            else
            {
            int index = random.Next(answers.Count);
            answerLable.Text = answers[index];
                
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text= string.Empty;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = username.Text;
            pass = passward.Text;
            if (user=="Admin" && pass == "Magicgame@123")
            {
                panel2.Visible = true;
                panel3.Visible = false;
                panel1.Visible = false;
                panel4.Visible = false;
                // MessageBox.Show("Login successful ");
            }
            else
            {
                MessageBox.Show("Invalid user name or password!. ");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
