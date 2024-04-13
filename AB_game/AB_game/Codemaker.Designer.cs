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
            label1 = new Label();
            textBoxCodeIn = new TextBox();
            btnSetCode = new Button();
            btnRandomise = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(201, 46);
            label1.TabIndex = 0;
            label1.Text = "Codemaker";
            // 
            // textBoxCodeIn
            // 
            textBoxCodeIn.Location = new Point(12, 106);
            textBoxCodeIn.Name = "textBoxCodeIn";
            textBoxCodeIn.Size = new Size(125, 27);
            textBoxCodeIn.TabIndex = 1;
            textBoxCodeIn.TextChanged += textBoxCodeIn_TextChanged;
            // 
            // btnSetCode
            // 
            btnSetCode.Location = new Point(164, 90);
            btnSetCode.Name = "btnSetCode";
            btnSetCode.Size = new Size(112, 58);
            btnSetCode.TabIndex = 2;
            btnSetCode.Text = "Set Code";
            btnSetCode.UseVisualStyleBackColor = true;
            btnSetCode.Click += btnSetCode_Click;
            // 
            // btnRandomise
            // 
            btnRandomise.Location = new Point(25, 167);
            btnRandomise.Name = "btnRandomise";
            btnRandomise.Size = new Size(112, 58);
            btnRandomise.TabIndex = 3;
            btnRandomise.Text = "Randomise";
            btnRandomise.UseVisualStyleBackColor = true;
            btnRandomise.Click += btnRandomise_Click;
            // 
            // Codemaker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 298);
            Controls.Add(btnRandomise);
            Controls.Add(btnSetCode);
            Controls.Add(textBoxCodeIn);
            Controls.Add(label1);
            Name = "Codemaker";
            Text = "Codemaker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCodeIn;
        private Button btnSetCode;
        private Button btnRandomise;
    }
}