namespace _04Performance1_Saquibal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        
        private System.Windows.Forms.Label label1;   
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Act_Guess = new System.Windows.Forms.Button();
            this.Wrong_Guesses = new System.Windows.Forms.Label();
            this.Words_Section = new System.Windows.Forms.Label();
            this.Given_Word = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(50, 244);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 50);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Act_Guess
            // 
            this.Act_Guess.BackColor = System.Drawing.Color.LightBlue;
            this.Act_Guess.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Act_Guess.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Act_Guess.Location = new System.Drawing.Point(173, 310);
            this.Act_Guess.Name = "Act_Guess";
            this.Act_Guess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Act_Guess.Size = new System.Drawing.Size(155, 50);
            this.Act_Guess.TabIndex = 2;
            this.Act_Guess.Text = "Guess";
            this.Act_Guess.UseMnemonic = false;
            this.Act_Guess.UseVisualStyleBackColor = false;
            this.Act_Guess.Click += new System.EventHandler(this.Act_Guess_Click);
            // 
            // Wrong_Guesses
            // 
            this.Wrong_Guesses.BackColor = System.Drawing.Color.LightBlue;
            this.Wrong_Guesses.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Wrong_Guesses.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wrong_Guesses.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Wrong_Guesses.Location = new System.Drawing.Point(544, 23);
            this.Wrong_Guesses.Name = "Wrong_Guesses";
            this.Wrong_Guesses.Size = new System.Drawing.Size(200, 69);
            this.Wrong_Guesses.TabIndex = 3;
            this.Wrong_Guesses.Text = "Wrong Guesses";
            this.Wrong_Guesses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Words_Section
            // 
            this.Words_Section.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Words_Section.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Words_Section.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Words_Section.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Words_Section.ForeColor = System.Drawing.Color.Black;
            this.Words_Section.Location = new System.Drawing.Point(487, 106);
            this.Words_Section.Name = "Words_Section";
            this.Words_Section.Padding = new System.Windows.Forms.Padding(20, 20, 10, 10);
            this.Words_Section.Size = new System.Drawing.Size(301, 315);
            this.Words_Section.TabIndex = 4;
            this.Words_Section.Text = "words";
            this.Words_Section.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Words_Section.UseMnemonic = false;
            // 
            // Given_Word
            // 
            this.Given_Word.BackColor = System.Drawing.Color.LightBlue;
            this.Given_Word.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Given_Word.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.Given_Word.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Given_Word.Location = new System.Drawing.Point(49, 72);
            this.Given_Word.Name = "Given_Word";
            this.Given_Word.Size = new System.Drawing.Size(406, 141);
            this.Given_Word.TabIndex = 5;
            this.Given_Word.Text = "TEXT";
            this.Given_Word.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Given_Word);
            this.Controls.Add(this.Words_Section);
            this.Controls.Add(this.Wrong_Guesses);
            this.Controls.Add(this.Act_Guess);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = " Guess the Word ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Act_Guess;
        private System.Windows.Forms.Label Wrong_Guesses;
        private System.Windows.Forms.Label Words_Section;
        private System.Windows.Forms.Label Given_Word;
    }
}

