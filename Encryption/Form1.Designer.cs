namespace Encryption
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
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.DecryptKey = new System.Windows.Forms.Button();
            this.EncryptKey = new System.Windows.Forms.Button();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(93, 14);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(329, 20);
            this.KeyTextBox.TabIndex = 2;
            this.KeyTextBox.Text = "Key";
            // 
            // DecryptKey
            // 
            this.DecryptKey.Location = new System.Drawing.Point(12, 41);
            this.DecryptKey.Name = "DecryptKey";
            this.DecryptKey.Size = new System.Drawing.Size(75, 23);
            this.DecryptKey.TabIndex = 3;
            this.DecryptKey.Text = "Decrypt";
            this.DecryptKey.UseVisualStyleBackColor = true;
            this.DecryptKey.Click += new System.EventHandler(this.DecryptClick);
            // 
            // EncryptKey
            // 
            this.EncryptKey.Location = new System.Drawing.Point(12, 12);
            this.EncryptKey.Name = "EncryptKey";
            this.EncryptKey.Size = new System.Drawing.Size(75, 23);
            this.EncryptKey.TabIndex = 4;
            this.EncryptKey.Text = "Encrypt";
            this.EncryptKey.UseVisualStyleBackColor = true;
            this.EncryptKey.Click += new System.EventHandler(this.EncryptClick);
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Location = new System.Drawing.Point(93, 41);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(75, 23);
            this.ChooseFileButton.TabIndex = 5;
            this.ChooseFileButton.Text = "Choose File";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(174, 43);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(248, 20);
            this.PathTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 73);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.EncryptKey);
            this.Controls.Add(this.DecryptKey);
            this.Controls.Add(this.KeyTextBox);
            this.MaximumSize = new System.Drawing.Size(450, 112);
            this.MinimumSize = new System.Drawing.Size(450, 112);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button DecryptKey;
        private System.Windows.Forms.Button EncryptKey;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox PathTextBox;
    }
}

