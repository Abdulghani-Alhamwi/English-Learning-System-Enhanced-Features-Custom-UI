namespace English_Learning_Management_System
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.lstvWords = new System.Windows.Forms.ListView();
            this.colEnglishWords = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArabicTranslation1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArabicTranslation2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArabicTranslation3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colArabicTranslation4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WordsListViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteAllWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeVoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftDavidDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.microsoftZiraDesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hayleyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBCHazelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herenaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iNHeeraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daDKvHelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esHelenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esMXYHildaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiHeidiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frFRYHortenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jaHarukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kokrKRreAMiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nbnoHuldaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nbNOHuldaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rUElenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plPLPaulinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptHeliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zhHKHKHunYeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zhTvVHanHanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllWordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unCheckSelectedWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSystemVolume = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ESpeakSelectedWords = new EnhancedControls.EnhancedButton();
            this.makeAnyPartOfFormDraggable1 = new EnhancedControls.MakeAnyPartOfFormDraggable();
            this.btnAddENGWords = new EnhancedControls.EnhancedButton();
            this.btnExit = new EnhancedControls.EnhancedButton();
            this.lblTotalWords = new EnahncedControls.EnhancedLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uncheckAllWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordsListViewContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvWords
            // 
            this.lstvWords.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstvWords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lstvWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstvWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEnglishWords,
            this.colArabicTranslation1,
            this.colArabicTranslation2,
            this.colArabicTranslation3,
            this.colArabicTranslation4});
            this.lstvWords.ContextMenuStrip = this.WordsListViewContextMenu;
            this.lstvWords.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lstvWords.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstvWords.GridLines = true;
            this.lstvWords.HideSelection = false;
            this.lstvWords.Location = new System.Drawing.Point(27, 193);
            this.lstvWords.Name = "lstvWords";
            this.lstvWords.ShowItemToolTips = true;
            this.lstvWords.Size = new System.Drawing.Size(1773, 625);
            this.lstvWords.TabIndex = 0;
            this.lstvWords.TileSize = new System.Drawing.Size(5, 5);
            this.lstvWords.UseCompatibleStateImageBehavior = false;
            this.lstvWords.View = System.Windows.Forms.View.Details;
            this.lstvWords.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.lstvWords_ItemMouseHover);
            // 
            // colEnglishWords
            // 
            this.colEnglishWords.Text = "English Words";
            this.colEnglishWords.Width = 311;
            // 
            // colArabicTranslation1
            // 
            this.colArabicTranslation1.Text = "Arabic Translation 1";
            this.colArabicTranslation1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colArabicTranslation1.Width = 342;
            // 
            // colArabicTranslation2
            // 
            this.colArabicTranslation2.Text = "Arabic Translation 2";
            this.colArabicTranslation2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colArabicTranslation2.Width = 335;
            // 
            // colArabicTranslation3
            // 
            this.colArabicTranslation3.Text = "Arabic Translation 3";
            this.colArabicTranslation3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colArabicTranslation3.Width = 340;
            // 
            // colArabicTranslation4
            // 
            this.colArabicTranslation4.Text = "Arabic Translation 4";
            this.colArabicTranslation4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colArabicTranslation4.Width = 500;
            // 
            // WordsListViewContextMenu
            // 
            this.WordsListViewContextMenu.Font = new System.Drawing.Font("Cairo", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WordsListViewContextMenu.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.WordsListViewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteAllWordsToolStripMenuItem,
            this.changeVoiceToolStripMenuItem,
            this.editWordToolStripMenuItem,
            this.deleteWordToolStripMenuItem,
            this.listViewToolStripMenuItem,
            this.deleteAllWordsToolStripMenuItem1,
            this.unCheckSelectedWordsToolStripMenuItem,
            this.uncheckAllWordsToolStripMenuItem});
            this.WordsListViewContextMenu.Name = "WordsListViewContextMenu";
            this.WordsListViewContextMenu.Size = new System.Drawing.Size(357, 372);
            // 
            // deleteAllWordsToolStripMenuItem
            // 
            this.deleteAllWordsToolStripMenuItem.Name = "deleteAllWordsToolStripMenuItem";
            this.deleteAllWordsToolStripMenuItem.Size = new System.Drawing.Size(356, 46);
            this.deleteAllWordsToolStripMenuItem.Text = "Check Selected Words";
            this.deleteAllWordsToolStripMenuItem.Click += new System.EventHandler(this.CheckAllWordsToolStripMenuItem_Click);
            // 
            // changeVoiceToolStripMenuItem
            // 
            this.changeVoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.microsoftDavidDesktopToolStripMenuItem,
            this.microsoftZiraDesktopToolStripMenuItem,
            this.herenaToolStripMenuItem,
            this.hayleyToolStripMenuItem,
            this.gBCHazelToolStripMenuItem,
            this.herenaToolStripMenuItem1,
            this.iNHeeraToolStripMenuItem,
            this.daDKvHelleToolStripMenuItem,
            this.esHelenaToolStripMenuItem,
            this.esMXYHildaToolStripMenuItem,
            this.fiHeidiToolStripMenuItem,
            this.frFRYHortenseToolStripMenuItem,
            this.jaHarukaToolStripMenuItem,
            this.kokrKRreAMiToolStripMenuItem,
            this.nbnoHuldaToolStripMenuItem,
            this.nbNOHuldaToolStripMenuItem1,
            this.rUElenaToolStripMenuItem,
            this.plPLPaulinaToolStripMenuItem,
            this.ptHeliaToolStripMenuItem,
            this.zhHKHKHunYeeToolStripMenuItem,
            this.zhTvVHanHanToolStripMenuItem});
            this.changeVoiceToolStripMenuItem.Name = "changeVoiceToolStripMenuItem";
            this.changeVoiceToolStripMenuItem.Size = new System.Drawing.Size(356, 46);
            this.changeVoiceToolStripMenuItem.Text = "Change Voice";
            // 
            // microsoftDavidDesktopToolStripMenuItem
            // 
            this.microsoftDavidDesktopToolStripMenuItem.CheckOnClick = true;
            this.microsoftDavidDesktopToolStripMenuItem.Name = "microsoftDavidDesktopToolStripMenuItem";
            this.microsoftDavidDesktopToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.microsoftDavidDesktopToolStripMenuItem.Text = "Microsoft David Desktop";
            this.microsoftDavidDesktopToolStripMenuItem.Click += new System.EventHandler(this.microsoftDavidDesktopToolStripMenuItem_Click);
            // 
            // microsoftZiraDesktopToolStripMenuItem
            // 
            this.microsoftZiraDesktopToolStripMenuItem.Checked = true;
            this.microsoftZiraDesktopToolStripMenuItem.CheckOnClick = true;
            this.microsoftZiraDesktopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.microsoftZiraDesktopToolStripMenuItem.Name = "microsoftZiraDesktopToolStripMenuItem";
            this.microsoftZiraDesktopToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.microsoftZiraDesktopToolStripMenuItem.Text = "Microsoft Zira Desktop";
            this.microsoftZiraDesktopToolStripMenuItem.Click += new System.EventHandler(this.microsoftZiraDesktopToolStripMenuItem_Click);
            // 
            // herenaToolStripMenuItem
            // 
            this.herenaToolStripMenuItem.CheckOnClick = true;
            this.herenaToolStripMenuItem.Name = "herenaToolStripMenuItem";
            this.herenaToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.herenaToolStripMenuItem.Text = "LISHelen";
            this.herenaToolStripMenuItem.Click += new System.EventHandler(this.LisHelenToolStripMenuItem_Click);
            // 
            // hayleyToolStripMenuItem
            // 
            this.hayleyToolStripMenuItem.CheckOnClick = true;
            this.hayleyToolStripMenuItem.Name = "hayleyToolStripMenuItem";
            this.hayleyToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.hayleyToolStripMenuItem.Text = "Hayley";
            this.hayleyToolStripMenuItem.Click += new System.EventHandler(this.hayleyToolStripMenuItem_Click);
            // 
            // gBCHazelToolStripMenuItem
            // 
            this.gBCHazelToolStripMenuItem.CheckOnClick = true;
            this.gBCHazelToolStripMenuItem.Name = "gBCHazelToolStripMenuItem";
            this.gBCHazelToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.gBCHazelToolStripMenuItem.Text = "GBCHazel";
            this.gBCHazelToolStripMenuItem.Click += new System.EventHandler(this.gBCHazelToolStripMenuItem_Click);
            // 
            // herenaToolStripMenuItem1
            // 
            this.herenaToolStripMenuItem1.CheckOnClick = true;
            this.herenaToolStripMenuItem1.Name = "herenaToolStripMenuItem1";
            this.herenaToolStripMenuItem1.Size = new System.Drawing.Size(363, 48);
            this.herenaToolStripMenuItem1.Text = "Herena";
            this.herenaToolStripMenuItem1.Click += new System.EventHandler(this.herenaToolStripMenuItem1_Click);
            // 
            // iNHeeraToolStripMenuItem
            // 
            this.iNHeeraToolStripMenuItem.CheckOnClick = true;
            this.iNHeeraToolStripMenuItem.Name = "iNHeeraToolStripMenuItem";
            this.iNHeeraToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.iNHeeraToolStripMenuItem.Text = "IN_Heera";
            this.iNHeeraToolStripMenuItem.Click += new System.EventHandler(this.iNHeeraToolStripMenuItem_Click);
            // 
            // daDKvHelleToolStripMenuItem
            // 
            this.daDKvHelleToolStripMenuItem.CheckOnClick = true;
            this.daDKvHelleToolStripMenuItem.Name = "daDKvHelleToolStripMenuItem";
            this.daDKvHelleToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.daDKvHelleToolStripMenuItem.Text = "da_DKvHelle";
            this.daDKvHelleToolStripMenuItem.Click += new System.EventHandler(this.daDKvHelleToolStripMenuItem_Click);
            // 
            // esHelenaToolStripMenuItem
            // 
            this.esHelenaToolStripMenuItem.CheckOnClick = true;
            this.esHelenaToolStripMenuItem.Name = "esHelenaToolStripMenuItem";
            this.esHelenaToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.esHelenaToolStripMenuItem.Text = "es_Helena";
            this.esHelenaToolStripMenuItem.Click += new System.EventHandler(this.esHelenaToolStripMenuItem_Click);
            // 
            // esMXYHildaToolStripMenuItem
            // 
            this.esMXYHildaToolStripMenuItem.CheckOnClick = true;
            this.esMXYHildaToolStripMenuItem.Name = "esMXYHildaToolStripMenuItem";
            this.esMXYHildaToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.esMXYHildaToolStripMenuItem.Text = "es_MXYHilda";
            this.esMXYHildaToolStripMenuItem.Click += new System.EventHandler(this.esMXYHildaToolStripMenuItem_Click);
            // 
            // fiHeidiToolStripMenuItem
            // 
            this.fiHeidiToolStripMenuItem.CheckOnClick = true;
            this.fiHeidiToolStripMenuItem.Name = "fiHeidiToolStripMenuItem";
            this.fiHeidiToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.fiHeidiToolStripMenuItem.Text = "fi_Heidi";
            this.fiHeidiToolStripMenuItem.Click += new System.EventHandler(this.fiHeidiToolStripMenuItem_Click);
            // 
            // frFRYHortenseToolStripMenuItem
            // 
            this.frFRYHortenseToolStripMenuItem.CheckOnClick = true;
            this.frFRYHortenseToolStripMenuItem.Name = "frFRYHortenseToolStripMenuItem";
            this.frFRYHortenseToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.frFRYHortenseToolStripMenuItem.Text = "fr_FRYHortense";
            this.frFRYHortenseToolStripMenuItem.Click += new System.EventHandler(this.frFRYHortenseToolStripMenuItem_Click);
            // 
            // jaHarukaToolStripMenuItem
            // 
            this.jaHarukaToolStripMenuItem.CheckOnClick = true;
            this.jaHarukaToolStripMenuItem.Name = "jaHarukaToolStripMenuItem";
            this.jaHarukaToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.jaHarukaToolStripMenuItem.Text = "ja_Haruka";
            this.jaHarukaToolStripMenuItem.Click += new System.EventHandler(this.jaHarukaToolStripMenuItem_Click);
            // 
            // kokrKRreAMiToolStripMenuItem
            // 
            this.kokrKRreAMiToolStripMenuItem.CheckOnClick = true;
            this.kokrKRreAMiToolStripMenuItem.Name = "kokrKRreAMiToolStripMenuItem";
            this.kokrKRreAMiToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.kokrKRreAMiToolStripMenuItem.Text = "ko-kr_KRre a mi";
            this.kokrKRreAMiToolStripMenuItem.Click += new System.EventHandler(this.kokrKRreAMiToolStripMenuItem_Click);
            // 
            // nbnoHuldaToolStripMenuItem
            // 
            this.nbnoHuldaToolStripMenuItem.CheckOnClick = true;
            this.nbnoHuldaToolStripMenuItem.Name = "nbnoHuldaToolStripMenuItem";
            this.nbnoHuldaToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.nbnoHuldaToolStripMenuItem.Text = "nb-no_Hulda";
            this.nbnoHuldaToolStripMenuItem.Click += new System.EventHandler(this.nbnoHuldaToolStripMenuItem_Click);
            // 
            // nbNOHuldaToolStripMenuItem1
            // 
            this.nbNOHuldaToolStripMenuItem1.CheckOnClick = true;
            this.nbNOHuldaToolStripMenuItem1.Name = "nbNOHuldaToolStripMenuItem1";
            this.nbNOHuldaToolStripMenuItem1.Size = new System.Drawing.Size(363, 48);
            this.nbNOHuldaToolStripMenuItem1.Text = "nl-NL_Hanna";
            this.nbNOHuldaToolStripMenuItem1.Click += new System.EventHandler(this.nbNOHannaToolStripMenuItem1_Click);
            // 
            // rUElenaToolStripMenuItem
            // 
            this.rUElenaToolStripMenuItem.CheckOnClick = true;
            this.rUElenaToolStripMenuItem.Name = "rUElenaToolStripMenuItem";
            this.rUElenaToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.rUElenaToolStripMenuItem.Text = "RU_Elena";
            this.rUElenaToolStripMenuItem.Click += new System.EventHandler(this.rUElenaToolStripMenuItem_Click);
            // 
            // plPLPaulinaToolStripMenuItem
            // 
            this.plPLPaulinaToolStripMenuItem.CheckOnClick = true;
            this.plPLPaulinaToolStripMenuItem.Name = "plPLPaulinaToolStripMenuItem";
            this.plPLPaulinaToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.plPLPaulinaToolStripMenuItem.Text = "pl-PL_Paulina";
            this.plPLPaulinaToolStripMenuItem.Click += new System.EventHandler(this.plPLPaulinaToolStripMenuItem_Click);
            // 
            // ptHeliaToolStripMenuItem
            // 
            this.ptHeliaToolStripMenuItem.CheckOnClick = true;
            this.ptHeliaToolStripMenuItem.Name = "ptHeliaToolStripMenuItem";
            this.ptHeliaToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.ptHeliaToolStripMenuItem.Text = "pt_Helia";
            this.ptHeliaToolStripMenuItem.Click += new System.EventHandler(this.ptHeliaToolStripMenuItem_Click);
            // 
            // zhHKHKHunYeeToolStripMenuItem
            // 
            this.zhHKHKHunYeeToolStripMenuItem.CheckOnClick = true;
            this.zhHKHKHunYeeToolStripMenuItem.Name = "zhHKHKHunYeeToolStripMenuItem";
            this.zhHKHKHunYeeToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.zhHKHKHunYeeToolStripMenuItem.Text = "zh-HK_HKHunYee";
            this.zhHKHKHunYeeToolStripMenuItem.Click += new System.EventHandler(this.zhHKHKHunYeeToolStripMenuItem_Click);
            // 
            // zhTvVHanHanToolStripMenuItem
            // 
            this.zhTvVHanHanToolStripMenuItem.CheckOnClick = true;
            this.zhTvVHanHanToolStripMenuItem.Name = "zhTvVHanHanToolStripMenuItem";
            this.zhTvVHanHanToolStripMenuItem.Size = new System.Drawing.Size(363, 48);
            this.zhTvVHanHanToolStripMenuItem.Text = "zh-TvV_HanHan";
            this.zhTvVHanHanToolStripMenuItem.Click += new System.EventHandler(this.zhTvVHanHanToolStripMenuItem_Click);
            // 
            // editWordToolStripMenuItem
            // 
            this.editWordToolStripMenuItem.Name = "editWordToolStripMenuItem";
            this.editWordToolStripMenuItem.Size = new System.Drawing.Size(356, 46);
            this.editWordToolStripMenuItem.Text = "Edit Selected Word";
            this.editWordToolStripMenuItem.Click += new System.EventHandler(this.editWordToolStripMenuItem_Click);
            // 
            // deleteWordToolStripMenuItem
            // 
            this.deleteWordToolStripMenuItem.Name = "deleteWordToolStripMenuItem";
            this.deleteWordToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteWordToolStripMenuItem.Size = new System.Drawing.Size(356, 46);
            this.deleteWordToolStripMenuItem.Text = "Delete Selected Word/s";
            this.deleteWordToolStripMenuItem.Click += new System.EventHandler(this.deleteWordToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.listToolStripMenuItem,
            this.largeIconToolStripMenuItem,
            this.smallIconToolStripMenuItem,
            this.tileToolStripMenuItem});
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(356, 46);
            this.listViewToolStripMenuItem.Text = "List View";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Checked = true;
            this.detailsToolStripMenuItem.CheckOnClick = true;
            this.detailsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(233, 48);
            this.detailsToolStripMenuItem.Tag = "1";
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.CheckOnClick = true;
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(233, 48);
            this.listToolStripMenuItem.Tag = "2";
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.CheckOnClick = true;
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(233, 48);
            this.largeIconToolStripMenuItem.Tag = "3";
            this.largeIconToolStripMenuItem.Text = "Large Icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // smallIconToolStripMenuItem
            // 
            this.smallIconToolStripMenuItem.CheckOnClick = true;
            this.smallIconToolStripMenuItem.Name = "smallIconToolStripMenuItem";
            this.smallIconToolStripMenuItem.Size = new System.Drawing.Size(233, 48);
            this.smallIconToolStripMenuItem.Tag = "4";
            this.smallIconToolStripMenuItem.Text = "Small Icon";
            this.smallIconToolStripMenuItem.Click += new System.EventHandler(this.smallIconToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.CheckOnClick = true;
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(233, 48);
            this.tileToolStripMenuItem.Tag = "5";
            this.tileToolStripMenuItem.Text = "Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // deleteAllWordsToolStripMenuItem1
            // 
            this.deleteAllWordsToolStripMenuItem1.Name = "deleteAllWordsToolStripMenuItem1";
            this.deleteAllWordsToolStripMenuItem1.Size = new System.Drawing.Size(356, 46);
            this.deleteAllWordsToolStripMenuItem1.Text = "Delete All Words";
            this.deleteAllWordsToolStripMenuItem1.Click += new System.EventHandler(this.deleteAllWordsToolStripMenuItem1_Click);
            // 
            // unCheckSelectedWordsToolStripMenuItem
            // 
            this.unCheckSelectedWordsToolStripMenuItem.Name = "unCheckSelectedWordsToolStripMenuItem";
            this.unCheckSelectedWordsToolStripMenuItem.Size = new System.Drawing.Size(356, 46);
            this.unCheckSelectedWordsToolStripMenuItem.Text = "UnCheck Selected Words";
            this.unCheckSelectedWordsToolStripMenuItem.Click += new System.EventHandler(this.unCheckSelectedWordsToolStripMenuItem_Click);
            // 
            // lblSystemVolume
            // 
            this.lblSystemVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSystemVolume.AutoSize = true;
            this.lblSystemVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemVolume.Font = new System.Drawing.Font("Cairo", 28F, System.Drawing.FontStyle.Bold);
            this.lblSystemVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.lblSystemVolume.Location = new System.Drawing.Point(1071, 903);
            this.lblSystemVolume.Name = "lblSystemVolume";
            this.lblSystemVolume.Size = new System.Drawing.Size(530, 125);
            this.lblSystemVolume.TabIndex = 14;
            this.lblSystemVolume.Text = "System Volume :";
            this.lblSystemVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.BackColor = System.Drawing.Color.DarkGreen;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(1436, 963);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(409, 80);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ESpeakSelectedWords
            // 
            this.ESpeakSelectedWords.BackColor = System.Drawing.Color.Transparent;
            this.ESpeakSelectedWords.BorderRadius = 30;
            this.ESpeakSelectedWords.BorderSize = 1;
            this.ESpeakSelectedWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ESpeakSelectedWords.FocusColor = System.Drawing.Color.Green;
            this.ESpeakSelectedWords.Font = new System.Drawing.Font("Cairo", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ESpeakSelectedWords.ForeColor = System.Drawing.Color.White;
            this.ESpeakSelectedWords.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ESpeakSelectedWords.GradientStartColor = System.Drawing.Color.OliveDrab;
            this.ESpeakSelectedWords.Location = new System.Drawing.Point(19, 26);
            this.ESpeakSelectedWords.Name = "ESpeakSelectedWords";
            this.ESpeakSelectedWords.Size = new System.Drawing.Size(377, 105);
            this.ESpeakSelectedWords.TabIndex = 3;
            this.ESpeakSelectedWords.Text = "Speak Selected Words";
            this.ESpeakSelectedWords.UseVisualStyleBackColor = false;
            this.ESpeakSelectedWords.Click += new System.EventHandler(this.ESpeakSelectedWords_Click);
            // 
            // makeAnyPartOfFormDraggable1
            // 
            this.makeAnyPartOfFormDraggable1.ConstrainToScreen = false;
            this.makeAnyPartOfFormDraggable1.DragSmoothingFactor = 0.3F;
            this.makeAnyPartOfFormDraggable1.EnableSmoothDrag = true;
            this.makeAnyPartOfFormDraggable1.ShowDragGlow = false;
            // 
            // btnAddENGWords
            // 
            this.btnAddENGWords.BackColor = System.Drawing.Color.Transparent;
            this.btnAddENGWords.BorderRadius = 30;
            this.btnAddENGWords.BorderSize = 1;
            this.btnAddENGWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddENGWords.FocusColor = System.Drawing.Color.Green;
            this.btnAddENGWords.Font = new System.Drawing.Font("Cairo", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddENGWords.ForeColor = System.Drawing.Color.White;
            this.btnAddENGWords.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddENGWords.GradientStartColor = System.Drawing.Color.OliveDrab;
            this.btnAddENGWords.Location = new System.Drawing.Point(1419, 26);
            this.btnAddENGWords.Name = "btnAddENGWords";
            this.btnAddENGWords.Size = new System.Drawing.Size(377, 105);
            this.btnAddENGWords.TabIndex = 1;
            this.btnAddENGWords.Text = "Add English Word";
            this.btnAddENGWords.UseVisualStyleBackColor = false;
            this.btnAddENGWords.Click += new System.EventHandler(this.btnAddENGWords_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderSize = 1;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FocusColor = System.Drawing.Color.IndianRed;
            this.btnExit.Font = new System.Drawing.Font("Cairo", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.GradientStartColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(23, 903);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(211, 72);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotalWords
            // 
            this.lblTotalWords.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalWords.EnableAutoSize = false;
            this.lblTotalWords.FocusEffect = false;
            this.lblTotalWords.Font = new System.Drawing.Font("Cairo", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotalWords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTotalWords.GlowEffect = false;
            this.lblTotalWords.GradientDirection = EnahncedControls.EnhancedLabel.GradientDirectionMode.Vertical;
            this.lblTotalWords.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalWords.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalWords.HoverEffect = false;
            this.lblTotalWords.Location = new System.Drawing.Point(610, 19);
            this.lblTotalWords.MouseDownEffect = false;
            this.lblTotalWords.Name = "lblTotalWords";
            this.lblTotalWords.Padding = new System.Windows.Forms.Padding(3);
            this.lblTotalWords.Radius = 40;
            this.lblTotalWords.ScaleEffect = false;
            this.lblTotalWords.ScaleFactor = 1.1F;
            this.lblTotalWords.Size = new System.Drawing.Size(595, 118);
            this.lblTotalWords.TabIndex = 20;
            this.lblTotalWords.Text = "Total Words :";
            this.lblTotalWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalWords.UseGradient = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTotalWords);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.lstvWords);
            this.panel1.Controls.Add(this.btnAddENGWords);
            this.panel1.Controls.Add(this.ESpeakSelectedWords);
            this.panel1.Controls.Add(this.lblSystemVolume);
            this.panel1.Location = new System.Drawing.Point(45, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1837, 1064);
            this.panel1.TabIndex = 21;
            // 
            // uncheckAllWordsToolStripMenuItem
            // 
            this.uncheckAllWordsToolStripMenuItem.Name = "uncheckAllWordsToolStripMenuItem";
            this.uncheckAllWordsToolStripMenuItem.Size = new System.Drawing.Size(356, 46);
            this.uncheckAllWordsToolStripMenuItem.Text = "Uncheck All Words";
            this.uncheckAllWordsToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllWordsToolStripMenuItem_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cairo", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "frmMainScreen";
            this.Text = "English Learning Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainScreen_FormClosed);
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.WordsListViewContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvWords;
        private System.Windows.Forms.ContextMenuStrip WordsListViewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader colEnglishWords;
        private System.Windows.Forms.ColumnHeader colArabicTranslation1;
        private System.Windows.Forms.ColumnHeader colArabicTranslation2;
        private System.Windows.Forms.ColumnHeader colArabicTranslation3;
        private System.Windows.Forms.ColumnHeader colArabicTranslation4;
        private System.Windows.Forms.Label lblSystemVolume;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem changeVoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftDavidDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem microsoftZiraDesktopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hayleyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gBCHazelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herenaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iNHeeraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daDKvHelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esHelenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esMXYHildaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiHeidiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frFRYHortenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jaHarukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kokrKRreAMiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nbnoHuldaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nbNOHuldaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plPLPaulinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ptHeliaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rUElenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zhHKHKHunYeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zhTvVHanHanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllWordsToolStripMenuItem;
        private EnhancedControls.EnhancedButton ESpeakSelectedWords;
        private EnhancedControls.MakeAnyPartOfFormDraggable makeAnyPartOfFormDraggable1;
        private EnhancedControls.EnhancedButton btnAddENGWords;
        private EnhancedControls.EnhancedButton btnExit;
        private EnahncedControls.EnhancedLabel lblTotalWords;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem deleteAllWordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unCheckSelectedWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllWordsToolStripMenuItem;
    }
}