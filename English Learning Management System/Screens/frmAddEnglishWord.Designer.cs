namespace English_Learning_Management_System.Screens
{
    partial class frmAddEnglishWord
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
            this.components = new System.ComponentModel.Container();
            this.borderlessFormAnimator1 = new EnhancedControls.BorderlessFormAnimator();
            this.txtBoxEnglishWord = new System.Windows.Forms.TextBox();
            this.txtArabicWord = new System.Windows.Forms.TextBox();
            this.btngAddMoreTranslations = new EnhancedControls.EnhancedButton();
            this.btnAddWord = new EnhancedControls.EnhancedButton();
            this.btnExit = new EnhancedControls.EnhancedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txterrorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txterrorprovider)).BeginInit();
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
            // txtBoxEnglishWord
            // 
            this.txtBoxEnglishWord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBoxEnglishWord.Font = new System.Drawing.Font("Cairo", 37F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEnglishWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBoxEnglishWord.Location = new System.Drawing.Point(169, 121);
            this.txtBoxEnglishWord.Multiline = true;
            this.txtBoxEnglishWord.Name = "txtBoxEnglishWord";
            this.txtBoxEnglishWord.Size = new System.Drawing.Size(485, 76);
            this.txtBoxEnglishWord.TabIndex = 0;
            this.txtBoxEnglishWord.Tag = "E";
            this.txtBoxEnglishWord.Text = "Enter English Word";
            this.txtBoxEnglishWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEnglishWord.Enter += new System.EventHandler(this.txtWord_Enter);
            this.txtBoxEnglishWord.Leave += new System.EventHandler(this.txtWordLeave);
            this.txtBoxEnglishWord.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxWord_Validating);
            // 
            // txtArabicWord
            // 
            this.txtArabicWord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtArabicWord.Font = new System.Drawing.Font("Cairo", 37F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtArabicWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtArabicWord.Location = new System.Drawing.Point(169, 234);
            this.txtArabicWord.Multiline = true;
            this.txtArabicWord.Name = "txtArabicWord";
            this.txtArabicWord.Size = new System.Drawing.Size(485, 76);
            this.txtArabicWord.TabIndex = 1;
            this.txtArabicWord.Tag = "A";
            this.txtArabicWord.Text = "Enter Arabic Translation";
            this.txtArabicWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArabicWord.Enter += new System.EventHandler(this.txtWord_Enter);
            this.txtArabicWord.Leave += new System.EventHandler(this.txtWordLeave);
            this.txtArabicWord.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxWord_Validating);
            // 
            // btngAddMoreTranslations
            // 
            this.btngAddMoreTranslations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btngAddMoreTranslations.BackColor = System.Drawing.Color.Transparent;
            this.btngAddMoreTranslations.BorderColor = System.Drawing.Color.Black;
            this.btngAddMoreTranslations.BorderSize = 1;
            this.btngAddMoreTranslations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngAddMoreTranslations.FocusColor = System.Drawing.SystemColors.Highlight;
            this.btngAddMoreTranslations.Font = new System.Drawing.Font("Cairo", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btngAddMoreTranslations.ForeColor = System.Drawing.Color.White;
            this.btngAddMoreTranslations.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(209)))));
            this.btngAddMoreTranslations.GradientStartColor = System.Drawing.Color.Purple;
            this.btngAddMoreTranslations.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btngAddMoreTranslations.Location = new System.Drawing.Point(169, 360);
            this.btngAddMoreTranslations.Name = "btngAddMoreTranslations";
            this.btngAddMoreTranslations.Size = new System.Drawing.Size(485, 80);
            this.btngAddMoreTranslations.TabIndex = 2;
            this.btngAddMoreTranslations.Text = "More Translations";
            this.btngAddMoreTranslations.UseVisualStyleBackColor = false;
            this.btngAddMoreTranslations.Click += new System.EventHandler(this.btngAddMoreTranslations_Click);
            // 
            // btnAddWord
            // 
            this.btnAddWord.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddWord.BackColor = System.Drawing.Color.Transparent;
            this.btnAddWord.BorderColor = System.Drawing.Color.Black;
            this.btnAddWord.BorderSize = 1;
            this.btnAddWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWord.FocusColor = System.Drawing.Color.DarkGreen;
            this.btnAddWord.Font = new System.Drawing.Font("Cairo", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddWord.ForeColor = System.Drawing.Color.White;
            this.btnAddWord.GradientEndColor = System.Drawing.Color.DarkGreen;
            this.btnAddWord.GradientStartColor = System.Drawing.Color.LimeGreen;
            this.btnAddWord.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnAddWord.Location = new System.Drawing.Point(308, 479);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(201, 75);
            this.btnAddWord.TabIndex = 3;
            this.btnAddWord.Text = "Add  Word";
            this.btnAddWord.UseVisualStyleBackColor = false;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
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
            this.btnExit.FocusColor = System.Drawing.Color.IndianRed;
            this.btnExit.Font = new System.Drawing.Font("Cairo", 37.25F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.GradientStartColor = System.Drawing.Color.Maroon;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnExit.Location = new System.Drawing.Point(776, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 73);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = " X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAddWord);
            this.panel1.Controls.Add(this.btngAddMoreTranslations);
            this.panel1.Controls.Add(this.txtArabicWord);
            this.panel1.Controls.Add(this.txtBoxEnglishWord);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 574);
            this.panel1.TabIndex = 13;
            // 
            // txterrorprovider
            // 
            this.txterrorprovider.ContainerControl = this;
            // 
            // frmAddEnglishWord
            // 
            this.AcceptButton = this.btnAddWord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackgroundImage = global::English_Learning_Management_System.Properties.Resources.Whisk_464189a0601ec149fd841f6c137a8e2edr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(867, 593);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmAddEnglishWord";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAddEnglishWord_Load);
            this.Shown += new System.EventHandler(this.frmAddEnglishWord_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txterrorprovider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EnhancedControls.BorderlessFormAnimator borderlessFormAnimator1;
        private System.Windows.Forms.TextBox txtArabicWord;
        private System.Windows.Forms.TextBox txtBoxEnglishWord;
        private EnhancedControls.EnhancedButton btngAddMoreTranslations;
        private EnhancedControls.EnhancedButton btnAddWord;
        private EnhancedControls.EnhancedButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider txterrorprovider;
    }
}