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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCodemaker = new Button();
            btnCodebreaker = new Button();
            menuStrip1 = new MenuStrip();
            runToolStripMenuItem = new ToolStripMenuItem();
            codemakerToolStripMenuItem = new ToolStripMenuItem();
            codebreakerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            label3.Location = new Point(22, 132);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "Ritvik Komaragiri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 163);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 3;
            label4.Text = "Hendrick Davermand";
            // 
            // btnCodemaker
            // 
            btnCodemaker.Location = new Point(22, 235);
            btnCodemaker.Name = "btnCodemaker";
            btnCodemaker.Size = new Size(149, 64);
            btnCodemaker.TabIndex = 4;
            btnCodemaker.Text = "Run Codemaker";
            btnCodemaker.UseVisualStyleBackColor = true;
            btnCodemaker.Click += btnCodemaker_Click;
            // 
            // btnCodebreaker
            // 
            btnCodebreaker.Location = new Point(370, 235);
            btnCodebreaker.Name = "btnCodebreaker";
            btnCodebreaker.Size = new Size(149, 64);
            btnCodebreaker.TabIndex = 5;
            btnCodebreaker.Text = "Run Codebreaker";
            btnCodebreaker.UseVisualStyleBackColor = true;
            btnCodebreaker.Click += btnCodebreaker_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { runToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(564, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
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
            codemakerToolStripMenuItem.Name = "codemakerToolStripMenuItem";
            codemakerToolStripMenuItem.Size = new Size(224, 26);
            codemakerToolStripMenuItem.Text = "Codemaker";
            // 
            // codebreakerToolStripMenuItem
            // 
            codebreakerToolStripMenuItem.Name = "codebreakerToolStripMenuItem";
            codebreakerToolStripMenuItem.Size = new Size(224, 26);
            codebreakerToolStripMenuItem.Text = "Codebreaker";
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 346);
            Controls.Add(btnCodebreaker);
            Controls.Add(btnCodemaker);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Welcome";
            Text = "Welcome";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem codemakerToolStripMenuItem;
        private ToolStripMenuItem codebreakerToolStripMenuItem;
    }
}