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
            CBContextStrip.SuspendLayout();
            CBMenuStrip.SuspendLayout();
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
            CBMenuStrip.Size = new Size(350, 28);
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
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(130, 26);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // Codebreaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 450);
            ContextMenuStrip = CBContextStrip;
            Controls.Add(CBMenuStrip);
            Controls.Add(btnGuess);
            Controls.Add(richTextBoxUserIn);
            MainMenuStrip = CBMenuStrip;
            Name = "Codebreaker";
            Text = "Codebreaker";
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
    }
}