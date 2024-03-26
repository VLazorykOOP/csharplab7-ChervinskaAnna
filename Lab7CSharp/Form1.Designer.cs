namespace WindowsFormsApp
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.saveFileDialogButton = new System.Windows.Forms.Button();
            this.convertToGrayScaleButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 52);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 105);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 26);
            this.textBox1.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(51, 168);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(132, 50);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(240, 168);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(139, 50);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(24, 272);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(107, 50);
            this.openFileDialogButton.TabIndex = 4;
            this.openFileDialogButton.Text = "Open";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // saveFileDialogButton
            // 
            this.saveFileDialogButton.Location = new System.Drawing.Point(150, 272);
            this.saveFileDialogButton.Name = "saveFileDialogButton";
            this.saveFileDialogButton.Size = new System.Drawing.Size(108, 50);
            this.saveFileDialogButton.TabIndex = 5;
            this.saveFileDialogButton.Text = "Save";
            this.saveFileDialogButton.UseVisualStyleBackColor = true;
            this.saveFileDialogButton.Click += new System.EventHandler(this.saveFileDialogButton_Click);
            // 
            // convertToGrayScaleButton
            // 
            this.convertToGrayScaleButton.Location = new System.Drawing.Point(276, 272);
            this.convertToGrayScaleButton.Name = "convertToGrayScaleButton";
            this.convertToGrayScaleButton.Size = new System.Drawing.Size(132, 50);
            this.convertToGrayScaleButton.TabIndex = 6;
            this.convertToGrayScaleButton.Text = "Grayscale";
            this.convertToGrayScaleButton.UseVisualStyleBackColor = true;
            this.convertToGrayScaleButton.Click += new System.EventHandler(this.convertToGrayScaleButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(414, 38);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(737, 476);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 553);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.convertToGrayScaleButton);
            this.Controls.Add(this.saveFileDialogButton);
            this.Controls.Add(this.openFileDialogButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button openFileDialogButton;
        private System.Windows.Forms.Button saveFileDialogButton;
        private System.Windows.Forms.Button convertToGrayScaleButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
