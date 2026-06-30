using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lib.clsWord;

namespace English_Learning_Management_System.Screens
{
    public partial class frmAddMoreATransaltions: Form
    {

        private string _EnglishWord, _ArabicTranslation1;
        frmAddEnglishWord FormToHandleClose;

        bool EditMode = false;
        string OldWord;
        public frmAddMoreATransaltions(frmAddEnglishWord frm, string EnglshWord, string ArabicTranslation1, string OldSelectedWord = null, bool EditWordMode = false, string Translation2 = null, string Translation3 = null, string Translation4 = null)
        {
            InitializeComponent();
            clsLib.ChangeFormProperties(this, Convert.ToInt16(this.Width), Convert.ToInt16(this.Height));
            _EnglishWord = EnglshWord;
            _ArabicTranslation1 = ArabicTranslation1;
            FormToHandleClose = frm;

            EditMode = EditWordMode;
            OldWord = OldSelectedWord;

            if (Translation2 != null)
                txtA2.Text = Translation2;

            if (Translation3 != null)
                txtA3.Text = Translation3;

            if (Translation4 != null)
                txtA4.Text = Translation3;

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void _SaveArabicTranslations()
        {
            if ((txtA2.Text == "" || txtA2.Text == "Enter Arabic Translation 2") && (txtA3.Text == "" || txtA3.Text == "Enter Arabic Translation 3") && (txtA4.Text == "" || txtA4.Text == "Enter Arabic Translation 4"))
            {
                DialogResult Result = MessageBox.Show($"Are you sure you don't want to add more translations and save the english word ({_EnglishWord}) + its One translation ({_ArabicTranslation1})", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Result == DialogResult.OK)
                {
                    clsWord.SaveArabicTranslationsToFile(_ArabicTranslation1, clsWord.FixedAppDataArabicTLocation, true);
                    this.Close();
                    return;
                }
            }
            else
            {
                clsWord.SaveArabicTranslationsToFile(_ArabicTranslation1, clsWord.FixedAppDataArabicTLocation, true, txtA2.Text, txtA3.Text, txtA4.Text);

                MessageBox.Show("Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        internal void AddTranslations()
        {
            if (!EditMode)
            {
                if (_EnglishWord != "" && _ArabicTranslation1 != "")
               {
                    SaveEnglishWordsToFile(_EnglishWord, clsWord.FixedAppDataEnglishWordsLocation);
                    _SaveArabicTranslations();
               }
            }
            else
            {
                clsWord.ATranslations = new clsWord.stArabicTranslation();
                clsWord.ATranslations.Translation1 = _ArabicTranslation1;

                if ((txtA2.Text == "" || txtA2.Text == "Enter Arabic Translation 2") && (txtA3.Text == "" || txtA3.Text == "Enter Arabic Translation 3") && (txtA4.Text == "" || txtA4.Text == "Enter Arabic Translation 4"))
                {

                    DialogResult Result = MessageBox.Show($"Are you sure you don't want to add more translations and save the english word ({_EnglishWord}) + its One translation ({_ArabicTranslation1})", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Result == DialogResult.OK)
                    {
                        clsWord.EditWord(OldWord, _EnglishWord, clsWord.FixedAppDataEnglishWordsLocation, clsWord.FixedAppDataArabicTLocation, clsWord.ATranslations, clsWord.FixedCheckedWordsFileLocation);
                        this.Close();
                        return;
                    }
                }
                else
                {
                    if (txtA2.Text != "")
                        clsWord.ATranslations.Translation2 = txtA2.Text;

                    if (txtA3.Text != "")
                        clsWord.ATranslations.Translation3 = txtA3.Text;

                    if (txtA4.Text != "")
                        clsWord.ATranslations.Translation4 = txtA4.Text;

                    clsWord.EditWord(OldWord, _EnglishWord, clsWord.FixedAppDataEnglishWordsLocation, clsWord.FixedAppDataArabicTLocation, clsWord.ATranslations, "");

                    MessageBox.Show("Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void btnaddTranslations_Click(object sender, EventArgs e)
        {
            AddTranslations();
        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                ((TextBox)sender).Clear();
                ((TextBox)sender).ForeColor = Color.FromArgb(255, 30, 30, 30);
            }
        }

        private void frmAddMoreATransaltions_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormToHandleClose.Close();
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Tag.ToString() == "A1") && ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "Enter Arabic Translation 2";
                ((TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }

            else if ((((TextBox)sender).Tag.ToString() == "A2") && ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "Enter Arabic Translation 3";
                ((TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
            else if ((((TextBox)sender).Tag.ToString() == "A3") && ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "Enter Arabic Translation 4";
                ((TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }

        }
    }
}
