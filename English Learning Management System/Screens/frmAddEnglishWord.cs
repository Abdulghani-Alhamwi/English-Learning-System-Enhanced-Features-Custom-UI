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

namespace English_Learning_Management_System.Screens
{
    public partial class frmAddEnglishWord : Form
    {
        bool EditWordMode = false;
        string OldSelectedWord;
        string T2;
        string T3;
        string T4;
        bool MoreTranslations = false;
        
        public frmAddEnglishWord(bool EditWord = false, string OldWord = null,string Translation1=null, string Translation2 = null, string Translation3 = null, string Translation4 = null)
        {
            InitializeComponent();
            clsLib.ChangeFormProperties(this, Convert.ToInt16(this.Width), Convert.ToInt16(this.Height));
            EditWordMode = EditWord;
            OldSelectedWord = OldWord;
            
            if (EditWordMode)
                btnAddWord.Text = "Update Word";

            if (OldWord != null && Translation1 != null)
            {
                txtBoxEnglishWord.Text = OldWord;
                txtArabicWord.Text = Translation1;
            }

            T2 = Translation2;
            T3 = Translation3;
            T4 = Translation4;

            if (Translation2 != null)
                MoreTranslations = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            if(MoreTranslations)
            {
                frmAddMoreATransaltions frmMoreArabicTranslations = new frmAddMoreATransaltions(this, txtBoxEnglishWord.Text, txtArabicWord.Text, OldSelectedWord, EditWordMode, T2, T3, T4);
                frmMoreArabicTranslations.AddTranslations();
                this.Close();
                return;
            }
            if ((txtBoxEnglishWord.Text != "" && txtBoxEnglishWord.Text != "Enter English Word/s") && (txtArabicWord.Text != "" && txtArabicWord.Text != "Enter Arabic Translation"))
            {
                if (!EditWordMode)
                {
                    if (clsWord.SaveEnglishWordsToFile(txtBoxEnglishWord.Text, clsWord.FixedAppDataEnglishWordsLocation) && clsWord.SaveArabicTranslationsToFile(txtArabicWord.Text, clsWord.FixedAppDataArabicTLocation,true))
                        MessageBox.Show("Word added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtBoxEnglishWord.Clear();
                    txtArabicWord.Clear();
                    this.Close();
                }
                else
                {
                    if (OldSelectedWord != null)
                    {
                        clsWord.ATranslations = new clsWord.stArabicTranslation();
                        clsWord.ATranslations.Translation1 = txtArabicWord.Text;
                        clsWord.EditWord(OldSelectedWord, txtBoxEnglishWord.Text, clsWord.FixedAppDataEnglishWordsLocation, clsWord.FixedAppDataArabicTLocation, clsWord.ATranslations, clsWord.FixedCheckedWordsFileLocation);
                        MessageBox.Show("Word updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtBoxEnglishWord.Clear();
                        txtArabicWord.Clear();
                        this.Close();
                    }
                }
            }
        }

        private void btngAddMoreTranslations_Click(object sender, EventArgs e)
        {
            
            if (txtBoxEnglishWord.Text != "" && txtArabicWord.Text != "")
            {
                
                Form frmMoreArabicTranslations = new frmAddMoreATransaltions(this, txtBoxEnglishWord.Text, txtArabicWord.Text, OldSelectedWord, EditWordMode,T2,T3,T4);
                frmMoreArabicTranslations.ShowDialog();

            }

            if (txtBoxEnglishWord.Text == "" && txtArabicWord.Text == "")
            {
                MessageBox.Show("Please enter English Word and Its Translation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtBoxEnglishWord.Text == "")
            {
                MessageBox.Show("Please enter English Word", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtArabicWord.Text == "")
            {
                MessageBox.Show("Please enter one arabic translation then if you want you can add more.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



        }

        private void frmAddEnglishWord_Load(object sender, EventArgs e)
        {
            btnExit.CausesValidation = false;
        }
        private void txtBoxWord_Validating(object sender, CancelEventArgs e)
        {
            if (txtBoxEnglishWord.Text == null || txtArabicWord.Text == null || txtBoxEnglishWord.Text == "Enter English Word" || txtArabicWord.Text=="Enter Arabic Translation")
            clsUtilControls.ValidateTextBox(sender, txterrorprovider, e,true);
        }

        private void txtWord_Enter(object sender, EventArgs e)
        {
            

            if (((TextBox)sender).Tag.ToString() == "A" && (((TextBox)sender).Text == "" || ((TextBox)sender).Text == "Enter Arabic Translation"))
            {
                txtArabicWord.Clear();
                txtArabicWord.ForeColor = Color.FromArgb(255, 30, 30, 30);
                txtBoxEnglishWord.CausesValidation = false;
            }
            else if (((TextBox)sender).Text == "" || ((TextBox)sender).Text == "Enter English Word")
            {
                txtBoxEnglishWord.Clear();
                txtBoxEnglishWord.ForeColor = Color.FromArgb(255, 30, 30, 30);
                txtArabicWord.CausesValidation = false;
            }
        }

        private void txtWordLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                if (((TextBox)sender).Tag.ToString() == "A")
                {
                    txtArabicWord.Text = "Enter Arabic Translation";
                    txtArabicWord.ForeColor = Color.FromArgb(255, 60, 60, 60);
                    txtBoxEnglishWord.CausesValidation = true;
                }
                else
                {
                    txtBoxEnglishWord.Text = "Enter English Word";
                    txtBoxEnglishWord.ForeColor = Color.FromArgb(255, 60, 60, 60);
                    txtArabicWord.CausesValidation = true;
                }
            }
           }

        private void frmAddEnglishWord_Shown(object sender, EventArgs e)
        {

            txtBoxEnglishWord.Focus();
        }
    }
}
