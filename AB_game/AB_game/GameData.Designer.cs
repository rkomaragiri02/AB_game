namespace AB_game
{
    partial class GameData
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
            dataGridViewGameHistory = new DataGridView();
            labelHeading = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGameHistory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGameHistory
            // 
            dataGridViewGameHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGameHistory.Location = new Point(12, 71);
            dataGridViewGameHistory.Name = "dataGridViewGameHistory";
            dataGridViewGameHistory.RowHeadersWidth = 51;
            dataGridViewGameHistory.Size = new Size(1009, 367);
            dataGridViewGameHistory.TabIndex = 0;
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelHeading.Location = new Point(432, 24);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(176, 35);
            labelHeading.TabIndex = 1;
            labelHeading.Text = "Game History";
            // 
            // GameData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 450);
            Controls.Add(labelHeading);
            Controls.Add(dataGridViewGameHistory);
            Name = "GameData";
            Text = "GameData";
            Load += GameData_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGameHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewGameHistory;
        private Label labelHeading;
    }
}