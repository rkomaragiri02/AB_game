﻿namespace AB_game
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
            components = new System.ComponentModel.Container();
            richTextBoxUserIn = new RichTextBox();
            btnGuess = new Button();
            CBContextStrip = new ContextMenuStrip(components);
            guessToolStripMenuItem1 = new ToolStripMenuItem();
            guessToolStripMenuItem2 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            CBMenuStrip = new MenuStrip();
            actionsToolStripMenuItem = new ToolStripMenuItem();
            guessToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            timerGame = new System.Windows.Forms.Timer(components);
            lbGuesses = new ListBox();
            labelGuesses = new Label();
            label1 = new Label();
            labelTimeSeconds = new Label();
            label2 = new Label();
            CBContextStrip.SuspendLayout();
            CBMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxUserIn
            // 
            richTextBoxUserIn.Font = new Font("Segoe UI", 30F);
            richTextBoxUserIn.Location = new Point(83, 122);
            richTextBoxUserIn.MaxLength = 4;
            richTextBoxUserIn.Name = "richTextBoxUserIn";
            richTextBoxUserIn.Size = new Size(177, 80);
            richTextBoxUserIn.TabIndex = 0;
            richTextBoxUserIn.Text = "";
            // 
            // btnGuess
            // 
            btnGuess.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuess.Location = new Point(103, 232);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(132, 70);
            btnGuess.TabIndex = 1;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // CBContextStrip
            // 
            CBContextStrip.ImageScalingSize = new Size(20, 20);
            CBContextStrip.Items.AddRange(new ToolStripItem[] { guessToolStripMenuItem1 });
            CBContextStrip.Name = "contextMenuStrip1";
            CBContextStrip.Size = new Size(128, 28);
            CBContextStrip.Opening += CBContextStrip_Opening;
            // 
            // guessToolStripMenuItem1
            // 
            guessToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { guessToolStripMenuItem2, exitToolStripMenuItem });
            guessToolStripMenuItem1.Name = "guessToolStripMenuItem1";
            guessToolStripMenuItem1.Size = new Size(127, 24);
            guessToolStripMenuItem1.Text = "Actions";
            // 
            // guessToolStripMenuItem2
            // 
            guessToolStripMenuItem2.Name = "guessToolStripMenuItem2";
            guessToolStripMenuItem2.Size = new Size(130, 26);
            guessToolStripMenuItem2.Text = "Guess";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(130, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // CBMenuStrip
            // 
            CBMenuStrip.ImageScalingSize = new Size(20, 20);
            CBMenuStrip.Items.AddRange(new ToolStripItem[] { actionsToolStripMenuItem });
            CBMenuStrip.Location = new Point(0, 0);
            CBMenuStrip.Name = "CBMenuStrip";
            CBMenuStrip.Size = new Size(585, 28);
            CBMenuStrip.TabIndex = 3;
            CBMenuStrip.Text = "menuStrip1";
            CBMenuStrip.ItemClicked += CBMenuStrip_ItemClicked;
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { guessToolStripMenuItem, exitToolStripMenuItem1 });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(72, 24);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // guessToolStripMenuItem
            // 
            guessToolStripMenuItem.Name = "guessToolStripMenuItem";
            guessToolStripMenuItem.Size = new Size(130, 26);
            guessToolStripMenuItem.Text = "Guess";
            guessToolStripMenuItem.Click += guessToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(130, 26);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // timerGame
            // 
            timerGame.Interval = 1000;
            timerGame.Tick += timerGame_Tick;
            // 
            // lbGuesses
            // 
            lbGuesses.FormattingEnabled = true;
            lbGuesses.Location = new Point(320, 58);
            lbGuesses.Name = "lbGuesses";
            lbGuesses.Size = new Size(215, 344);
            lbGuesses.TabIndex = 4;
            // 
            // labelGuesses
            // 
            labelGuesses.AutoSize = true;
            labelGuesses.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGuesses.Location = new Point(396, 35);
            labelGuesses.Name = "labelGuesses";
            labelGuesses.Size = new Size(66, 20);
            labelGuesses.TabIndex = 5;
            labelGuesses.Text = "Guesses";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 335);
            label1.Name = "label1";
            label1.Size = new Size(150, 35);
            label1.TabIndex = 6;
            label1.Text = "Time Taken";
            // 
            // labelTimeSeconds
            // 
            labelTimeSeconds.AutoSize = true;
            labelTimeSeconds.Font = new Font("Segoe UI", 15F);
            labelTimeSeconds.Location = new Point(168, 335);
            labelTimeSeconds.Name = "labelTimeSeconds";
            labelTimeSeconds.Size = new Size(81, 35);
            labelTimeSeconds.TabIndex = 7;
            labelTimeSeconds.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 99);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 8;
            label2.Text = "Enter Guess Here";
            // 
            // Codebreaker
            // 
            AcceptButton = btnGuess;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 450);
            ContextMenuStrip = CBContextStrip;
            Controls.Add(label2);
            Controls.Add(labelTimeSeconds);
            Controls.Add(label1);
            Controls.Add(labelGuesses);
            Controls.Add(lbGuesses);
            Controls.Add(CBMenuStrip);
            Controls.Add(btnGuess);
            Controls.Add(richTextBoxUserIn);
            MainMenuStrip = CBMenuStrip;
            Name = "Codebreaker";
            Text = "Codebreaker";
            Load += Codebreaker_Load;
            CBContextStrip.ResumeLayout(false);
            CBMenuStrip.ResumeLayout(false);
            CBMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxUserIn;
        private Button btnGuess;
        private ContextMenuStrip CBContextStrip;
        private ToolStripMenuItem guessToolStripMenuItem1;
        private MenuStrip CBMenuStrip;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem guessToolStripMenuItem;
        private ToolStripMenuItem guessToolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Timer timerGame;
        private ListBox lbGuesses;
        private Label labelGuesses;
        private Label label1;
        private Label labelTimeSeconds;
        private Label label2;
    }
}