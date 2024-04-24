namespace AB_game
{
    partial class Welcome
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCodemaker = new Button();
            btnCodebreaker = new Button();
            WelcMenuStrip = new MenuStrip();
            runToolStripMenuItem = new ToolStripMenuItem();
            codemakerToolStripMenuItem = new ToolStripMenuItem();
            codebreakerToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            WelcContMenuStrip = new ContextMenuStrip(components);
            codemakerToolStripMenuItem1 = new ToolStripMenuItem();
            codebreakerToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            label5 = new Label();
            textBoxPlayerName = new TextBox();
            buttonGameData = new Button();
            WelcMenuStrip.SuspendLayout();
            WelcContMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(507, 46);
            label1.TabIndex = 0;
            label1.Text = "CIS 3433 Group 6 Final Project";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 103);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Ross Edwards";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 103);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "Ritvik Komaragiri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 103);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 3;
            label4.Text = "Hendrick Davermand";
            // 
            // btnCodemaker
            // 
            btnCodemaker.Enabled = false;
            btnCodemaker.Location = new Point(22, 264);
            btnCodemaker.Name = "btnCodemaker";
            btnCodemaker.Size = new Size(149, 64);
            btnCodemaker.TabIndex = 4;
            btnCodemaker.Text = "Run Codemaker";
            btnCodemaker.UseVisualStyleBackColor = true;
            btnCodemaker.Click += btnCodemaker_Click;
            // 
            // btnCodebreaker
            // 
            btnCodebreaker.Enabled = false;
            btnCodebreaker.Location = new Point(370, 264);
            btnCodebreaker.Name = "btnCodebreaker";
            btnCodebreaker.Size = new Size(149, 64);
            btnCodebreaker.TabIndex = 5;
            btnCodebreaker.Text = "Run Codebreaker";
            btnCodebreaker.UseVisualStyleBackColor = true;
            btnCodebreaker.Click += btnCodebreaker_Click;
            // 
            // WelcMenuStrip
            // 
            WelcMenuStrip.ImageScalingSize = new Size(20, 20);
            WelcMenuStrip.Items.AddRange(new ToolStripItem[] { runToolStripMenuItem, exitToolStripMenuItem });
            WelcMenuStrip.Location = new Point(0, 0);
            WelcMenuStrip.Name = "WelcMenuStrip";
            WelcMenuStrip.Size = new Size(564, 28);
            WelcMenuStrip.TabIndex = 6;
            WelcMenuStrip.Text = "menuStrip1";
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { codemakerToolStripMenuItem, codebreakerToolStripMenuItem });
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(48, 24);
            runToolStripMenuItem.Text = "Run";
            // 
            // codemakerToolStripMenuItem
            // 
            codemakerToolStripMenuItem.Enabled = false;
            codemakerToolStripMenuItem.Name = "codemakerToolStripMenuItem";
            codemakerToolStripMenuItem.Size = new Size(177, 26);
            codemakerToolStripMenuItem.Text = "Codemaker";
            codemakerToolStripMenuItem.Click += codemakerToolStripMenuItem_Click;
            // 
            // codebreakerToolStripMenuItem
            // 
            codebreakerToolStripMenuItem.Enabled = false;
            codebreakerToolStripMenuItem.Name = "codebreakerToolStripMenuItem";
            codebreakerToolStripMenuItem.Size = new Size(177, 26);
            codebreakerToolStripMenuItem.Text = "Codebreaker";
            codebreakerToolStripMenuItem.Click += codebreakerToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // WelcContMenuStrip
            // 
            WelcContMenuStrip.ImageScalingSize = new Size(20, 20);
            WelcContMenuStrip.Items.AddRange(new ToolStripItem[] { codemakerToolStripMenuItem1, codebreakerToolStripMenuItem1, exitToolStripMenuItem1 });
            WelcContMenuStrip.Name = "WelcContMenuStrip";
            WelcContMenuStrip.Size = new Size(164, 76);
            // 
            // codemakerToolStripMenuItem1
            // 
            codemakerToolStripMenuItem1.Enabled = false;
            codemakerToolStripMenuItem1.Name = "codemakerToolStripMenuItem1";
            codemakerToolStripMenuItem1.Size = new Size(163, 24);
            codemakerToolStripMenuItem1.Text = "Codemaker";
            codemakerToolStripMenuItem1.Click += codemakerToolStripMenuItem1_Click;
            // 
            // codebreakerToolStripMenuItem1
            // 
            codebreakerToolStripMenuItem1.Enabled = false;
            codebreakerToolStripMenuItem1.Name = "codebreakerToolStripMenuItem1";
            codebreakerToolStripMenuItem1.Size = new Size(163, 24);
            codebreakerToolStripMenuItem1.Text = "Codebreaker";
            codebreakerToolStripMenuItem1.Click += codebreakerToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(163, 24);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(117, 183);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 7;
            label5.Text = "Enter Name";
            // 
            // textBoxPlayerName
            // 
            textBoxPlayerName.Font = new Font("Segoe UI", 9F);
            textBoxPlayerName.Location = new Point(231, 180);
            textBoxPlayerName.MaxLength = 20;
            textBoxPlayerName.Name = "textBoxPlayerName";
            textBoxPlayerName.Size = new Size(163, 27);
            textBoxPlayerName.TabIndex = 8;
            textBoxPlayerName.TextChanged += textBoxPlayerName_TextChanged;
            // 
            // buttonGameData
            // 
            buttonGameData.Location = new Point(231, 299);
            buttonGameData.Name = "buttonGameData";
            buttonGameData.Size = new Size(94, 29);
            buttonGameData.TabIndex = 9;
            buttonGameData.Text = "Game Data";
            buttonGameData.UseVisualStyleBackColor = true;
            buttonGameData.Click += buttonGameData_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 392);
            ContextMenuStrip = WelcContMenuStrip;
            Controls.Add(buttonGameData);
            Controls.Add(textBoxPlayerName);
            Controls.Add(label5);
            Controls.Add(btnCodebreaker);
            Controls.Add(btnCodemaker);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(WelcMenuStrip);
            MainMenuStrip = WelcMenuStrip;
            Name = "Welcome";
            Text = "Welcome";
            WelcMenuStrip.ResumeLayout(false);
            WelcMenuStrip.PerformLayout();
            WelcContMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCodemaker;
        private Button btnCodebreaker;
        private MenuStrip WelcMenuStrip;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem codemakerToolStripMenuItem;
        private ToolStripMenuItem codebreakerToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ContextMenuStrip WelcContMenuStrip;
        private ToolStripMenuItem codemakerToolStripMenuItem1;
        private ToolStripMenuItem codebreakerToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Label label5;
        private TextBox textBoxPlayerName;
        private Button buttonGameData;
    }
}