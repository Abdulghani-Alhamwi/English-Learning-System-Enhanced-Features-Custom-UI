using English_Learning_Management_System.Screens;
using EnhancedControls;
using Lib;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace English_Learning_Management_System.Lib
{
    internal class clsSpeakWordsInView
    {
        class clsWord
        {
            public List<ListViewItem> SelectedWords;
            public string[] Examples;
            public string[] ExamplesTranslations;
            public Form PrevioceForm;
            public Form frmExamplesI;
            public Form frmCurrent;

            public EnhancedButton GbtnEnglishWord;
            public Label lblExample;
            public Label lblTranslation;
            public Label lblReady;
            public Label lblTE;
            public EnhancedButton GbtnTranslation1;
            public EnhancedButton GbtnTranslation2;
            public EnhancedButton GbtnTranslation3;
            public EnhancedButton GbtnTranslation4;
            public Panel GradientPanel1;
            public SmoothProgressIndicator ProgressIndicator1;
            public System.Windows.Forms.Timer timer;
        }
        clsWord Word = new clsWord();

        public clsSpeakWordsInView(Form CurrentForm, Form frmE, frmMainScreen frm, List<ListViewItem> SelectedWords, string[] Examples, string[] ExamplesTranslations, EnhancedButton GbtnEnglishWord, Label lblExample, Label lblTranslation, Label lblReady, Label lblTE, EnhancedButton GbtnTranslation1, EnhancedButton GbtnTranslation2, EnhancedButton GbtnTranslation3, EnhancedButton GbtnTranslation4, Panel guna2GradientPanel1, SmoothProgressIndicator guna2ProgressIndicator1, System.Windows.Forms.Timer t)
        {
            Word.SelectedWords = SelectedWords;

            Word.Examples = Examples;
            Word.ExamplesTranslations = ExamplesTranslations;

            Word.PrevioceForm = frm;
            Word.frmExamplesI = frmE;
            Word.frmCurrent = CurrentForm;

            Word.lblExample = lblExample;
            Word.lblTranslation = lblTranslation;
            Word.lblReady = lblReady;
            Word.lblTE = lblTE;
            Word.GbtnEnglishWord = GbtnEnglishWord;
            Word.GbtnTranslation1 = GbtnTranslation1;
            Word.GbtnTranslation2 = GbtnTranslation2;
            Word.GbtnTranslation3 = GbtnTranslation3;
            Word.GbtnTranslation4 = GbtnTranslation4;
            Word.GradientPanel1 = guna2GradientPanel1;
            Word.ProgressIndicator1 = guna2ProgressIndicator1;
            Word.timer = t;
        }

        short RoundCounter;
        short WaitShTranslationsBtns = -1;

        bool T1, T2, T3, T4;
        bool HideIntro = true;
        bool SpeakEnglishWord = true;

        bool TrasnaltionsBtn1HasShowed = false;
        bool TrasnaltionsBtn2HasShowed = false;
        bool TrasnaltionsBtn3HasShowed = false;
        bool TrasnaltionsBtn4HasShowed = false;
        bool AllowExampleshawn = true;

        private void PrepareEnglishButton()
        {
            Word.GbtnEnglishWord.Visible = true;
            //Word.GradientPanel1.Refresh();
            if (SpeakEnglishWord)
            {
                clsLib.SpellAWordMOD(Word.GbtnEnglishWord.Text);
                SpeakEnglishWord = false;
            }
        }

        private void Prepare(short RoundCounter)
        {
            if (Word.SelectedWords != null && Word.SelectedWords.Count > 0 && RoundCounter < Word.SelectedWords.Count)
            {
                Word.GbtnEnglishWord.Text = Word.SelectedWords[RoundCounter].Text;
                Word.lblExample.Text = Word.Examples[RoundCounter];
                Word.lblTranslation.Text = Word.ExamplesTranslations[RoundCounter];
                for (short i = 1; i < Word.SelectedWords[RoundCounter].SubItems.Count; i++)
                {
                    if (i == 1)
                    {
                        Word.GbtnTranslation1.Text = Word.SelectedWords[RoundCounter].SubItems[i].Text;
                        T1 = true;

                    }
                    if (i == 2)
                    {
                        Word.GbtnTranslation2.Text = Word.SelectedWords[RoundCounter].SubItems[i].Text;
                        T2 = true;
                    }

                    if (i == 3)
                    {
                        Word.GbtnTranslation3.Text = Word.SelectedWords[RoundCounter].SubItems[i].Text;
                        T3 = true;
                    }

                    if (i == 4)
                    {
                        Word.GbtnTranslation4.Text = Word.SelectedWords[RoundCounter].SubItems[i].Text;
                        T4 = true;
                    }
                }
                if (SpeakEnglishWord)
                    PrepareEnglishButton();

            }
        }

        private void ChangeButtonColor(EnhancedButton Btn, Color color1, Color Color2)
        {
            if (color1 != null)
                Btn.GradientStartColor = color1;
            if (Color2 != null)
                Btn.GradientEndColor = Color2;
        }

        private void _HideIntroControls()
        {
            Word.lblReady.Visible = false;
            Word.ProgressIndicator1.Visible = false;
            Word.ProgressIndicator1.Stop();
            //Word.GradientPanel1.Refresh();

        }

        private void ShowIntroControls()
        {
            HideIntro = true;
            Word.lblReady.Visible = true;
            Word.ProgressIndicator1.Start();
            Word.ProgressIndicator1.Visible = true;
            //Word.GradientPanel1.Refresh();
        }

        private void _HideTranslationsButtons()
        {
            Word.GbtnTranslation1.Visible = false;
            Word.GbtnTranslation2.Visible = false;
            Word.GbtnTranslation3.Visible = false;
            Word.GbtnTranslation4.Visible = false;
            //Word.GradientPanel1.Refresh();

        }

        private void _ShowExample()
        {
            Word.lblExample.Visible = true;
            Word.lblTE.Visible = true;
            Word.lblTranslation.Visible = true;
            //Word.GradientPanel1.Refresh();
            clsLib.SpellAWordMOD("Example");
            Thread.Sleep(800);
            clsLib.SpellAWordMOD(Word.lblExample.Text);
        }

        void _HideExample()
        {
            Thread.Sleep(4000);
            Word.lblExample.Visible = false;
            Word.lblTranslation.Visible = false;
            Word.lblTE.Visible = false;
            //Word.GradientPanel1.Refresh();
        }

        void _ShownTranslationsButtons(short WaitShowing)
        {
            if (Word.timer == null)
                return;

            Word.timer.Interval = 2000;
            if (T1 && WaitShowing == 1)
            {
                if (!TrasnaltionsBtn1HasShowed)
                {
                    Word.GbtnTranslation1.Visible = true;
                    //Word.GradientPanel1.Refresh();
                    clsLib.SpellAWordMOD(Word.GbtnEnglishWord.Text);
                    TrasnaltionsBtn1HasShowed = true;
                }
            }
            if (T2 && WaitShowing == 2)
            {
                if (!TrasnaltionsBtn2HasShowed)
                {
                    Word.GbtnTranslation2.Visible = true;
                    //Word.GradientPanel1.Refresh();
                    clsLib.SpellAWordMOD(Word.GbtnEnglishWord.Text);
                    TrasnaltionsBtn2HasShowed = true;
                }
            }

            if (T3 && WaitShowing == 3)
            {
                if (!TrasnaltionsBtn3HasShowed)
                {
                    Word.GbtnTranslation3.Visible = true;
                    //Word.GradientPanel1.Refresh();
                    clsLib.SpellAWordMOD(Word.GbtnEnglishWord.Text);
                    TrasnaltionsBtn3HasShowed = true;
                }
            }
            if (T4 && WaitShowing == 4)
            {
                if (!TrasnaltionsBtn4HasShowed)
                {
                    //ChangeGunaButtonColor(GbtnTranslation4, GbtnTranslation1.FillColor, Color.DarkSeaGreen);64, 0, 0
                    Word.GbtnTranslation4.Visible = true;
                  //  Word.GradientPanel1.Refresh();
                    clsLib.SpellAWordMOD(Word.GbtnEnglishWord.Text);
                    TrasnaltionsBtn4HasShowed = true;
                }
            }

        }

        void _ResetSettingsToRepeat(bool FullReset)
        {
            if (FullReset)
            {
                RoundCounter = 0;
                SpeakEnglishWord = true;
                T1 = false;
                T2 = false;
                T3 = false;
                T4 = false;
                TrasnaltionsBtn1HasShowed = false;
                TrasnaltionsBtn2HasShowed = false;
                TrasnaltionsBtn3HasShowed = false;
                TrasnaltionsBtn4HasShowed = false;
                _HideExample();
                Word.GbtnEnglishWord.Visible = false;
                //Word.GradientPanel1.Refresh();
                WaitShTranslationsBtns = -1;
                AllowExampleshawn = true;
                ShowIntroControls();
                Word.timer.Interval = 4000;
                Word.timer.Start();
            }
            else
            {
                Word.timer.Interval = 4000;
                SpeakEnglishWord = true;
                T1 = false;
                T2 = false;
                T3 = false;
                T4 = false;
                TrasnaltionsBtn1HasShowed = false;
                TrasnaltionsBtn2HasShowed = false;
                TrasnaltionsBtn3HasShowed = false;
                TrasnaltionsBtn4HasShowed = false;
                WaitShTranslationsBtns = -1;
                AllowExampleshawn = true;
                Thread.Sleep(4000);
                _HideExample();
            }
        }


        void _MoveToNextRound()
        {
            if (RoundCounter == Word.SelectedWords.Count)
            {
                Word.timer.Stop();
                Thread.Sleep(8000);
                if (MessageBox.Show("Lesson Has Ended , Do You Want To Repeat Lesson", "End Of Lesson", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _ResetSettingsToRepeat(true);
                    return;
                }
                else
                {
                    Word.PrevioceForm.Opacity = 0.0;
                    Word.PrevioceForm.Show();
                    Word.frmCurrent.Close();
                    Word.frmExamplesI.Close();
                    Word.PrevioceForm.Opacity = 100.0;
                    return;
                }
            }
            _ResetSettingsToRepeat(false);
        }


        bool IsAllTranslationsHasShawn()
        {
            if (T1 && T2 && T3 && T4)
                return WaitShTranslationsBtns == 4;

            else if (T1 && T2 && T3)
                return WaitShTranslationsBtns == 3;

            else if (T1 && T2)
                return WaitShTranslationsBtns == 2;

            else if (T1)
                return WaitShTranslationsBtns == 1;

            return false;
        }

       internal void StartSession()
        {
            if (HideIntro)
            {
                _HideIntroControls();
                //Word.GradientPanel1.Refresh();
                HideIntro = false;
            }

            if (RoundCounter != Word.SelectedWords.Count)
            {
                Prepare(RoundCounter);
            }

            if (!IsAllTranslationsHasShawn())
            {
                WaitShTranslationsBtns++;
                _ShownTranslationsButtons(WaitShTranslationsBtns);
            }
            else
            {
                if (AllowExampleshawn)
                {
                    Word.timer.Interval = 4000;
                    Thread.Sleep(2000);
                    _HideTranslationsButtons();
                    _ShowExample();
                    AllowExampleshawn = false;
                }
                else
                {
                    RoundCounter++;
                    _MoveToNextRound();
                    Word.timer.Interval = 2000;
                }
            }
        }
       internal void EnableTimer()
        {
            Word.timer.Enabled = true;
        }

        }
    }
  