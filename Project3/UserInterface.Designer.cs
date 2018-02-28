namespace Project3
{
    partial class uxUserInterface
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
            this.uxOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uxMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxWeatherListBox = new System.Windows.Forms.ListBox();
            this.uxGroupBox = new System.Windows.Forms.GroupBox();
            this.uxDateHistory = new System.Windows.Forms.RadioButton();
            this.uxAboveTempButton = new System.Windows.Forms.RadioButton();
            this.uxBelowTempButton = new System.Windows.Forms.RadioButton();
            this.uxDateRangeButton = new System.Windows.Forms.RadioButton();
            this.uxFilterButton = new System.Windows.Forms.Button();
            this.uxUndoButton = new System.Windows.Forms.Button();
            this.uxMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.uxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            this.uxGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // uxOpenFile
            // 
            this.uxOpenFile.Filter = "Text files (*.txt)|*.txt";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenMenu});
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Size = new System.Drawing.Size(37, 20);
            this.uxMenuStrip.Text = "File";
            // 
            // uxOpenMenu
            // 
            this.uxOpenMenu.Name = "uxOpenMenu";
            this.uxOpenMenu.Size = new System.Drawing.Size(112, 22);
            this.uxOpenMenu.Text = "Open...";
            this.uxOpenMenu.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // uxWeatherListBox
            // 
            this.uxWeatherListBox.FormattingEnabled = true;
            this.uxWeatherListBox.Location = new System.Drawing.Point(12, 46);
            this.uxWeatherListBox.Name = "uxWeatherListBox";
            this.uxWeatherListBox.Size = new System.Drawing.Size(295, 290);
            this.uxWeatherListBox.TabIndex = 1;
            // 
            // uxGroupBox
            // 
            this.uxGroupBox.Controls.Add(this.uxDateHistory);
            this.uxGroupBox.Controls.Add(this.uxAboveTempButton);
            this.uxGroupBox.Controls.Add(this.uxBelowTempButton);
            this.uxGroupBox.Controls.Add(this.uxDateRangeButton);
            this.uxGroupBox.Location = new System.Drawing.Point(328, 46);
            this.uxGroupBox.Name = "uxGroupBox";
            this.uxGroupBox.Size = new System.Drawing.Size(193, 134);
            this.uxGroupBox.TabIndex = 2;
            this.uxGroupBox.TabStop = false;
            this.uxGroupBox.Text = "Filter Options:";
            // 
            // uxDateHistory
            // 
            this.uxDateHistory.AutoSize = true;
            this.uxDateHistory.Location = new System.Drawing.Point(7, 105);
            this.uxDateHistory.Name = "uxDateHistory";
            this.uxDateHistory.Size = new System.Drawing.Size(113, 17);
            this.uxDateHistory.TabIndex = 3;
            this.uxDateHistory.TabStop = true;
            this.uxDateHistory.Text = "This date in history";
            this.uxDateHistory.UseVisualStyleBackColor = true;
            // 
            // uxAboveTempButton
            // 
            this.uxAboveTempButton.AutoSize = true;
            this.uxAboveTempButton.Location = new System.Drawing.Point(7, 82);
            this.uxAboveTempButton.Name = "uxAboveTempButton";
            this.uxAboveTempButton.Size = new System.Drawing.Size(174, 17);
            this.uxAboveTempButton.TabIndex = 2;
            this.uxAboveTempButton.TabStop = true;
            this.uxAboveTempButton.Text = "Dates above given temperature";
            this.uxAboveTempButton.UseVisualStyleBackColor = true;
            // 
            // uxBelowTempButton
            // 
            this.uxBelowTempButton.AutoSize = true;
            this.uxBelowTempButton.Location = new System.Drawing.Point(7, 59);
            this.uxBelowTempButton.Name = "uxBelowTempButton";
            this.uxBelowTempButton.Size = new System.Drawing.Size(172, 17);
            this.uxBelowTempButton.TabIndex = 1;
            this.uxBelowTempButton.TabStop = true;
            this.uxBelowTempButton.Text = "Dates below given temperature";
            this.uxBelowTempButton.UseVisualStyleBackColor = true;
            // 
            // uxDateRangeButton
            // 
            this.uxDateRangeButton.AutoSize = true;
            this.uxDateRangeButton.Location = new System.Drawing.Point(7, 36);
            this.uxDateRangeButton.Name = "uxDateRangeButton";
            this.uxDateRangeButton.Size = new System.Drawing.Size(158, 17);
            this.uxDateRangeButton.TabIndex = 0;
            this.uxDateRangeButton.TabStop = true;
            this.uxDateRangeButton.Text = "Dates during selected range";
            this.uxDateRangeButton.UseVisualStyleBackColor = true;
            // 
            // uxFilterButton
            // 
            this.uxFilterButton.Location = new System.Drawing.Point(328, 280);
            this.uxFilterButton.Name = "uxFilterButton";
            this.uxFilterButton.Size = new System.Drawing.Size(75, 23);
            this.uxFilterButton.TabIndex = 3;
            this.uxFilterButton.Text = "Filter";
            this.uxFilterButton.UseVisualStyleBackColor = true;
            this.uxFilterButton.Click += new System.EventHandler(this.FilterClick);
            // 
            // uxUndoButton
            // 
            this.uxUndoButton.Enabled = false;
            this.uxUndoButton.Location = new System.Drawing.Point(410, 279);
            this.uxUndoButton.Name = "uxUndoButton";
            this.uxUndoButton.Size = new System.Drawing.Size(75, 23);
            this.uxUndoButton.TabIndex = 4;
            this.uxUndoButton.Text = "Undo";
            this.uxUndoButton.UseVisualStyleBackColor = true;
            this.uxUndoButton.Click += new System.EventHandler(this.UndoClick);
            // 
            // uxMonthCalendar
            // 
            this.uxMonthCalendar.Location = new System.Drawing.Point(542, 46);
            this.uxMonthCalendar.MaxDate = new System.DateTime(2018, 2, 8, 0, 0, 0, 0);
            this.uxMonthCalendar.MaxSelectionCount = 31;
            this.uxMonthCalendar.MinDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.uxMonthCalendar.Name = "uxMonthCalendar";
            this.uxMonthCalendar.TabIndex = 5;
            this.uxMonthCalendar.TodayDate = new System.DateTime(2018, 2, 8, 0, 0, 0, 0);
            // 
            // uxNumericUpDown
            // 
            this.uxNumericUpDown.Location = new System.Drawing.Point(542, 263);
            this.uxNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.uxNumericUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.uxNumericUpDown.Name = "uxNumericUpDown";
            this.uxNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.uxNumericUpDown.TabIndex = 6;
            // 
            // uxUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 344);
            this.Controls.Add(this.uxNumericUpDown);
            this.Controls.Add(this.uxMonthCalendar);
            this.Controls.Add(this.uxUndoButton);
            this.Controls.Add(this.uxFilterButton);
            this.Controls.Add(this.uxGroupBox);
            this.Controls.Add(this.uxWeatherListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "uxUserInterface";
            this.Text = "Filter Weather Data";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.uxGroupBox.ResumeLayout(false);
            this.uxGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog uxOpenFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem uxOpenMenu;
        private System.Windows.Forms.ListBox uxWeatherListBox;
        private System.Windows.Forms.GroupBox uxGroupBox;
        private System.Windows.Forms.RadioButton uxAboveTempButton;
        private System.Windows.Forms.RadioButton uxBelowTempButton;
        private System.Windows.Forms.RadioButton uxDateRangeButton;
        private System.Windows.Forms.Button uxFilterButton;
        private System.Windows.Forms.Button uxUndoButton;
        private System.Windows.Forms.MonthCalendar uxMonthCalendar;
        private System.Windows.Forms.NumericUpDown uxNumericUpDown;
        private System.Windows.Forms.RadioButton uxDateHistory;
    }
}

