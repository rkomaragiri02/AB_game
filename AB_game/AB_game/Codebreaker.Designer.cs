namespace AB_game
{
    partial class Codebreaker
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
        private void InitializeComponent()
        {
            richTextBoxUserIn = new RichTextBox();
            btnGuess = new Button();
            SuspendLayout();
            // 
            // richTextBoxUserIn
            // 
            richTextBoxUserIn.Font = new Font("Segoe UI", 30F);
            richTextBoxUserIn.Location = new Point(82, 58);
            richTextBoxUserIn.MaxLength = 4;
            richTextBoxUserIn.Name = "richTextBoxUserIn";
            richTextBoxUserIn.Size = new Size(177, 80);
            richTextBoxUserIn.TabIndex = 0;
            richTextBoxUserIn.Text = "";
            // 
            // btnGuess
            // 
            btnGuess.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuess.Location = new Point(102, 162);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(132, 70);
            btnGuess.TabIndex = 1;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // Codebreaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 450);
            Controls.Add(btnGuess);
            Controls.Add(richTextBoxUserIn);
            Name = "Codebreaker";
            Text = "Codebreaker";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxUserIn;
        private Button btnGuess;
    }
}