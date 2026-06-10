namespace English_Learning_Management_System.Screens
{
    partial class frmAddMoreATransaltions
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
            this.btnaddTranslations = new EnhancedControls.EnhancedButton();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtA4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderlessFormAnimator1
            // 
            this.borderlessFormAnimator1.AnimateWindow = false;
            this.borderlessFormAnimator1.AnimationDuration = 400;
            this.borderlessFormAnimator1.CornerRadius = 20;
            this.borderlessFormAnimator1.Draggable = true;
            this.borderlessFormAnimator1.EntryAnimation = EnhancedControls.FormAnimationType.CenterZoomIn;
            this.borderlessFormAnimator1.EntryEasing = EnhancedControls.AnimationEasingType.EaseOut;
            this.borderlessFormAnimator1.ExitAnimation = EnhancedControls.FormAnimationType.CenterZoomOut;
            this.borderlessFormAnimator1.ExitEasing = EnhancedControls.AnimationEasingType.EaseIn;
            this.borderlessFormAnimator1.TargetForm = this;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.BorderSize = 1;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FocusColor = System.Drawing.SystemColors.Highlight;
            this.btnExit.Font = new System.Drawing.Font("Cairo", 37.25F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.GradientStartColor = System.Drawing.Color.Maroon;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnExit.Location = new System.Drawing.Point(1645, -12);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 147);
            this.btnExit.TabIndex = 16;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnaddTranslations
            // 
            this.btnaddTranslations.BackColor = System.Drawing.Color.Transparent;
            this.btnaddTranslations.BorderColor = System.Drawing.Color.Black;
            this.btnaddTranslations.BorderSize = 1;
            this.btnaddTranslations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddTranslations.FocusColor = System.Drawing.SystemColors.Highlight;
            this.btnaddTranslations.Font = new System.Drawing.Font("Cairo", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnaddTranslations.ForeColor = System.Drawing.Color.White;
            this.btnaddTranslations.GradientEndColor = System.Drawing.Color.DarkGreen;
            this.btnaddTranslations.GradientStartColor = System.Drawing.Color.LimeGreen;
            this.btnaddTranslations.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnaddTranslations.Location = new System.Drawing.Point(588, 1003);
            this.btnaddTranslations.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnaddTranslations.Name = "btnaddTranslations";
            this.btnaddTranslations.Size = new System.Drawing.Size(508, 142);
            this.btnaddTranslations.TabIndex = 15;
            this.btnaddTranslations.TabStop = false;
            this.btnaddTranslations.Text = "Add Translation/s";
            this.btnaddTranslations.UseVisualStyleBackColor = false;
            this.btnaddTranslations.Click += new System.EventHandler(this.btnaddTranslations_Click);
            // 
            // txtA3
            // 
            this.txtA3.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtA3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtA3.Location = new System.Drawing.Point(353, 437);
            this.txtA3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtA3.Multiline = true;
            this.txtA3.Name = "txtA3";
            this.txtA3.Size = new System.Drawing.Size(974, 138);
            this.txtA3.TabIndex = 14;
            this.txtA3.Tag = "A2";
            this.txtA3.Text = "Enter Arabic Translation 3";
            this.txtA3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA3.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtA3.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtA2
            // 
            this.txtA2.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtA2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtA2.Location = new System.Drawing.Point(353, 211);
            this.txtA2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtA2.Multiline = true;
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(974, 138);
            this.txtA2.TabIndex = 13;
            this.txtA2.Tag = "A1";
            this.txtA2.Text = "Enter Arabic Translation 2";
            this.txtA2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA2.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtA2.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtA4
            // 
            this.txtA4.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtA4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtA4.Location = new System.Drawing.Point(353, 663);
            this.txtA4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtA4.Multiline = true;
            this.txtA4.Name = "txtA4";
            this.txtA4.Size = new System.Drawing.Size(974, 138);
            this.txtA4.TabIndex = 17;
            this.txtA4.Tag = "A3";
            this.txtA4.Text = "Enter Arabic Translation 4";
            this.txtA4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtA4.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtA4.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.txtA4);
            this.panel1.Controls.Add(this.btnaddTranslations);
            this.panel1.Controls.Add(this.txtA3);
            this.panel1.Controls.Add(this.txtA2);
            this.panel1.Location = new System.Drawing.Point(42, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1725, 1210);
            this.panel1.TabIndex = 18;
            // 
            // frmAddMoreATransaltions
            // 
            this.AcceptButton = this.btnaddTranslations;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::English_Learning_Management_System.Properties.Resources.Whisk_464189a0601ec149fd841f6c137a8e2edr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1787, 1108);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmAddMoreATransaltions";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddMoreATransaltions_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EnhancedControls.BorderlessFormAnimator borderlessFormAnimator1;
        private System.Windows.Forms.TextBox txtA4;
        private EnhancedControls.EnhancedButton btnExit;
        private EnhancedControls.EnhancedButton btnaddTranslations;
        private System.Windows.Forms.TextBox txtA3;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.Panel panel1;
    }
}