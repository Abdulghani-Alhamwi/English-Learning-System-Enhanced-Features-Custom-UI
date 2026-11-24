using English_Learning_Management_System.Screens;
using Lib;
using Microsoft.Speech.Synthesis;
using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace English_Learning_Management_System
{
    public partial class frmMainScreen : Form
    {
        frmLFFirstLoad frmLifeCycle;
     
        private MMDeviceEnumerator enumerator;
        private MMDevice device;
        public frmMainScreen(frmLFFirstLoad frm)
        {
            frmLifeCycle = frm;
            InitializeComponent();
        }
        private void frmMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLifeCycle.Close();
        }

        List<string> AddArabicTranslations(string T1, string T2, string T3, string T4)
        {
            List<string> Trans = new List<string>();

            if (T1 != "" && T1 != null)
                Trans.Add(T1);
            if (T2 != "" && T2 != null)
                Trans.Add(T2);
            if (T3 != "" && T3 != null)
                Trans.Add(T3);
            if (T4 != "" && T4 != null)
                Trans.Add(T4);

            return Trans;
        }


        internal static async void AddCheckedWordsToFile(string FileName, int WordID)
        {
            using (StreamWriter MyFile = new StreamWriter(FileName, true))
            {
                MyFile.WriteLine(WordID);
            }
        }
         void AddNonRemovedCheckedStateIds(string FileName)
        {
            List<int> lCheckedWordsID = clsWord.LoadCheckedWordsIdFromFile(clsWord.FixedCheckedWordsFileLocation);

            if (lCheckedWordsID.Count == 0)
            {
                MessageBox.Show("There are no checked words !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
                if (lstvWords.SelectedItems.Count>10)
            {
                MessageBox.Show("You can uncheck up to 10 words only in one time", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            File.Delete(FileName);
            int SelectedWordId;
            bool FoundSelectedItem = false;

            for (int i = 0; i < lCheckedWordsID.Count; i++)
            {
                for (int j = 0; j < lstvWords.SelectedItems.Count; j++)
                {
                    SelectedWordId = GetWordID(lstvWords.SelectedItems[j].Text);

                    if (SelectedWordId == lCheckedWordsID[i])
                    {
                        FoundSelectedItem = true;
                        break;
                    }
                }
                if (!FoundSelectedItem)
                {
                    AddCheckedWordsToFile(clsWord.FixedCheckedWordsFileLocation, lCheckedWordsID[i]);
                }
                FoundSelectedItem = false;
            }

        }
        
         void RemoveSelectedCheckedWordsFromFile(string FileName)
        {
            if (lstvWords.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select word/s you want to UnCheck first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AddNonRemovedCheckedStateIds(FileName);
            AddWordsToListView(true);
        }

        [MTAThread]
          int GetWordID(string Word)
        {
            for (int i = 0; i < lstvWords.Items.Count; i++)
            {
                if (lstvWords.Items[i].Text == Word)
                    return i;
            }
            return 0;
        }
        

        void _CheckWords(bool UpdateMode=false,List<int>lWordsIds=null)
        {
            if (!UpdateMode)
            {
                if (lstvWords.SelectedItems.Count == 0)
                {
                    MessageBox.Show("You must select word/s you want to Check first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                for (int i = 0; i < lstvWords.SelectedItems.Count; i++)
                {
                    if (lstvWords.SelectedItems[i].BackColor != Color.Green)
                    {
                        AddCheckedWordsToFile(clsWord.FixedCheckedWordsFileLocation, GetWordID(lstvWords.SelectedItems[i].Text));

                        lstvWords.SelectedItems[i].BackColor = Color.Green;

                        for (int j = 0; j < lstvWords.SelectedItems[i].SubItems.Count; j++)
                        {
                            lstvWords.SelectedItems[i].SubItems[j].BackColor = Color.Green;
                        }
                    }
                }

                for (int i = 0; i < lstvWords.SelectedItems.Count;)
                {
                    lstvWords.SelectedItems[i].Selected = false;
                }
            }

            else
            {
                if (lWordsIds != null)
                {
                    for (int i = 0; i < lWordsIds.Count; i++)
                    {
                        AddCheckedWordsToFile(clsWord.FixedCheckedWordsFileLocation, lWordsIds[i]);
                    }
                }
            }
        }


        private void AddWordsToListView(bool Refresh = false, bool UpdateMode = false,List<int>lWordsIds=null)
        {
            if(UpdateMode)
            {
                _CheckWords(UpdateMode,lWordsIds);
            }
            ListViewItem Item;

            List<string> lWords = clsWord.LoadEnglishWordsFromFile(clsWord.FixedAppDataEnglishWordsLocation);
            List<clsWord.stArabicTranslation> lWordsTranslations = clsWord.LoadArabicTranslationsFromFile(clsWord.FixedAppDataArabicTLocation);
            List<int> CheckedWordsID = clsWord.LoadCheckedWordsIdFromFile(clsWord.FixedCheckedWordsFileLocation);

            lblTotalWords.Text = "Total Words : " + lWords.Count();

            int Counter = 0;

            if (Refresh)
                lstvWords.Items.Clear();

            if (lWords.Count > 0 && lWordsTranslations.Count > 0)
                while (lWords.Count != Counter)
                {
                    Item = new ListViewItem();
                    Item.Text = lWords[Counter];

                    Item.ForeColor = Color.FromArgb(255, 235, 235, 235);

                    if (lWordsTranslations.Count != Counter)
                    {
                        List<string> lArabicTranslations = AddArabicTranslations(lWordsTranslations[Counter].Translation1, lWordsTranslations[Counter].Translation2, lWordsTranslations[Counter].Translation3, lWordsTranslations[Counter].Translation4);

                        for (short i = 0; i < lArabicTranslations.Count(); i++)
                        {
                            Item.SubItems.Add(lArabicTranslations[i]);
                            Item.SubItems[i].ForeColor = Color.FromArgb(255, 235, 235, 235);

                        }

                        for (int i = 0; i < CheckedWordsID.Count(); i++)
                        {
                            if (Counter == CheckedWordsID[i])
                            {
                                Item.BackColor = Color.Green;
                                for (short j = 0; j < lArabicTranslations.Count(); j++)
                                {
                                    Item.SubItems[j].BackColor = Color.Green;
                                }
                            }
                        }
                    }
                    lstvWords.Items.Add(Item);

                    lstvWords.Focus();

                    Counter++;
                }

        }
        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            AddWordsToListView();
            enumerator = new MMDeviceEnumerator();

            device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            trackBar1.Value = (int)(device.AudioEndpointVolume.MasterVolumeLevelScalar * 100);
            try
            {
        List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();
        clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[3]);
            }
            catch
            {
            }
        }
        public void RemovePreviouseCheckedItemForView(short ChoosedItemNumber)
        {
            if (detailsToolStripMenuItem.Checked && ChoosedItemNumber != 1)
                detailsToolStripMenuItem.Checked = false;

            if (listToolStripMenuItem.Checked && ChoosedItemNumber != 2)
                listToolStripMenuItem.Checked = false;

            if (largeIconToolStripMenuItem.Checked && ChoosedItemNumber != 3)
                largeIconToolStripMenuItem.Checked = false;

            if (smallIconToolStripMenuItem.Checked && ChoosedItemNumber != 4)
                smallIconToolStripMenuItem.Checked = false;

            if (tileToolStripMenuItem.Checked && ChoosedItemNumber != 5)
                tileToolStripMenuItem.Checked = false;

        }
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePreviouseCheckedItemForView(1);
            lstvWords.View = View.Details;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePreviouseCheckedItemForView(2);
            lstvWords.View = View.List;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePreviouseCheckedItemForView(3);
            lstvWords.View = View.LargeIcon;
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePreviouseCheckedItemForView(4);
            lstvWords.View = View.SmallIcon;
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePreviouseCheckedItemForView(5);
            lstvWords.View = View.Tile;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            device.AudioEndpointVolume.MasterVolumeLevelScalar = (trackBar1.Value / 100.0f);
        }
        bool LEGACY = true;
        bool defaultvoice = true;
        private void lstvWords_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            if (lstvWords.SelectedItems.Count == 0)
            {
                if (defaultvoice)
                {
                    clsLib.ChangeSpellVoice("Microsoft Zira Desktop");
                    defaultvoice = false;
                }
                if (LEGACY)
                    clsLib.SpellAWordLEGACY(e.Item.SubItems[0].Text);
                else
                    clsLib.SpellAWordMOD(e.Item.SubItems[0].Text);

                //// In order to be able to spell the same word more than one time we refresh the list view by reloading data and in order to spell right and to not go infinite speak for the word -> we used the thread.Sleep () .
                //Thread.Sleep(700);
                //AddWordsToListView(true);
            }

            //The Main Item-> the first item -> the first column is stored as SubItems[0]
            //Additional Columns start from SubItems[1] and so on.

        }


        private void UnCheckAllUnUsedOptions(short NumberOfUseedOption)
        {
            if (NumberOfUseedOption != 1)
                microsoftDavidDesktopToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 2)
                microsoftZiraDesktopToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 3)
                herenaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 4)
                hayleyToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 5)
                gBCHazelToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 6)
                herenaToolStripMenuItem1.Checked = false;

            if (NumberOfUseedOption != 7)
                iNHeeraToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 8)
                daDKvHelleToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 9)
                esHelenaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 10)
                esMXYHildaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 11)
                fiHeidiToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 12)
                frFRYHortenseToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 13)
                jaHarukaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 14)
                kokrKRreAMiToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 15)
                nbnoHuldaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 16)
                nbNOHuldaToolStripMenuItem1.Checked = false;

            if (NumberOfUseedOption != 17)
                rUElenaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 18)
                plPLPaulinaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 19)
                ptHeliaToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 20)
                zhHKHKHunYeeToolStripMenuItem.Checked = false;

            if (NumberOfUseedOption != 21)
                zhTvVHanHanToolStripMenuItem.Checked = false;

        }

        /* We make the list to be local not globally because :
           if the app is installed on client and it has the microsoft speech run time not installed
         -> we will have an exception -> So , we made it local to handle exceptions .
        */
        //private List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

        private void microsoftDavidDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(1);
                clsLib.ChangeSpellVoice("Microsoft David Desktop");
                LEGACY = true;
            
        }

        private void microsoftZiraDesktopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnCheckAllUnUsedOptions(2);
            clsLib.ChangeSpellVoice("Microsoft Zira Desktop");
                LEGACY = true;
            
        }
        private void LisHelenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[0]);
            UnCheckAllUnUsedOptions(3);
                LEGACY = false; 
            }
            catch
            {
                herenaToolStripMenuItem.Checked = false;
            }
        }
        private void hayleyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[1]);
                UnCheckAllUnUsedOptions(4);
                LEGACY = false;
            }
            catch
            {
                hayleyToolStripMenuItem.Checked = false;
            }
        }
        

        private void gBCHazelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[2]);
                UnCheckAllUnUsedOptions(5);
                LEGACY = false;
            }
            catch
            {
                gBCHazelToolStripMenuItem.Checked = false;
            }
        }
        
        private void herenaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[3]);
                UnCheckAllUnUsedOptions(6);
                LEGACY = false;
            }
            catch
            {
                herenaToolStripMenuItem1.Checked = false;
            }
        }
        private void iNHeeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[4]);
                UnCheckAllUnUsedOptions(7);
                LEGACY = false;
            }
            catch
            {
                iNHeeraToolStripMenuItem.Checked = false;
            }
        }
        private void daDKvHelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[5]);
                UnCheckAllUnUsedOptions(8);
                LEGACY = false;
            }
            catch
            {
                daDKvHelleToolStripMenuItem.Checked = false;
            }
        }
        
        private void esHelenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[6]);
                UnCheckAllUnUsedOptions(9);
                LEGACY = false;
            }
            catch
            {
                esHelenaToolStripMenuItem.Checked = false;
            }
        }
        
        private void esMXYHildaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[7]);
                UnCheckAllUnUsedOptions(10);
                LEGACY = false;
            }
            catch
            {
                esMXYHildaToolStripMenuItem.Checked = false;
            }
        }
        
        private void fiHeidiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[8]);
                UnCheckAllUnUsedOptions(11);
                LEGACY = false;
            }
            catch
            {
                fiHeidiToolStripMenuItem.Checked = false;
            }
        }
        
        private void frFRYHortenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[9]);
                UnCheckAllUnUsedOptions(12);
                LEGACY = false;
            }
            catch
            {
                frFRYHortenseToolStripMenuItem.Checked = false;
            }
        }
        
        private void jaHarukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[10]);
                UnCheckAllUnUsedOptions(13);
                LEGACY = false;
            }
            catch
            {
                jaHarukaToolStripMenuItem.Checked = false;
            }
        }
        
        private void kokrKRreAMiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[11]);
                UnCheckAllUnUsedOptions(14);
                LEGACY = false;
            }
            catch
            {
                kokrKRreAMiToolStripMenuItem.Checked = false;
            }
        }
        
        private void nbnoHuldaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[12]);
                UnCheckAllUnUsedOptions(15);
                LEGACY = false;
            }
            catch
            {
                nbnoHuldaToolStripMenuItem.Checked = false;
            }
        }
        
        private void nbNOHannaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[13]);
                UnCheckAllUnUsedOptions(16);
                LEGACY = false;
            }
            catch
            {
                nbNOHuldaToolStripMenuItem1.Checked = false;
            }
        }
        
        private void rUElenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[14]);
                UnCheckAllUnUsedOptions(17);
                LEGACY = false;
            }
            catch
            {
                rUElenaToolStripMenuItem.Checked = false;
            }
        }
        private void plPLPaulinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[15]);
                UnCheckAllUnUsedOptions(18);
                LEGACY = false;
            }
            catch
            {
                plPLPaulinaToolStripMenuItem.Checked = false;
            }
        }
        private void ptHeliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[16]);
                UnCheckAllUnUsedOptions(19);
                LEGACY = false;
            }
            catch
            {
                ptHeliaToolStripMenuItem.Checked = false;
            }
        }
        private void zhHKHKHunYeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[17]);
                UnCheckAllUnUsedOptions(20);
                LEGACY = false;
            }
            catch
            {
                zhHKHKHunYeeToolStripMenuItem.Checked = false;
            }
        }

        private void zhTvVHanHanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<InstalledVoice> AllInstalledVoices = clsLib.GetAllModernInstalledVoices();

                clsLib.ChangeSpellVoiceMOD(AllInstalledVoices[18]);
                UnCheckAllUnUsedOptions(21);
                LEGACY = false;
            }
            catch
            {
                zhTvVHanHanToolStripMenuItem.Checked = false;
            }
        }

        private List<ListViewItem> prepareSelectedItemsToMove(ListView.SelectedListViewItemCollection SelectedItems)
        {
            List<ListViewItem> Items = new List<ListViewItem>();
            for (short i = 0; i < SelectedItems.Count; i++)
            {
                Items.Add(SelectedItems[i]);
            }
            return Items;
        }


        private void deleteWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstvWords.SelectedItems.Count==0)
            {
                MessageBox.Show("You must select word/s you want to delete first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }

            if (lstvWords.SelectedItems.Count > 3)
            {
                MessageBox.Show("You can select maximum 3 words in order to delete them", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete selected word/s ?", "Need Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int[] SelectedItemsIndexes = new int [lstvWords.SelectedItems.Count];

                for (int i = 0; i < lstvWords.SelectedItems.Count; i++)
                {
                    clsWord.DeleteWord(lstvWords.SelectedItems[i].Text, clsWord.FixedAppDataEnglishWordsLocation, clsWord.FixedAppDataArabicTLocation, clsWord.FixedCheckedWordsFileLocation);
                    SelectedItemsIndexes[i]=lstvWords.SelectedItems[i].Index;
                }

                for (int i = SelectedItemsIndexes.Length - 1; i >= 0 ; i--)
                {
                    lstvWords.Items.RemoveAt(SelectedItemsIndexes[i]);
                }

                lblTotalWords.Text = lstvWords.Items.Count.ToString();
            }

        }

   
        private void editWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lstvWords.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a word first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lstvWords.SelectedItems.Count > 1)
            {
                MessageBox.Show("You must select Only One Word ! \n You can edit only one word in one time", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Form frmAddWords;
            if (lstvWords.SelectedItems[0].SubItems.Count==2)
                frmAddWords = new frmAddUpdateEnglishWord(true, lstvWords.SelectedItems[0].Text, lstvWords.SelectedItems[0].SubItems[1].Text);
            else if(lstvWords.SelectedItems[0].SubItems.Count==3)
                 frmAddWords = new frmAddUpdateEnglishWord(true, lstvWords.SelectedItems[0].Text, lstvWords.SelectedItems[0].SubItems[1].Text, lstvWords.SelectedItems[0].SubItems[2].Text);
            else if(lstvWords.SelectedItems[0].SubItems.Count==4)
                 frmAddWords = new frmAddUpdateEnglishWord(true, lstvWords.SelectedItems[0].Text, lstvWords.SelectedItems[0].SubItems[1].Text, lstvWords.SelectedItems[0].SubItems[2].Text, lstvWords.SelectedItems[0].SubItems[3].Text);
            else
                 frmAddWords = new frmAddUpdateEnglishWord(true, lstvWords.SelectedItems[0].Text, lstvWords.SelectedItems[0].SubItems[1].Text, lstvWords.SelectedItems[0].SubItems[2].Text, lstvWords.SelectedItems[0].SubItems[3].Text, lstvWords.SelectedItems[0].SubItems[4].Text);

            List<int> lCheckedWordsIds = clsWord.LoadCheckedWordsIdFromFile(clsWord.FixedCheckedWordsFileLocation);
            frmAddWords.ShowDialog();

            AddWordsToListView(true,true,lCheckedWordsIds);
        }
        bool IsScale100()
        {
            using (Graphics g = this.CreateGraphics())
            {
                return (g.DpiX == 96 && g.DpiY == 96);
            }
        }
        private void ESpeakSelectedWords_Click(object sender, EventArgs e)
        {
            if (lstvWords.SelectedItems.Count >= 1 && lstvWords.SelectedItems.Count <= 4)
            {
                if (IsScale100())
                {
                    frmExample frmE = new frmExample(this, prepareSelectedItemsToMove(lstvWords.SelectedItems));
                    frmE.ShowDialog();
                }
                 else
                    MessageBox.Show("To use this feature , display scale should be 100%\nYou can modify display scale from settings then display then choose display scale 100%", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please Select Item/s From The List First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void AddNewWordToListView(string NewEnglishWord,string ArabicTranslation1,string ArabicTranslation2 = null,string ArabicTranslation3 = null ,string ArabicTranslation4 = null)
        {
            
            ListViewItem NewItem = new ListViewItem();
            
            string[] SubItems = new string[5];

            NewItem.Text = NewEnglishWord;
            SubItems[0] = ArabicTranslation1;

            if (ArabicTranslation2 != null)
                SubItems[1] = ArabicTranslation2;

            if (ArabicTranslation3 != null)
                SubItems[2] = ArabicTranslation3;

            if (ArabicTranslation4 != null)
                SubItems[3] = ArabicTranslation4;


            NewItem.SubItems.AddRange(SubItems);
            lstvWords.Items.Add(NewItem);

            lblTotalWords.Text = lstvWords.Items.Count.ToString();
        }

        private void btnAddENGWords_Click(object sender, EventArgs e)
        {
            frmAddUpdateEnglishWord frmAddWords = new frmAddUpdateEnglishWord();
            frmAddWords.OnSavingOrUpdating += AddNewWordToListView;
            frmAddWords.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteAllWordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all words ?", "Need Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                clsWord.DeleteAllRecords(clsWord.FixedAppDataEnglishWordsLocation, clsWord.FixedAppDataArabicTLocation, clsWord.FixedCheckedWordsFileLocation);
                lstvWords.Items.Clear();
                lblTotalWords.Text = "Total Words : " + lstvWords.Items.Count;
            }
        }

        private void CheckAllWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _CheckWords();
        }

        private void unCheckSelectedWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSelectedCheckedWordsFromFile(clsWord.FixedCheckedWordsFileLocation);
        }

        private void uncheckAllWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(clsWord.FixedCheckedWordsFileLocation))
            {
                if (DialogResult.OK == MessageBox.Show("Are you sure you want to uncheck all ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    File.Delete(clsWord.FixedCheckedWordsFileLocation);

                AddWordsToListView(true);
            }
            else
                MessageBox.Show("There are no checked words !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     
        bool _SearchForEnglishWord(string EnglishWord , out ListViewItem Item)
        {
            for(int i=0;i < lstvWords.Items.Count;i++)
            {
                if (lstvWords.Items[i].Text.ToLower() == EnglishWord.ToLower())
                {                    
                    lstvWords.TopItem = lstvWords.Items[i];
                    Item = lstvWords.Items[i];
                    lstvWords.Items[i].BackColor = Color.DarkViolet;
                    return true;
                }
            }

            Item = null;

            return false;
        }
          ListViewItem SearchedItem;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text=="" || txtSearch.Text == "Search By English Word")
            {
                MessageBox.Show("Enter English Word to search for it !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(!_SearchForEnglishWord(txtSearch.Text,out SearchedItem))
                {
                    MessageBox.Show("English Word is Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtSearch.Text = "Seatch By English Word";

                    tFoundedSearchedItem.Enabled = true;
                    
                }
                lstvWords.Focus();

            }

        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();

        }

        private void tFoundedSearchedItem_Tick(object sender, EventArgs e)
        {
            if(SearchedItem!=null)
            {
                SearchedItem.BackColor = lstvWords.BackColor;
            }
        }
    }
}
