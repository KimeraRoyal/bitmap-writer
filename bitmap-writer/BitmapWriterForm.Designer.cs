using System;
using System.Windows.Forms;

namespace BitmapWriter
{
    partial class BitmapWriterForm
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
            this.loadFontButton = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.paddingLabel = new System.Windows.Forms.Label();
            this.paddingLeft = new System.Windows.Forms.NumericUpDown();
            this.paddingRight = new System.Windows.Forms.NumericUpDown();
            this.paddingLeftLabel = new System.Windows.Forms.Label();
            this.paddingRightLabel = new System.Windows.Forms.Label();
            this.paddingBottomLabel = new System.Windows.Forms.Label();
            this.paddingTopLabel = new System.Windows.Forms.Label();
            this.paddingBottom = new System.Windows.Forms.NumericUpDown();
            this.paddingTop = new System.Windows.Forms.NumericUpDown();
            this.textColourLabel = new System.Windows.Forms.Label();
            this.textColour = new System.Windows.Forms.Panel();
            this.textColourHex = new System.Windows.Forms.TextBox();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.PictureBox();
            this.saveResults = new System.Windows.Forms.Label();
            this.fontResults = new System.Windows.Forms.Label();
            this.credits = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.AccessibleDescription = "Text entered in this field will be used to generate the sprite.";
            this.userInput.AccessibleName = "User Input";
            this.userInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(311, 215);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(256, 102);
            this.userInput.TabIndex = 0;
            this.userInput.Text = "Insert text";
            // 
            // loadFontButton
            // 
            this.loadFontButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadFontButton.Location = new System.Drawing.Point(12, 138);
            this.loadFontButton.Name = "loadFontButton";
            this.loadFontButton.Size = new System.Drawing.Size(99, 29);
            this.loadFontButton.TabIndex = 2;
            this.loadFontButton.Text = "Load Font";
            this.loadFontButton.UseVisualStyleBackColor = true;
            this.loadFontButton.Click += new System.EventHandler(this.loadFontButton_Click);
            // 
            // testLabel
            // 
            this.testLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.testLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.testLabel.Location = new System.Drawing.Point(12, 9);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(256, 126);
            this.testLabel.TabIndex = 3;
            this.testLabel.Text = "No Font Loaded";
            this.testLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // fontSize
            // 
            this.fontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fontSize.Location = new System.Drawing.Point(118, 173);
            this.fontSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(150, 20);
            this.fontSize.TabIndex = 4;
            this.fontSize.Value = new decimal(new int[] { 12, 0, 0, 0 });
            this.fontSize.ValueChanged += new System.EventHandler(this.fontSize_ValueChanged);
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fontSizeLabel.Location = new System.Drawing.Point(12, 173);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(105, 20);
            this.fontSizeLabel.TabIndex = 5;
            this.fontSizeLabel.Text = "Font Size";
            this.fontSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paddingLabel
            // 
            this.paddingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingLabel.Location = new System.Drawing.Point(12, 225);
            this.paddingLabel.Name = "paddingLabel";
            this.paddingLabel.Size = new System.Drawing.Size(105, 20);
            this.paddingLabel.TabIndex = 6;
            this.paddingLabel.Text = "Padding";
            this.paddingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paddingLeft
            // 
            this.paddingLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingLeft.Location = new System.Drawing.Point(140, 225);
            this.paddingLeft.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.paddingLeft.Minimum = new decimal(new int[] { 999, 0, 0, -2147483648 });
            this.paddingLeft.Name = "paddingLeft";
            this.paddingLeft.Size = new System.Drawing.Size(53, 20);
            this.paddingLeft.TabIndex = 7;
            this.paddingLeft.ValueChanged += new System.EventHandler(this.paddingLeft_ValueChanged);
            // 
            // paddingRight
            // 
            this.paddingRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingRight.Location = new System.Drawing.Point(140, 251);
            this.paddingRight.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.paddingRight.Minimum = new decimal(new int[] { 999, 0, 0, -2147483648 });
            this.paddingRight.Name = "paddingRight";
            this.paddingRight.Size = new System.Drawing.Size(53, 20);
            this.paddingRight.TabIndex = 8;
            this.paddingRight.ValueChanged += new System.EventHandler(this.paddingRight_ValueChanged);
            // 
            // paddingLeftLabel
            // 
            this.paddingLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingLeftLabel.Location = new System.Drawing.Point(118, 225);
            this.paddingLeftLabel.Name = "paddingLeftLabel";
            this.paddingLeftLabel.Size = new System.Drawing.Size(16, 20);
            this.paddingLeftLabel.TabIndex = 9;
            this.paddingLeftLabel.Text = "L";
            this.paddingLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paddingRightLabel
            // 
            this.paddingRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingRightLabel.Location = new System.Drawing.Point(118, 251);
            this.paddingRightLabel.Name = "paddingRightLabel";
            this.paddingRightLabel.Size = new System.Drawing.Size(16, 20);
            this.paddingRightLabel.TabIndex = 10;
            this.paddingRightLabel.Text = "R";
            this.paddingRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paddingBottomLabel
            // 
            this.paddingBottomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingBottomLabel.Location = new System.Drawing.Point(193, 251);
            this.paddingBottomLabel.Name = "paddingBottomLabel";
            this.paddingBottomLabel.Size = new System.Drawing.Size(16, 20);
            this.paddingBottomLabel.TabIndex = 14;
            this.paddingBottomLabel.Text = "B";
            this.paddingBottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paddingTopLabel
            // 
            this.paddingTopLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingTopLabel.Location = new System.Drawing.Point(193, 225);
            this.paddingTopLabel.Name = "paddingTopLabel";
            this.paddingTopLabel.Size = new System.Drawing.Size(16, 20);
            this.paddingTopLabel.TabIndex = 13;
            this.paddingTopLabel.Text = "T";
            this.paddingTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paddingBottom
            // 
            this.paddingBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingBottom.Location = new System.Drawing.Point(215, 251);
            this.paddingBottom.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.paddingBottom.Minimum = new decimal(new int[] { 999, 0, 0, -2147483648 });
            this.paddingBottom.Name = "paddingBottom";
            this.paddingBottom.Size = new System.Drawing.Size(53, 20);
            this.paddingBottom.TabIndex = 12;
            this.paddingBottom.ValueChanged += new System.EventHandler(this.paddingBottom_ValueChanged);
            // 
            // paddingTop
            // 
            this.paddingTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingTop.Location = new System.Drawing.Point(215, 225);
            this.paddingTop.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            this.paddingTop.Minimum = new decimal(new int[] { 999, 0, 0, -2147483648 });
            this.paddingTop.Name = "paddingTop";
            this.paddingTop.Size = new System.Drawing.Size(53, 20);
            this.paddingTop.TabIndex = 11;
            this.paddingTop.ValueChanged += new System.EventHandler(this.paddingTop_ValueChanged);
            // 
            // textColourLabel
            // 
            this.textColourLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textColourLabel.Location = new System.Drawing.Point(12, 199);
            this.textColourLabel.Name = "textColourLabel";
            this.textColourLabel.Size = new System.Drawing.Size(105, 20);
            this.textColourLabel.TabIndex = 20;
            this.textColourLabel.Text = "Text Colour";
            this.textColourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textColour
            // 
            this.textColour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textColour.BackColor = System.Drawing.Color.White;
            this.textColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textColour.Location = new System.Drawing.Point(176, 199);
            this.textColour.Name = "textColour";
            this.textColour.Size = new System.Drawing.Size(92, 20);
            this.textColour.TabIndex = 21;
            // 
            // textColourHex
            // 
            this.textColourHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textColourHex.Location = new System.Drawing.Point(118, 199);
            this.textColourHex.Name = "textColourHex";
            this.textColourHex.Size = new System.Drawing.Size(52, 20);
            this.textColourHex.TabIndex = 22;
            this.textColourHex.Text = "#FFFFFF";
            this.textColourHex.TextChanged += new System.EventHandler(this.textColourHex_TextChanged);
            // 
            // saveImageButton
            // 
            this.saveImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveImageButton.Location = new System.Drawing.Point(311, 323);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(99, 29);
            this.saveImageButton.TabIndex = 23;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // preview
            // 
            this.preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.preview.Location = new System.Drawing.Point(311, 9);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(256, 200);
            this.preview.TabIndex = 24;
            this.preview.TabStop = false;
            // 
            // saveResults
            // 
            this.saveResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.saveResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.saveResults.Location = new System.Drawing.Point(416, 323);
            this.saveResults.Name = "saveResults";
            this.saveResults.Size = new System.Drawing.Size(151, 28);
            this.saveResults.TabIndex = 25;
            this.saveResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fontResults
            // 
            this.fontResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fontResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fontResults.Location = new System.Drawing.Point(117, 138);
            this.fontResults.Name = "fontResults";
            this.fontResults.Size = new System.Drawing.Size(151, 29);
            this.fontResults.TabIndex = 26;
            this.fontResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // credits
            // 
            this.credits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.credits.LinkArea = new System.Windows.Forms.LinkArea(47, 20);
            this.credits.Location = new System.Drawing.Point(12, 274);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(256, 78);
            this.credits.TabIndex = 28;
            this.credits.TabStop = true;
            this.credits.Text = "bitmap-writer (2024)\r\nCreated by Kimera Royal (https://kimera.world)\r\nSource avai" + "lable on GitHub, CC Copyleft";
            this.credits.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.credits.UseCompatibleTextRendering = true;
            this.credits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.credits_LinkClicked);
            // 
            // BitmapWriterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.fontResults);
            this.Controls.Add(this.saveResults);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.textColourHex);
            this.Controls.Add(this.textColour);
            this.Controls.Add(this.textColourLabel);
            this.Controls.Add(this.paddingBottomLabel);
            this.Controls.Add(this.paddingTopLabel);
            this.Controls.Add(this.paddingBottom);
            this.Controls.Add(this.paddingTop);
            this.Controls.Add(this.paddingRightLabel);
            this.Controls.Add(this.paddingLeftLabel);
            this.Controls.Add(this.paddingRight);
            this.Controls.Add(this.paddingLeft);
            this.Controls.Add(this.paddingLabel);
            this.Controls.Add(this.fontSizeLabel);
            this.Controls.Add(this.fontSize);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.loadFontButton);
            this.Controls.Add(this.userInput);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "BitmapWriterForm";
            this.Text = "Bitmap Writer";
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.LinkLabel credits;

        private System.Windows.Forms.Label fontResults;

        private System.Windows.Forms.Label saveResults;

        private System.Windows.Forms.PictureBox preview;

        private System.Windows.Forms.Button saveImageButton;

        private System.Windows.Forms.TextBox textColourHex;

        private System.Windows.Forms.Panel textColour;

        private System.Windows.Forms.Label textColourLabel;

        private System.Windows.Forms.Label testLabel;

        private System.Windows.Forms.Button loadFontButton;
        
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label fontSizeLabel;

        // <!-- Padding
        private System.Windows.Forms.Label paddingLabel;
        
        private System.Windows.Forms.NumericUpDown paddingLeft;
        private System.Windows.Forms.Label paddingLeftLabel;
        
        private System.Windows.Forms.NumericUpDown paddingRight;
        private System.Windows.Forms.Label paddingRightLabel;
        
        private System.Windows.Forms.NumericUpDown paddingTop;
        private System.Windows.Forms.Label paddingTopLabel;
        
        private System.Windows.Forms.NumericUpDown paddingBottom;
        private System.Windows.Forms.Label paddingBottomLabel;
        // Padding -->

        private System.Windows.Forms.RichTextBox userInput;

        #endregion
    }
}