
namespace Base10Converter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.base10TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.binaryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.octalTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base10";
            // 
            // base10TextBox
            // 
            this.base10TextBox.Location = new System.Drawing.Point(80, 10);
            this.base10TextBox.Name = "base10TextBox";
            this.base10TextBox.Size = new System.Drawing.Size(279, 20);
            this.base10TextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Binary";
            // 
            // binaryTextBox
            // 
            this.binaryTextBox.Enabled = false;
            this.binaryTextBox.Location = new System.Drawing.Point(80, 48);
            this.binaryTextBox.Name = "binaryTextBox";
            this.binaryTextBox.Size = new System.Drawing.Size(279, 20);
            this.binaryTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Octal";
            // 
            // octalTextBox
            // 
            this.octalTextBox.Enabled = false;
            this.octalTextBox.Location = new System.Drawing.Point(80, 79);
            this.octalTextBox.Name = "octalTextBox";
            this.octalTextBox.Size = new System.Drawing.Size(279, 20);
            this.octalTextBox.TabIndex = 5;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(80, 126);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(143, 55);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 205);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.octalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.binaryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.base10TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Base10 Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox base10TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox binaryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox octalTextBox;
        private System.Windows.Forms.Button convertButton;
    }
}

