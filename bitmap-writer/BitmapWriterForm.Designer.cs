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
            this.characterSpacingLabel = new System.Windows.Forms.Label();
            this.lineSpacingLabel = new System.Windows.Forms.Label();
            this.characterSpacing = new System.Windows.Forms.NumericUpDown();
            this.lineSpacing = new System.Windows.Forms.NumericUpDown();
            this.textColourLabel = new System.Windows.Forms.Label();
            this.textColour = new System.Windows.Forms.Panel();
            this.textColourHex = new System.Windows.Forms.TextBox();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.AccessibleDescription = "Text entered in this field will be used to generate the sprite.";
            this.userInput.AccessibleName = "User Input";
            this.userInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(311, 191);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(256, 101);
            this.userInput.TabIndex = 0;
            this.userInput.Text = "Insert text";
            this.userInput.TextChanged += new System.EventHandler(this.userInput_TextChanged);
            // 
            // loadFontButton
            // 
            this.loadFontButton.Location = new System.Drawing.Point(12, 113);
            this.loadFontButton.Name = "loadFontButton";
            this.loadFontButton.Size = new System.Drawing.Size(99, 29);
            this.loadFontButton.TabIndex = 2;
            this.loadFontButton.Text = "Load Font";
            this.loadFontButton.UseVisualStyleBackColor = true;
            this.loadFontButton.Click += new System.EventHandler(this.loadFontButton_Click);
            // 
            // testLabel
            // 
            this.testLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.testLabel.Location = new System.Drawing.Point(12, 9);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(256, 101);
            this.testLabel.TabIndex = 3;
            this.testLabel.Text = "No Font Loaded";
            this.testLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // fontSize
            // 
            this.fontSize.Location = new System.Drawing.Point(118, 148);
            this.fontSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(150, 20);
            this.fontSize.TabIndex = 4;
            this.fontSize.Value = new decimal(new int[] { 12, 0, 0, 0 });
            this.fontSize.ValueChanged += new System.EventHandler(this.fontSize_ValueChanged);
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.Location = new System.Drawing.Point(12, 148);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(105, 20);
            this.fontSizeLabel.TabIndex = 5;
            this.fontSizeLabel.Text = "Font Size";
            this.fontSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paddingLabel
            // 
            this.paddingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingLabel.Location = new System.Drawing.Point(12, 229);
            this.paddingLabel.Name = "paddingLabel";
            this.paddingLabel.Size = new System.Drawing.Size(105, 20);
            this.paddingLabel.TabIndex = 6;
            this.paddingLabel.Text = "Padding";
            this.paddingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paddingLeft
            // 
            this.paddingLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingLeft.Location = new System.Drawing.Point(140, 229);
            this.paddingLeft.Name = "paddingLeft";
            this.paddingLeft.Size = new System.Drawing.Size(53, 20);
            this.paddingLeft.TabIndex = 7;
            this.paddingLeft.ValueChanged += new System.EventHandler(this.paddingLeft_ValueChanged);
            // 
            // paddingRight
            // 
            this.paddingRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingRight.Location = new System.Drawing.Point(140, 255);
            this.paddingRight.Name = "paddingRight";
            this.paddingRight.Size = new System.Drawing.Size(53, 20);
            this.paddingRight.TabIndex = 8;
            this.paddingRight.ValueChanged += new System.EventHandler(this.paddingRight_ValueChanged);
            // 
            // paddingLeftLabel
            // 
            this.paddingLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingLeftLabel.Location = new System.Drawing.Point(118, 229);
            this.paddingLeftLabel.Name = "paddingLeftLabel";
            this.paddingLeftLabel.Size = new System.Drawing.Size(16, 20);
            this.paddingLeftLabel.TabIndex = 9;
            this.paddingLeftLabel.Text = "L";
            this.paddingLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paddingRightLabel
            // 
            this.paddingRightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingRightLabel.Location = new System.Drawing.Point(118, 255);
            this.paddingRightLabel.Name = "paddingRightLabel";
            this.paddingRightLabel.Size = new System.Drawing.Size(16, 20);
            this.paddingRightLabel.TabIndex = 10;
            this.paddingRightLabel.Text = "R";
            this.paddingRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paddingBottomLabel
            // 
            this.paddingBottomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingBottomLabel.Location = new System.Drawing.Point(193, 255);
            this.paddingBottomLabel.Name = "paddingBottomLabel";
            this.paddingBottomLabel.Size = new System.Drawing.Size(16, 20);
            this.paddingBottomLabel.TabIndex = 14;
            this.paddingBottomLabel.Text = "B";
            this.paddingBottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paddingTopLabel
            // 
            this.paddingTopLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingTopLabel.Location = new System.Drawing.Point(193, 229);
            this.paddingTopLabel.Name = "paddingTopLabel";
            this.paddingTopLabel.Size = new System.Drawing.Size(16, 20);
            this.paddingTopLabel.TabIndex = 13;
            this.paddingTopLabel.Text = "T";
            this.paddingTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paddingBottom
            // 
            this.paddingBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingBottom.Location = new System.Drawing.Point(215, 255);
            this.paddingBottom.Name = "paddingBottom";
            this.paddingBottom.Size = new System.Drawing.Size(53, 20);
            this.paddingBottom.TabIndex = 12;
            this.paddingBottom.ValueChanged += new System.EventHandler(this.paddingBottom_ValueChanged);
            // 
            // paddingTop
            // 
            this.paddingTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.paddingTop.Location = new System.Drawing.Point(215, 229);
            this.paddingTop.Name = "paddingTop";
            this.paddingTop.Size = new System.Drawing.Size(53, 20);
            this.paddingTop.TabIndex = 11;
            this.paddingTop.ValueChanged += new System.EventHandler(this.paddingTop_ValueChanged);
            // 
            // characterSpacingLabel
            // 
            this.characterSpacingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.characterSpacingLabel.Location = new System.Drawing.Point(12, 281);
            this.characterSpacingLabel.Name = "characterSpacingLabel";
            this.characterSpacingLabel.Size = new System.Drawing.Size(105, 20);
            this.characterSpacingLabel.TabIndex = 15;
            this.characterSpacingLabel.Text = "Character Spacing";
            this.characterSpacingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lineSpacingLabel
            // 
            this.lineSpacingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lineSpacingLabel.Location = new System.Drawing.Point(12, 307);
            this.lineSpacingLabel.Name = "lineSpacingLabel";
            this.lineSpacingLabel.Size = new System.Drawing.Size(105, 20);
            this.lineSpacingLabel.TabIndex = 16;
            this.lineSpacingLabel.Text = "Line Spacing";
            this.lineSpacingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // characterSpacing
            // 
            this.characterSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.characterSpacing.Location = new System.Drawing.Point(118, 281);
            this.characterSpacing.Name = "characterSpacing";
            this.characterSpacing.Size = new System.Drawing.Size(150, 20);
            this.characterSpacing.TabIndex = 17;
            this.characterSpacing.ValueChanged += new System.EventHandler(this.characterSpacing_ValueChanged);
            // 
            // lineSpacing
            // 
            this.lineSpacing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lineSpacing.Location = new System.Drawing.Point(118, 307);
            this.lineSpacing.Name = "lineSpacing";
            this.lineSpacing.Size = new System.Drawing.Size(150, 20);
            this.lineSpacing.TabIndex = 18;
            this.lineSpacing.ValueChanged += new System.EventHandler(this.lineSpacing_ValueChanged);
            // 
            // textColourLabel
            // 
            this.textColourLabel.Location = new System.Drawing.Point(12, 174);
            this.textColourLabel.Name = "textColourLabel";
            this.textColourLabel.Size = new System.Drawing.Size(105, 20);
            this.textColourLabel.TabIndex = 20;
            this.textColourLabel.Text = "Text Colour";
            this.textColourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textColour
            // 
            this.textColour.BackColor = System.Drawing.Color.White;
            this.textColour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.textColour.Location = new System.Drawing.Point(176, 174);
            this.textColour.Name = "textColour";
            this.textColour.Size = new System.Drawing.Size(92, 20);
            this.textColour.TabIndex = 21;
            // 
            // textColourHex
            // 
            this.textColourHex.Location = new System.Drawing.Point(118, 174);
            this.textColourHex.Name = "textColourHex";
            this.textColourHex.Size = new System.Drawing.Size(52, 20);
            this.textColourHex.TabIndex = 22;
            this.textColourHex.Text = "#FFFFFF";
            this.textColourHex.TextChanged += new System.EventHandler(this.textColourHex_TextChanged);
            // 
            // saveImageButton
            // 
            this.saveImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveImageButton.Location = new System.Drawing.Point(311, 298);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(99, 29);
            this.saveImageButton.TabIndex = 23;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // preview
            // 
            this.preview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.preview.Location = new System.Drawing.Point(311, 9);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(256, 176);
            this.preview.TabIndex = 24;
            this.preview.TabStop = false;
            // 
            // BitmapWriterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 336);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.textColourHex);
            this.Controls.Add(this.textColour);
            this.Controls.Add(this.textColourLabel);
            this.Controls.Add(this.lineSpacing);
            this.Controls.Add(this.characterSpacing);
            this.Controls.Add(this.lineSpacingLabel);
            this.Controls.Add(this.characterSpacingLabel);
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
            this.Name = "BitmapWriterForm";
            this.Text = "Bitmap Writer";
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddingTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox preview;

        private System.Windows.Forms.Button saveImageButton;

        private System.Windows.Forms.TextBox textColourHex;

        private System.Windows.Forms.Panel textColour;

        private System.Windows.Forms.Label textColourLabel;

        private System.Windows.Forms.Label testLabel;

        private System.Windows.Forms.Button loadFontButton;
        
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label fontSizeLabel;

        private System.Windows.Forms.Label characterSpacingLabel;
        private System.Windows.Forms.NumericUpDown characterSpacing;
        
        private System.Windows.Forms.Label lineSpacingLabel;
        private System.Windows.Forms.NumericUpDown lineSpacing;

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