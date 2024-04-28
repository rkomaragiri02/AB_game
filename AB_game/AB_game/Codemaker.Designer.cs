namespace AB_game
{
    partial class Codemaker
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
            label1 = new Label();
            textBoxCodeIn = new TextBox();
            btnSetCode = new Button();
            btnRandomise = new Button();
            CMContextStrip = new ContextMenuStrip(components);
            actionsToolStripMenuItem = new ToolStripMenuItem();
            setCodeToolStripMenuItem = new ToolStripMenuItem();
            randomiseToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            CMMenuStrip = new MenuStrip();
            actionsToolStripMenuItem1 = new ToolStripMenuItem();
            setCodeToolStripMenuItem1 = new ToolStripMenuItem();
            randomizeToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            labelCode = new Label();
            labelGuess = new Label();
            textBoxUserGuess = new TextBox();
            buttonGuess = new Button();
            label3 = new Label();
            timerGame = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            labelTimeElapsed = new Label();
            labelGuessesRemaining = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxHint = new TextBox();
            CMContextStrip.SuspendLayout();
            CMMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(201, 46);
            label1.TabIndex = 0;
            label1.Text = "Codemaker";
            // 
            // textBoxCodeIn
            // 
            textBoxCodeIn.Location = new Point(115, 106);
            textBoxCodeIn.MaxLength = 4;
            textBoxCodeIn.Name = "textBoxCodeIn";
            textBoxCodeIn.Size = new Size(125, 27);
            textBoxCodeIn.TabIndex = 1;
            textBoxCodeIn.TextChanged += textBoxCodeIn_TextChanged;
            // 
            // btnSetCode
            // 
            btnSetCode.Location = new Point(259, 90);
            btnSetCode.Name = "btnSetCode";
            btnSetCode.Size = new Size(112, 58);
            btnSetCode.TabIndex = 2;
            btnSetCode.Text = "Set Code";
            btnSetCode.UseVisualStyleBackColor = true;
            btnSetCode.Click += btnSetCode_Click;
            // 
            // btnRandomise
            // 
            btnRandomise.Location = new Point(259, 154);
            btnRandomise.Name = "btnRandomise";
            btnRandomise.Size = new Size(112, 58);
            btnRandomise.TabIndex = 3;
            btnRandomise.Text = "Randomize Code";
            btnRandomise.UseVisualStyleBackColor = true;
            btnRandomise.Click += btnRandomise_Click;
            // 
            // CMContextStrip
            // 
            CMContextStrip.ImageScalingSize = new Size(20, 20);
            CMContextStrip.Items.AddRange(new ToolStripItem[] { actionsToolStripMenuItem });
            CMContextStrip.Name = "CMContextStrip";
            CMContextStrip.Size = new Size(128, 28);
            // 
            // actionsToolStripMenuItem
            // 
            actionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setCodeToolStripMenuItem, randomiseToolStripMenuItem, exitToolStripMenuItem });
            actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            actionsToolStripMenuItem.Size = new Size(127, 24);
            actionsToolStripMenuItem.Text = "Actions";
            // 
            // setCodeToolStripMenuItem
            // 
            setCodeToolStripMenuItem.Name = "setCodeToolStripMenuItem";
            setCodeToolStripMenuItem.Size = new Size(166, 26);
            setCodeToolStripMenuItem.Text = "Set Code";
            setCodeToolStripMenuItem.Click += setCodeToolStripMenuItem_Click;
            // 
            // randomiseToolStripMenuItem
            // 
            randomiseToolStripMenuItem.Name = "randomiseToolStripMenuItem";
            randomiseToolStripMenuItem.Size = new Size(166, 26);
            randomiseToolStripMenuItem.Text = "Randomise";
            randomiseToolStripMenuItem.Click += randomiseToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(166, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // CMMenuStrip
            // 
            CMMenuStrip.ImageScalingSize = new Size(20, 20);
            CMMenuStrip.Items.AddRange(new ToolStripItem[] { actionsToolStripMenuItem1 });
            CMMenuStrip.Location = new Point(0, 0);
            CMMenuStrip.Name = "CMMenuStrip";
            CMMenuStrip.Size = new Size(823, 28);
            CMMenuStrip.TabIndex = 5;
            CMMenuStrip.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem1
            // 
            actionsToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { setCodeToolStripMenuItem1, randomizeToolStripMenuItem, exitToolStripMenuItem1 });
            actionsToolStripMenuItem1.Name = "actionsToolStripMenuItem1";
            actionsToolStripMenuItem1.Size = new Size(72, 24);
            actionsToolStripMenuItem1.Text = "Actions";
            // 
            // setCodeToolStripMenuItem1
            // 
            setCodeToolStripMenuItem1.Name = "setCodeToolStripMenuItem1";
            setCodeToolStripMenuItem1.Size = new Size(167, 26);
            setCodeToolStripMenuItem1.Text = "Set Code";
            setCodeToolStripMenuItem1.Click += setCodeToolStripMenuItem1_Click;
            // 
            // randomizeToolStripMenuItem
            // 
            randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            randomizeToolStripMenuItem.Size = new Size(167, 26);
            randomizeToolStripMenuItem.Text = "Randomize";
            randomizeToolStripMenuItem.Click += randomizeToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(167, 26);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Location = new Point(14, 109);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(82, 20);
            labelCode.TabIndex = 6;
            labelCode.Text = "Enter Code";
            // 
            // labelGuess
            // 
            labelGuess.AutoSize = true;
            labelGuess.Location = new Point(466, 73);
            labelGuess.Name = "labelGuess";
            labelGuess.Size = new Size(163, 20);
            labelGuess.TabIndex = 9;
            labelGuess.Text = "Please enter your guess";
            // 
            // textBoxUserGuess
            // 
            textBoxUserGuess.Location = new Point(645, 70);
            textBoxUserGuess.MaxLength = 4;
            textBoxUserGuess.Name = "textBoxUserGuess";
            textBoxUserGuess.Size = new Size(125, 27);
            textBoxUserGuess.TabIndex = 10;
            // 
            // buttonGuess
            // 
            buttonGuess.Enabled = false;
            buttonGuess.Location = new Point(497, 154);
            buttonGuess.Name = "buttonGuess";
            buttonGuess.Size = new Size(112, 58);
            buttonGuess.TabIndex = 11;
            buttonGuess.Text = "Guess";
            buttonGuess.UseVisualStyleBackColor = true;
            buttonGuess.Click += buttonGuess_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(638, 154);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 12;
            label3.Text = "Number of Guesses";
            // 
            // timerGame
            // 
            timerGame.Interval = 1000;
            timerGame.Tick += timerGame_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(655, 214);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 13;
            label2.Text = "Time Elapsed";
            // 
            // labelTimeElapsed
            // 
            labelTimeElapsed.AutoSize = true;
            labelTimeElapsed.Font = new Font("Segoe UI", 12F);
            labelTimeElapsed.Location = new Point(690, 234);
            labelTimeElapsed.Name = "labelTimeElapsed";
            labelTimeElapsed.Size = new Size(23, 28);
            labelTimeElapsed.TabIndex = 14;
            labelTimeElapsed.Text = "0";
            // 
            // labelGuessesRemaining
            // 
            labelGuessesRemaining.AutoSize = true;
            labelGuessesRemaining.Font = new Font("Segoe UI", 12F);
            labelGuessesRemaining.Location = new Point(690, 174);
            labelGuessesRemaining.Name = "labelGuessesRemaining";
            labelGuessesRemaining.Size = new Size(34, 28);
            labelGuessesRemaining.TabIndex = 15;
            labelGuessesRemaining.Text = "10";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 234);
            label4.Name = "label4";
            label4.Size = new Size(302, 20);
            label4.TabIndex = 16;
            label4.Text = "* Once you set the code, the timer will begin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(528, 113);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 17;
            label5.Text = "Hint";
            // 
            // textBoxHint
            // 
            textBoxHint.Location = new Point(645, 110);
            textBoxHint.Name = "textBoxHint";
            textBoxHint.ReadOnly = true;
            textBoxHint.Size = new Size(125, 27);
            textBoxHint.TabIndex = 18;
            // 
            // Codemaker
            // 
            AcceptButton = buttonGuess;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 334);
            ContextMenuStrip = CMContextStrip;
            Controls.Add(textBoxHint);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelGuessesRemaining);
            Controls.Add(labelTimeElapsed);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(buttonGuess);
            Controls.Add(textBoxUserGuess);
            Controls.Add(labelGuess);
            Controls.Add(labelCode);
            Controls.Add(CMMenuStrip);
            Controls.Add(btnRandomise);
            Controls.Add(btnSetCode);
            Controls.Add(textBoxCodeIn);
            Controls.Add(label1);
            MainMenuStrip = CMMenuStrip;
            Name = "Codemaker";
            Text = "Codemaker";
            CMContextStrip.ResumeLayout(false);
            CMMenuStrip.ResumeLayout(false);
            CMMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCodeIn;
        private Button btnSetCode;
        private Button btnRandomise;
        private ContextMenuStrip CMContextStrip;
        private MenuStrip CMMenuStrip;
        private ToolStripMenuItem actionsToolStripMenuItem;
        private ToolStripMenuItem setCodeToolStripMenuItem;
        private ToolStripMenuItem randomiseToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem actionsToolStripMenuItem1;
        private ToolStripMenuItem setCodeToolStripMenuItem1;
        private ToolStripMenuItem randomizeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Label labelCode;
        private Label labelGuess;
        private TextBox textBoxUserGuess;
        private Button buttonGuess;
        private Label label3;
        private System.Windows.Forms.Timer timerGame;
        private Label label2;
        private Label labelTimeElapsed;
        private Label labelGuessesRemaining;
        private Label label4;
        private Label label5;
        private TextBox textBoxHint;
    }
}