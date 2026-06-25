namespace English_Learning_Management_System.Screens
{
    partial class frmLFFirstLoad
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar1 = new EnhancedControls.CircularProgressBar();
            this.lblTitle = new EnahncedControls.EnhancedLabel();
            this.borderlessFormAnimator1 = new EnhancedControls.BorderlessFormAnimator();
            this.lblDeveloperName = new EnahncedControls.EnhancedLabel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 65;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.EnableCenterText = false;
            this.circularProgressBar1.GradientDirection = EnhancedControls.GradientDirection.Horizontal;
            this.circularProgressBar1.GradientEndColor = System.Drawing.Color.Gold;
            this.circularProgressBar1.GradientStartColor = System.Drawing.Color.DarkOrchid;
            this.circularProgressBar1.Location = new System.Drawing.Point(697, 102);
            this.circularProgressBar1.MaximumValue = 0;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.Size = new System.Drawing.Size(194, 194);
            this.circularProgressBar1.TabIndex = 2;
            this.circularProgressBar1.Text = "circularProgressBar1";
            this.circularProgressBar1.Thickness = 20;
            this.circularProgressBar1.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.EnableAutoSize = false;
            this.lblTitle.FocusEffect = false;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 32F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTitle.GlowEffect = false;
            this.lblTitle.GradientDirection = EnahncedControls.EnhancedLabel.GradientDirectionMode.Vertical;
            this.lblTitle.GradientEndColor = System.Drawing.Color.Indigo;
            this.lblTitle.GradientStartColor = System.Drawing.Color.Purple;
            this.lblTitle.HoverEffect = false;
            this.lblTitle.Location = new System.Drawing.Point(-1, 367);
            this.lblTitle.MouseDownEffect = false;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(3);
            this.lblTitle.Radius = 10;
            this.lblTitle.ScaleEffect = true;
            this.lblTitle.ScaleFactor = 1.1F;
            this.lblTitle.Size = new System.Drawing.Size(1021, 137);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "English Learning Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.UseGradient = true;
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
            // lblDeveloperName
            // 
            this.lblDeveloperName.BackColor = System.Drawing.Color.Transparent;
            this.lblDeveloperName.EnableAutoSize = false;
            this.lblDeveloperName.FocusEffect = false;
            this.lblDeveloperName.Font = new System.Drawing.Font("Arial Narrow", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloperName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblDeveloperName.GlowEffect = false;
            this.lblDeveloperName.GradientDirection = EnahncedControls.EnhancedLabel.GradientDirectionMode.Vertical;
            this.lblDeveloperName.GradientEndColor = System.Drawing.Color.Indigo;
            this.lblDeveloperName.GradientStartColor = System.Drawing.Color.Purple;
            this.lblDeveloperName.HoverEffect = false;
            this.lblDeveloperName.Location = new System.Drawing.Point(-12, -5);
            this.lblDeveloperName.MouseDownEffect = false;
            this.lblDeveloperName.Name = "lblDeveloperName";
            this.lblDeveloperName.Padding = new System.Windows.Forms.Padding(3);
            this.lblDeveloperName.Radius = 15;
            this.lblDeveloperName.ScaleEffect = true;
            this.lblDeveloperName.ScaleFactor = 1.1F;
            this.lblDeveloperName.Size = new System.Drawing.Size(614, 92);
            this.lblDeveloperName.TabIndex = 3;
            this.lblDeveloperName.Text = "Developed By :  Abdulghani Al-Hamwi";
            this.lblDeveloperName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDeveloperName.UseGradient = true;
            // 
            // frmLFFirstLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::English_Learning_Management_System.Properties.Resources.Whisk_5f815065315d09592be4f3ec4ab8d974eg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1012, 498);
            this.Controls.Add(this.lblDeveloperName);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmLFFirstLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "–";
            this.Load += new System.EventHandler(this.frm_Load);
            this.Shown += new System.EventHandler(this.frm_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private EnhancedControls.BorderlessFormAnimator borderlessFormAnimator1;
        private EnahncedControls.EnhancedLabel lblTitle;
        private EnhancedControls.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private EnahncedControls.EnhancedLabel lblDeveloperName;
    }
}