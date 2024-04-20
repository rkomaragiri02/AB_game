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
            label2 = new Label();
            textBoxName = new TextBox();
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
            textBoxCodeIn.Location = new Point(101, 106);
            textBoxCodeIn.MaxLength = 4;
            textBoxCodeIn.Name = "textBoxCodeIn";
            textBoxCodeIn.Size = new Size(125, 27);
            textBoxCodeIn.TabIndex = 1;
            textBoxCodeIn.TextChanged += textBoxCodeIn_TextChanged;
            // 
            // btnSetCode
            // 
            btnSetCode.Enabled = false;
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
            CMMenuStrip.Size = new Size(383, 28);
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
            labelCode.Location = new Point(0, 109);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(82, 20);
            labelCode.TabIndex = 6;
            labelCode.Text = "Enter Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 154);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 7;
            label2.Text = "Enter name*";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(101, 151);
            textBoxName.MaxLength = 4;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 8;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // Codemaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 298);
            ContextMenuStrip = CMContextStrip;
            Controls.Add(textBoxName);
            Controls.Add(label2);
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
        private Label label2;
        private TextBox textBoxName;
    }
}