using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Synthesis;
using NAudio.Dsp;

namespace Lib
{
    public class clsLib
    {
        
        private static bool ContainsArabic(string text)
        {
            foreach (char c in text)
            {
                if (c >= 0x0600 && c <= 0x06FF)
                    return true;
            }
            return false;
        }


        static System.Speech.Synthesis.SpeechSynthesizer _speaker = new System.Speech.Synthesis.SpeechSynthesizer();
       static Microsoft.Speech.Synthesis.SpeechSynthesizer _speakerMOD = null;

        public static bool isDefaultOutputSet = false;
        public static void SpellAWordMOD(string Word)
        {
            _speakerMOD = new Microsoft.Speech.Synthesis.SpeechSynthesizer();

            if (!isDefaultOutputSet)
            {
                _speakerMOD.SetOutputToDefaultAudioDevice();
                isDefaultOutputSet = true;
                SpellAWordMOD(Word);
                return;
            }
            _speakerMOD.SpeakAsync(Word);
        }

        public static void PrintAsMsgBoxInstalledVoicesMOD()
        {
            // create the synthesizer
            using (Microsoft.Speech.Synthesis.SpeechSynthesizer speaker = new Microsoft.Speech.Synthesis.SpeechSynthesizer())
            {
                // set output first
                speaker.SetOutputToDefaultAudioDevice();

                // iterate installed voices safely
                foreach (Microsoft.Speech.Synthesis.InstalledVoice voice in speaker.GetInstalledVoices())
                {
                    Microsoft.Speech.Synthesis.VoiceInfo info = voice.VoiceInfo;

                    MessageBox.Show(
                        $"Name: {info.Name}\nCulture: {info.Culture}\nGender: {info.Gender}\nID : {info.Id}",
                        "Installed Voices",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        public static void SpellAWordLEGACY(string Word)
        {
            _speaker.SpeakAsync(Word);
        }

        public static void PrintAsMsgBoxInstalledVoicesLEGACY()
        {
            // create the synthesizer
            using (System.Speech.Synthesis.SpeechSynthesizer speaker = new System.Speech.Synthesis.SpeechSynthesizer())
            {
                // set output first
                speaker.SetOutputToDefaultAudioDevice();

                // iterate installed voices safely
                foreach (System.Speech.Synthesis.InstalledVoice voice in speaker.GetInstalledVoices())
                {
                    System.Speech.Synthesis.VoiceInfo info = voice.VoiceInfo;

                    MessageBox.Show(
                        $"Name: {info.Name}\nCulture: {info.Culture}\nGender: {info.Gender}",
                        "Installed Voices",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        public static void ChangeSpellVoice(string VoiceName)
        {
            _speaker.SelectVoice(VoiceName);
        }
        public static List<Microsoft.Speech.Synthesis.InstalledVoice> GetAllModernInstalledVoices()
        {
            Microsoft.Speech.Synthesis.SpeechSynthesizer speaker = new Microsoft.Speech.Synthesis.SpeechSynthesizer();

                List<Microsoft.Speech.Synthesis.InstalledVoice> LInstalledVoices =new List<Microsoft.Speech.Synthesis.InstalledVoice> { };
                LInstalledVoices.AddRange(speaker.GetInstalledVoices());

            return LInstalledVoices;
        }

        public static void ChangeSpellVoiceMOD(Microsoft.Speech.Synthesis.InstalledVoice Sendedvoice)
        {

            using (Microsoft.Speech.Synthesis.SpeechSynthesizer speaker = new Microsoft.Speech.Synthesis.SpeechSynthesizer())
            {
                _speakerMOD = new Microsoft.Speech.Synthesis.SpeechSynthesizer();

                // set output first
                speaker.SetOutputToDefaultAudioDevice();
                // iterate installed voices safely
                foreach (Microsoft.Speech.Synthesis.InstalledVoice voice in speaker.GetInstalledVoices())
                {
                    if (Sendedvoice.VoiceInfo.Name == voice.VoiceInfo.Name)
                    {
                        _speakerMOD.SelectVoice(voice.VoiceInfo.Name);
                        return;
                    }
                }
                MessageBox.Show("FAIL");

            }
        }
        public static void ChangeFormProperties(Form frm, short MaxWidth,short MaxHeight)
        {
            frm.StartPosition= FormStartPosition.CenterScreen;
            frm.MaximizeBox = false;
            frm.MinimumSize = new Size(MaxWidth, MaxHeight);
            frm.MaximumSize=new Size(MaxWidth, MaxHeight);
        }
       static Random random = new Random();
        public static short GetARandomNumber(short From, short To)
        {

            short Number = Convert.ToInt16(random.Next(From, To));
            return Number;
        }

        public static void RunHoverSound()
        {
            SoundPlayer P=new SoundPlayer(@"D:\My Projects\English Learning Management System\bin\Release\Hover.wav");
            P.Play();
        }
        public static void RunWiningSound()
        {
            SoundPlayer P = new SoundPlayer(@"D:\My Projects\English Learning Management System\bin\Release\Win.wav");
            P.Play();
        }

        public static void RunLoseOrLeaveSound()
        {
            SoundPlayer P = new SoundPlayer(@"D:\My Projects\English Learning Management System\bin\Release\Lose,Leave.wav");
            P.Play();
        }
        public static void RunClickSound()
        {
            SoundPlayer P = new SoundPlayer(@"D:\My Projects\English Learning Management System\bin\Release\Click.wav");
            P.Play();
        }
    }
}
