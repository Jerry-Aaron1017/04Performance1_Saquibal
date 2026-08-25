using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04Performance1_Saquibal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the background color of the form
            this.BackColor = Color.DarkSlateGray;
            // Set the text color of the labels
            Words_Section.ForeColor = Color.LightBlue;
            Wrong_Guesses.ForeColor = Color.LightBlue;
            Given_Word.ForeColor = Color.LightBlue;

            // Set the font of the labels
            Words_Section.Font = new Font("Calibri", 15F, FontStyle.Bold);
            Wrong_Guesses.Font = new Font("Calibri", 15F, FontStyle.Bold);
            Given_Word.Font = new Font("Calibri", 15F, FontStyle.Bold);

            // Set the text alignment of the labels
            Words_Section.TextAlign = ContentAlignment.MiddleCenter;
            Wrong_Guesses.TextAlign = ContentAlignment.MiddleCenter;
            Given_Word.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void Act_Guess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a guess.");
                return;
            }

            //else if (string.Equals(this.Given_Word.Text)) {

            //}
        }
    }
}
