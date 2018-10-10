namespace SelectionSort
{
    partial class MinMaxMedianModeSelectionSortForm
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.MaxButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.MeanButton = new System.Windows.Forms.Button();
            this.MedianButton = new System.Windows.Forms.Button();
            this.ModeButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.ScrambleButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AscendingRadioButton = new System.Windows.Forms.RadioButton();
            this.DescendingRadioButton = new System.Windows.Forms.RadioButton();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.multiModeButton = new System.Windows.Forms.Button();
            this.DevModeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(131, 12);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(75, 20);
            this.numberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a number:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(212, 1);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(115, 22);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Add to List";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.Location = new System.Drawing.Point(12, 100);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(194, 264);
            this.numberListBox.TabIndex = 3;
            // 
            // MaxButton
            // 
            this.MaxButton.Location = new System.Drawing.Point(212, 61);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(115, 27);
            this.MaxButton.TabIndex = 4;
            this.MaxButton.Text = "Max";
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // MinButton
            // 
            this.MinButton.Location = new System.Drawing.Point(212, 94);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(115, 31);
            this.MinButton.TabIndex = 5;
            this.MinButton.Text = "Min";
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            this.MinButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SubmitButton_MouseUp);
            // 
            // MeanButton
            // 
            this.MeanButton.Location = new System.Drawing.Point(212, 131);
            this.MeanButton.Name = "MeanButton";
            this.MeanButton.Size = new System.Drawing.Size(115, 38);
            this.MeanButton.TabIndex = 6;
            this.MeanButton.Text = "Mean (Average)";
            this.MeanButton.UseVisualStyleBackColor = true;
            this.MeanButton.Click += new System.EventHandler(this.MeanButton_Click);
            // 
            // MedianButton
            // 
            this.MedianButton.Location = new System.Drawing.Point(212, 175);
            this.MedianButton.Name = "MedianButton";
            this.MedianButton.Size = new System.Drawing.Size(115, 31);
            this.MedianButton.TabIndex = 7;
            this.MedianButton.Text = "Median";
            this.MedianButton.UseVisualStyleBackColor = true;
            this.MedianButton.Click += new System.EventHandler(this.MedianButton_Click);
            // 
            // ModeButton
            // 
            this.ModeButton.Location = new System.Drawing.Point(212, 212);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(115, 31);
            this.ModeButton.TabIndex = 8;
            this.ModeButton.Text = "Mode";
            this.ModeButton.UseVisualStyleBackColor = true;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(212, 249);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(115, 29);
            this.SortButton.TabIndex = 9;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 376);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 10;
            // 
            // ScrambleButton
            // 
            this.ScrambleButton.Location = new System.Drawing.Point(212, 326);
            this.ScrambleButton.Name = "ScrambleButton";
            this.ScrambleButton.Size = new System.Drawing.Size(115, 37);
            this.ScrambleButton.TabIndex = 11;
            this.ScrambleButton.Text = "Scramble";
            this.ScrambleButton.UseVisualStyleBackColor = true;
            this.ScrambleButton.Click += new System.EventHandler(this.ScrambleButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(212, 24);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(115, 22);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AscendingRadioButton
            // 
            this.AscendingRadioButton.AutoSize = true;
            this.AscendingRadioButton.Checked = true;
            this.AscendingRadioButton.Location = new System.Drawing.Point(212, 282);
            this.AscendingRadioButton.Name = "AscendingRadioButton";
            this.AscendingRadioButton.Size = new System.Drawing.Size(75, 17);
            this.AscendingRadioButton.TabIndex = 13;
            this.AscendingRadioButton.TabStop = true;
            this.AscendingRadioButton.Text = "Ascending";
            this.AscendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // DescendingRadioButton
            // 
            this.DescendingRadioButton.AutoSize = true;
            this.DescendingRadioButton.Location = new System.Drawing.Point(212, 299);
            this.DescendingRadioButton.Name = "DescendingRadioButton";
            this.DescendingRadioButton.Size = new System.Drawing.Size(82, 17);
            this.DescendingRadioButton.TabIndex = 14;
            this.DescendingRadioButton.Text = "Descending";
            this.DescendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.Menu;
            this.outputBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.outputBox.Location = new System.Drawing.Point(12, 373);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(315, 30);
            this.outputBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiModeButton
            // 
            this.multiModeButton.Location = new System.Drawing.Point(106, 61);
            this.multiModeButton.Name = "multiModeButton";
            this.multiModeButton.Size = new System.Drawing.Size(87, 28);
            this.multiModeButton.TabIndex = 17;
            this.multiModeButton.Text = "Multi-Mode";
            this.multiModeButton.UseVisualStyleBackColor = true;
            this.multiModeButton.Click += new System.EventHandler(this.multiModeButton_Click);
            // 
            // DevModeButton
            // 
            this.DevModeButton.Location = new System.Drawing.Point(345, 62);
            this.DevModeButton.Name = "DevModeButton";
            this.DevModeButton.Size = new System.Drawing.Size(75, 23);
            this.DevModeButton.TabIndex = 18;
            this.DevModeButton.Text = "DevMode";
            this.DevModeButton.UseVisualStyleBackColor = true;
            this.DevModeButton.Click += new System.EventHandler(this.DevModeButton_Click);
            // 
            // MinMaxMedianModeSelectionSortForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 406);
            this.Controls.Add(this.DevModeButton);
            this.Controls.Add(this.multiModeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.DescendingRadioButton);
            this.Controls.Add(this.AscendingRadioButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ScrambleButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.MedianButton);
            this.Controls.Add(this.MeanButton);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.MaxButton);
            this.Controls.Add(this.numberListBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Name = "MinMaxMedianModeSelectionSortForm";
            this.Text = "Basic Operations Implemented with Lists";
            this.Load += new System.EventHandler(this.MinMaxMedianModeSelectionSortForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Button MeanButton;
        private System.Windows.Forms.Button MedianButton;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button ScrambleButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RadioButton AscendingRadioButton;
        private System.Windows.Forms.RadioButton DescendingRadioButton;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button multiModeButton;
        private System.Windows.Forms.Button DevModeButton;
    }
}

