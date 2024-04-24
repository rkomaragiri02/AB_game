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
            components = new System.ComponentModel.Container();
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
            titleGuesses = new Label();
            label1 = new Label();
            labelPossibleGuesses = new Label();
            EnterHintLabel = new Label();
            BreakerHints = new TextBox();
            LabelGuess = new Label();
            CBContextStrip.SuspendLayout();
            CBMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuess
            // 
            btnGuess.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuess.Location = new Point(54, 245);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(175, 77);
            btnGuess.TabIndex = 1;
            btnGuess.Text = "Generate Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // CBContextStrip
            // 
            CBContextStrip.ImageScalingSize = new Size(20, 20);
            CBContextStrip.Items.AddRange(new ToolStripItem[] { guessToolStripMenuItem1 });
            CBContextStrip.Name = "contextMenuStrip1";
            CBContextStrip.Size = new Size(211, 56);
            CBContextStrip.Opening += CBContextStrip_Opening;
            // 
            // guessToolStripMenuItem1
            // 
            guessToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { guessToolStripMenuItem2, exitToolStripMenuItem });
            guessToolStripMenuItem1.Name = "guessToolStripMenuItem1";
            guessToolStripMenuItem1.Size = new Size(210, 24);
            guessToolStripMenuItem1.Text = "Actions";
            // 
            // guessToolStripMenuItem2
            // 
            guessToolStripMenuItem2.Name = "guessToolStripMenuItem2";
            guessToolStripMenuItem2.Size = new Size(224, 26);
            guessToolStripMenuItem2.Text = "Generate Guess";
            guessToolStripMenuItem2.Click += guessToolStripMenuItem2_Click;
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
            guessToolStripMenuItem.Size = new Size(224, 26);
            guessToolStripMenuItem.Text = "Generate Guess";
            guessToolStripMenuItem.Click += guessToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(224, 26);
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
            lbGuesses.Location = new Point(358, 58);
            lbGuesses.Name = "lbGuesses";
            lbGuesses.Size = new Size(215, 344);
            lbGuesses.TabIndex = 4;
            // 
            // titleGuesses
            // 
            titleGuesses.AutoSize = true;
            titleGuesses.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            titleGuesses.Location = new Point(438, 35);
            titleGuesses.Name = "titleGuesses";
            titleGuesses.Size = new Size(66, 20);
            titleGuesses.TabIndex = 5;
            titleGuesses.Text = "Guesses";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 367);
            label1.Name = "label1";
            label1.Size = new Size(211, 35);
            label1.TabIndex = 6;
            label1.Text = "Possible Guesses";
            // 
            // labelPossibleGuesses
            // 
            labelPossibleGuesses.AutoSize = true;
            labelPossibleGuesses.Font = new Font("Segoe UI", 15F);
            labelPossibleGuesses.Location = new Point(229, 367);
            labelPossibleGuesses.Name = "labelPossibleGuesses";
            labelPossibleGuesses.Size = new Size(28, 35);
            labelPossibleGuesses.TabIndex = 7;
            labelPossibleGuesses.Text = "0";
            // 
            // EnterHintLabel
            // 
            EnterHintLabel.AutoSize = true;
            EnterHintLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnterHintLabel.Location = new Point(83, 58);
            EnterHintLabel.Name = "EnterHintLabel";
            EnterHintLabel.Size = new Size(116, 31);
            EnterHintLabel.TabIndex = 8;
            EnterHintLabel.Text = "Enter Hint";
            // 
            // BreakerHints
            // 
            BreakerHints.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BreakerHints.Location = new Point(83, 107);
            BreakerHints.MaxLength = 4;
            BreakerHints.Multiline = true;
            BreakerHints.Name = "BreakerHints";
            BreakerHints.Size = new Size(125, 38);
            BreakerHints.TabIndex = 9;
            // 
            // LabelGuess
            // 
            LabelGuess.AutoSize = true;
            LabelGuess.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelGuess.Location = new Point(108, 182);
            LabelGuess.Name = "LabelGuess";
            LabelGuess.Size = new Size(68, 46);
            LabelGuess.TabIndex = 10;
            LabelGuess.Text = "Init";
            // 
            // Codebreaker
            // 
            AcceptButton = btnGuess;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 450);
            ContextMenuStrip = CBContextStrip;
            Controls.Add(LabelGuess);
            Controls.Add(BreakerHints);
            Controls.Add(EnterHintLabel);
            Controls.Add(labelPossibleGuesses);
            Controls.Add(label1);
            Controls.Add(titleGuesses);
            Controls.Add(lbGuesses);
            Controls.Add(CBMenuStrip);
            Controls.Add(btnGuess);
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
        private Label titleGuesses;
        private Label label1;
        private Label labelPossibleGuesses;
        private Label EnterHintLabel;
        private TextBox BreakerHints;
        private Label LabelGuess;
    }
}