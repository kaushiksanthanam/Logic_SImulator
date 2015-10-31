namespace Logic_Simulator
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
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.fileDisplayTextBox = new System.Windows.Forms.TextBox();
            this.parseFileButton = new System.Windows.Forms.Button();
            this.outputFormulaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputStringTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.applyInputButton = new System.Windows.Forms.Button();
            this.outputValueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(12, 12);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.ReadOnly = true;
            this.filePathTextBox.Size = new System.Drawing.Size(272, 20);
            this.filePathTextBox.TabIndex = 0;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(290, 12);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(35, 20);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // fileDisplayTextBox
            // 
            this.fileDisplayTextBox.Location = new System.Drawing.Point(12, 67);
            this.fileDisplayTextBox.Multiline = true;
            this.fileDisplayTextBox.Name = "fileDisplayTextBox";
            this.fileDisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileDisplayTextBox.Size = new System.Drawing.Size(480, 440);
            this.fileDisplayTextBox.TabIndex = 2;
            // 
            // parseFileButton
            // 
            this.parseFileButton.Location = new System.Drawing.Point(332, 12);
            this.parseFileButton.Name = "parseFileButton";
            this.parseFileButton.Size = new System.Drawing.Size(119, 20);
            this.parseFileButton.TabIndex = 3;
            this.parseFileButton.Text = "Parse File";
            this.parseFileButton.UseVisualStyleBackColor = true;
            this.parseFileButton.Click += new System.EventHandler(this.parseFileButton_Click);
            // 
            // outputFormulaTextBox
            // 
            this.outputFormulaTextBox.Location = new System.Drawing.Point(498, 67);
            this.outputFormulaTextBox.Multiline = true;
            this.outputFormulaTextBox.Name = "outputFormulaTextBox";
            this.outputFormulaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputFormulaTextBox.Size = new System.Drawing.Size(657, 217);
            this.outputFormulaTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "INPUT FILE CONTENTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "OUTPUT FORMULA";
            // 
            // inputStringTextBox
            // 
            this.inputStringTextBox.Location = new System.Drawing.Point(603, 12);
            this.inputStringTextBox.Name = "inputStringTextBox";
            this.inputStringTextBox.Size = new System.Drawing.Size(206, 20);
            this.inputStringTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Input String";
            // 
            // applyInputButton
            // 
            this.applyInputButton.Location = new System.Drawing.Point(815, 10);
            this.applyInputButton.Name = "applyInputButton";
            this.applyInputButton.Size = new System.Drawing.Size(131, 22);
            this.applyInputButton.TabIndex = 9;
            this.applyInputButton.Text = "Apply Input";
            this.applyInputButton.UseVisualStyleBackColor = true;
            this.applyInputButton.Click += new System.EventHandler(this.applyInputButton_Click);
            // 
            // outputValueTextBox
            // 
            this.outputValueTextBox.Location = new System.Drawing.Point(498, 310);
            this.outputValueTextBox.Multiline = true;
            this.outputValueTextBox.Name = "outputValueTextBox";
            this.outputValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputValueTextBox.Size = new System.Drawing.Size(657, 197);
            this.outputValueTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "OUTPUT VALUES";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputValueTextBox);
            this.Controls.Add(this.applyInputButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputStringTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputFormulaTextBox);
            this.Controls.Add(this.parseFileButton);
            this.Controls.Add(this.fileDisplayTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.filePathTextBox);
            this.Name = "MainForm";
            this.Text = "Logic Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox fileDisplayTextBox;
        private System.Windows.Forms.Button parseFileButton;
        private System.Windows.Forms.TextBox outputFormulaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputStringTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyInputButton;
        private System.Windows.Forms.TextBox outputValueTextBox;
        private System.Windows.Forms.Label label4;
    }
}

