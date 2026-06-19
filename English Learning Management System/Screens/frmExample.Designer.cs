namespace English_Learning_Management_System.Screens
{
    partial class frmExample
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
            this.borderlessFormAnimator1 = new EnhancedControls.BorderlessFormAnimator();
            this.btnExit = new EnhancedControls.EnhancedButton();
            this.btnAddTranslations = new EnhancedControls.EnhancedButton();
            this.txtArabicExample1 = new System.Windows.Forms.TextBox();
            this.txtBoxEnglishExample1 = new System.Windows.Forms.TextBox();
            this.txtBoxEnglishExample3 = new System.Windows.Forms.TextBox();
            this.txtBoxEnglishExample4 = new System.Windows.Forms.TextBox();
            this.txtBoxEnglishExample2 = new System.Windows.Forms.TextBox();
            this.txtArabicExample2 = new System.Windows.Forms.TextBox();
            this.txtArabicExample3 = new System.Windows.Forms.TextBox();
            this.txtArabicExample4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderlessFormAnimator1
            // 
            this.borderlessFormAnimator1.AnimateWindow = false;
            this.borderlessFormAnimator1.AnimationDuration = 400;
            this.borderlessFormAnimator1.CornerRadius = 80;
            this.borderlessFormAnimator1.Draggable = true;
            this.borderlessFormAnimator1.EntryAnimation = EnhancedControls.FormAnimationType.CenterZoomIn;
            this.borderlessFormAnimator1.EntryEasing = EnhancedControls.AnimationEasingType.EaseOut;
            this.borderlessFormAnimator1.ExitAnimation = EnhancedControls.FormAnimationType.CenterZoomOut;
            this.borderlessFormAnimator1.ExitEasing = EnhancedControls.AnimationEasingType.EaseIn;
            this.borderlessFormAnimator1.TargetForm = this;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.BorderRadius = 10;
            this.btnExit.BorderSize = 1;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FocusColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Cairo", 37.25F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.GradientStartColor = System.Drawing.Color.Maroon;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnExit.Location = new System.Drawing.Point(1045, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 75);
            this.btnExit.TabIndex = 9;
            this.btnExit.TabStop = false;
            this.btnExit.Text = " X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddTranslations
            // 
            this.btnAddTranslations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddTranslations.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTranslations.BorderColor = System.Drawing.Color.Black;
            this.btnAddTranslations.BorderSize = 1;
            this.btnAddTranslations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTranslations.FocusColor = System.Drawing.SystemColors.Highlight;
            this.btnAddTranslations.Font = new System.Drawing.Font("Cairo", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddTranslations.ForeColor = System.Drawing.Color.White;
            this.btnAddTranslations.GradientEndColor = System.Drawing.Color.DarkGreen;
            this.btnAddTranslations.GradientStartColor = System.Drawing.Color.LimeGreen;
            this.btnAddTranslations.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnAddTranslations.Location = new System.Drawing.Point(410, 647);
            this.btnAddTranslations.Name = "btnAddTranslations";
            this.btnAddTranslations.Size = new System.Drawing.Size(285, 77);
            this.btnAddTranslations.TabIndex = 8;
            this.btnAddTranslations.TabStop = false;
            this.btnAddTranslations.Text = "Add Translation/s";
            this.btnAddTranslations.UseVisualStyleBackColor = false;
            this.btnAddTranslations.Click += new System.EventHandler(this.btnAddTranslations_Click);
            // 
            // txtArabicExample1
            // 
            this.txtArabicExample1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtArabicExample1.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtArabicExample1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtArabicExample1.Location = new System.Drawing.Point(613, 141);
            this.txtArabicExample1.Multiline = true;
            this.txtArabicExample1.Name = "txtArabicExample1";
            this.txtArabicExample1.Size = new System.Drawing.Size(513, 72);
            this.txtArabicExample1.TabIndex = 1;
            this.txtArabicExample1.Tag = "E1";
            this.txtArabicExample1.Text = "Enter Translation For Example 1";
            this.txtArabicExample1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArabicExample1.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtArabicExample1.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtBoxEnglishExample1
            // 
            this.txtBoxEnglishExample1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxEnglishExample1.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEnglishExample1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBoxEnglishExample1.Location = new System.Drawing.Point(3, 141);
            this.txtBoxEnglishExample1.Multiline = true;
            this.txtBoxEnglishExample1.Name = "txtBoxEnglishExample1";
            this.txtBoxEnglishExample1.Size = new System.Drawing.Size(513, 72);
            this.txtBoxEnglishExample1.TabIndex = 0;
            this.txtBoxEnglishExample1.Tag = "A1";
            this.txtBoxEnglishExample1.Text = "Enter Example For English Word 1";
            this.txtBoxEnglishExample1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEnglishExample1.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxEnglishExample1.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtBoxEnglishExample3
            // 
            this.txtBoxEnglishExample3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxEnglishExample3.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEnglishExample3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBoxEnglishExample3.Location = new System.Drawing.Point(3, 399);
            this.txtBoxEnglishExample3.Multiline = true;
            this.txtBoxEnglishExample3.Name = "txtBoxEnglishExample3";
            this.txtBoxEnglishExample3.Size = new System.Drawing.Size(513, 72);
            this.txtBoxEnglishExample3.TabIndex = 4;
            this.txtBoxEnglishExample3.Tag = "A3";
            this.txtBoxEnglishExample3.Text = "Enter Example For English Word 3";
            this.txtBoxEnglishExample3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEnglishExample3.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxEnglishExample3.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtBoxEnglishExample4
            // 
            this.txtBoxEnglishExample4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxEnglishExample4.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEnglishExample4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBoxEnglishExample4.Location = new System.Drawing.Point(3, 528);
            this.txtBoxEnglishExample4.Multiline = true;
            this.txtBoxEnglishExample4.Name = "txtBoxEnglishExample4";
            this.txtBoxEnglishExample4.Size = new System.Drawing.Size(513, 72);
            this.txtBoxEnglishExample4.TabIndex = 6;
            this.txtBoxEnglishExample4.Tag = "A4";
            this.txtBoxEnglishExample4.Text = "Enter Example For English Word 4";
            this.txtBoxEnglishExample4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEnglishExample4.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxEnglishExample4.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtBoxEnglishExample2
            // 
            this.txtBoxEnglishExample2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxEnglishExample2.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEnglishExample2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBoxEnglishExample2.Location = new System.Drawing.Point(3, 270);
            this.txtBoxEnglishExample2.Multiline = true;
            this.txtBoxEnglishExample2.Name = "txtBoxEnglishExample2";
            this.txtBoxEnglishExample2.Size = new System.Drawing.Size(513, 72);
            this.txtBoxEnglishExample2.TabIndex = 2;
            this.txtBoxEnglishExample2.Tag = "A2";
            this.txtBoxEnglishExample2.Text = "Enter Example For English Word 2";
            this.txtBoxEnglishExample2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEnglishExample2.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxEnglishExample2.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtArabicExample2
            // 
            this.txtArabicExample2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtArabicExample2.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtArabicExample2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtArabicExample2.Location = new System.Drawing.Point(613, 270);
            this.txtArabicExample2.Multiline = true;
            this.txtArabicExample2.Name = "txtArabicExample2";
            this.txtArabicExample2.Size = new System.Drawing.Size(513, 72);
            this.txtArabicExample2.TabIndex = 3;
            this.txtArabicExample2.Tag = "E2";
            this.txtArabicExample2.Text = "Enter Translation For Example 2";
            this.txtArabicExample2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArabicExample2.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtArabicExample2.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtArabicExample3
            // 
            this.txtArabicExample3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtArabicExample3.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtArabicExample3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtArabicExample3.Location = new System.Drawing.Point(613, 399);
            this.txtArabicExample3.Multiline = true;
            this.txtArabicExample3.Name = "txtArabicExample3";
            this.txtArabicExample3.Size = new System.Drawing.Size(513, 72);
            this.txtArabicExample3.TabIndex = 5;
            this.txtArabicExample3.Tag = "E3";
            this.txtArabicExample3.Text = "Enter Translation For Example 3";
            this.txtArabicExample3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArabicExample3.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtArabicExample3.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtArabicExample4
            // 
            this.txtArabicExample4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtArabicExample4.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtArabicExample4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtArabicExample4.Location = new System.Drawing.Point(613, 528);
            this.txtArabicExample4.Multiline = true;
            this.txtArabicExample4.Name = "txtArabicExample4";
            this.txtArabicExample4.Size = new System.Drawing.Size(513, 72);
            this.txtArabicExample4.TabIndex = 7;
            this.txtArabicExample4.Tag = "E4";
            this.txtArabicExample4.Text = "Enter Translation For Example 4";
            this.txtArabicExample4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArabicExample4.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtArabicExample4.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtArabicExample4);
            this.panel1.Controls.Add(this.txtArabicExample3);
            this.panel1.Controls.Add(this.txtArabicExample2);
            this.panel1.Controls.Add(this.txtBoxEnglishExample2);
            this.panel1.Controls.Add(this.txtBoxEnglishExample4);
            this.panel1.Controls.Add(this.txtBoxEnglishExample3);
            this.panel1.Controls.Add(this.btnAddTranslations);
            this.panel1.Controls.Add(this.txtArabicExample1);
            this.panel1.Controls.Add(this.txtBoxEnglishExample1);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 752);
            this.panel1.TabIndex = 10;
            // 
            // frmExample
            // 
            this.AcceptButton = this.btnAddTranslations;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackgroundImage = global::English_Learning_Management_System.Properties.Resources.Whisk_464189a0601ec149fd841f6c137a8e2edr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1197, 781);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmExample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExample";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExample_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EnhancedControls.BorderlessFormAnimator borderlessFormAnimator1;
        private EnhancedControls.EnhancedButton btnExit;
        private EnhancedControls.EnhancedButton btnAddTranslations;
        private System.Windows.Forms.TextBox txtArabicExample1;
        private System.Windows.Forms.TextBox txtBoxEnglishExample1;
        private System.Windows.Forms.TextBox txtArabicExample4;
        private System.Windows.Forms.TextBox txtArabicExample3;
        private System.Windows.Forms.TextBox txtArabicExample2;
        private System.Windows.Forms.TextBox txtBoxEnglishExample2;
        private System.Windows.Forms.TextBox txtBoxEnglishExample4;
        private System.Windows.Forms.TextBox txtBoxEnglishExample3;
        private System.Windows.Forms.Panel panel1;
    }
}