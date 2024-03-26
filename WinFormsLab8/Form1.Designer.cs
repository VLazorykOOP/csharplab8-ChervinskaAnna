namespace TextProcessingApp
{
    partial class MainForm
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
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.outputFileLabel = new System.Windows.Forms.Label();
            this.inputFileTextBox = new System.Windows.Forms.TextBox();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.AutoSize = true;
            this.inputFileLabel.Location = new System.Drawing.Point(41, 58);
            this.inputFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(128, 25);
            this.inputFileLabel.TabIndex = 0;
            this.inputFileLabel.Text = "Input File Path:";
            // 
            // outputFileLabel
            // 
            this.outputFileLabel.AutoSize = true;
            this.outputFileLabel.Location = new System.Drawing.Point(41, 127);
            this.outputFileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputFileLabel.Name = "outputFileLabel";
            this.outputFileLabel.Size = new System.Drawing.Size(143, 25);
            this.outputFileLabel.TabIndex = 1;
            this.outputFileLabel.Text = "Output File Path:";
            // 
            // inputFileTextBox
            // 
            this.inputFileTextBox.Location = new System.Drawing.Point(200, 53);
            this.inputFileTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputFileTextBox.Name = "inputFileTextBox";
            this.inputFileTextBox.Size = new System.Drawing.Size(404, 31);
            this.inputFileTextBox.TabIndex = 2;
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Location = new System.Drawing.Point(200, 122);
            this.outputFileTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(404, 31);
            this.outputFileTextBox.TabIndex = 3;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(200, 190);
            this.processButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(107, 38);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 310);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.outputFileTextBox);
            this.Controls.Add(this.inputFileTextBox);
            this.Controls.Add(this.outputFileLabel);
            this.Controls.Add(this.inputFileLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Text Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.Label outputFileLabel;
        private System.Windows.Forms.TextBox inputFileTextBox;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Button processButton;
    }
}
