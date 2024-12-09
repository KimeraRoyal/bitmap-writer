namespace BitmapWriter
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
            this.userInput = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadFontButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.AccessibleDescription = "Text entered in this field will be used to generate the sprite.";
            this.userInput.AccessibleName = "User Input";
            this.userInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(12, 274);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(279, 75);
            this.userInput.TabIndex = 0;
            this.userInput.Text = "Insert text";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(316, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 128);
            this.panel1.TabIndex = 1;
            // 
            // loadFontButton
            // 
            this.loadFontButton.Location = new System.Drawing.Point(12, 239);
            this.loadFontButton.Name = "loadFontButton";
            this.loadFontButton.Size = new System.Drawing.Size(99, 29);
            this.loadFontButton.TabIndex = 2;
            this.loadFontButton.Text = "Load Font";
            this.loadFontButton.UseVisualStyleBackColor = true;
            this.loadFontButton.Click += new System.EventHandler(this.loadFontButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.loadFontButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userInput);
            this.Name = "Form1";
            this.Text = "Bitmap Writer";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button loadFontButton;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.RichTextBox userInput;

        #endregion
    }
}