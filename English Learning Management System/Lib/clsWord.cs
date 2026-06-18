using English_Learning_Management_System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lib
{
    internal class clsWord
    {
        // This file is fixed and do not change with updates .
        // Application Data folder is a windows safe storage that every app stores its data there and by that it does not get change with updates .
        public static string FixedAppDataFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EnglishLMS");

        public static string FixedAppDataEnglishWordsLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), FixedAppDataFile, "EnglishWords.txt");
        public static string FixedAppDataArabicTLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), FixedAppDataFile, "ArabicTranslationWords.txt");

        public static string FixedCheckedWordsFileLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), FixedAppDataFile, "CheckedStateWords.txt");
        internal static bool SaveEnglishWordsToFile(string EnglishWord, string FileName)
        {
            //if (EnglishWord == "")
            //{
            //    MessageBox.Show("You did'nt enter data", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}

            //else
            //{

            //    if (Append)
            //    {
            //        //using (StreamWriter MyFile = new StreamWriter("Daily Tasks File.txt", true))
            //        //{
            //        //    MyFile.WriteLine(txtTask.Text + "#//#" + txtDeadLine.Text);
            //        //    //MyFile.Dispose();//No need to it because using will automatically calls it and even if an exception happens the using will close the file.
            //        //}

            //        //File.AppendAllText("Daily Tasks File.txt", txtTask.Text + "#//#" + txtDeadLine.Text);
            //        //the previous line closes the file automatically and creates the file if it is not exists and append to the file if it is exists , so it is a shortcut for :
            //        //using (StreamWriter MyFile = new StreamWriter("Daily Tasks File.txt", true))
            //        //{
            //        //    MyFile.WriteLine(txtTask.Text + "#//#" + txtDeadLine.Text);
            //        //    //MyFile.Dispose();//No need to it because using will automatically calls it and even if an exception happens the using will close the file.
            //        //}

            //        //File.AppendAllText("Daily Tasks.txt", txtTask.Text + "#//#" + txtDeadLine.Text + Environment.NewLine()    );//Automatically closes the file and creates it if it is not exists
            //        if (!EnglishWord.Contains(","))
            //            File.AppendAllText(FileName, EnglishWord + "\r\n");//Automatically closes the file and creates it if it is not exists
            //        else
            //        {
            //            using (StreamWriter MyFile = new StreamWriter(FileName, true))
            //            {
            //                while (EnglishWord.Contains(","))
            //                {
            //                    int IndexOfComma = EnglishWord.IndexOf(",");
            //                    string subword = EnglishWord.Substring(0, IndexOfComma);
            //                    EnglishWord=EnglishWord.Remove(0, IndexOfComma + 1);
            //                    MyFile.WriteLine(subword);
            //                }
            //                MyFile.WriteLine(   EnglishWord);
            //                //MyFile.Dispose();//No need to it because using will automatically calls it and even if an exception happens the using will close the file.
            //            }
            //        }
            //    }
            //    //else
            //    //{
            //    //    File.Delete(FileName);
            //    //}
            //    return true;
            //}
            return SaveArabicTranslationsToFile(EnglishWord, FileName, false);
        }

        private static bool _SaveMoreTranslations(string T1, string T2, string T3, string T4, string FileName, bool WithSeparator = true)
        {

            if (T1 != "" && T1 != "Enter Arabic Translation")
            {
                using (StreamWriter MyFile = new StreamWriter(FileName, true))
                {
                    if (WithSeparator)
                    {
                        MyFile.Write("\r\n" + "#//#" + "\r\n" + T1);
                    }
                    else
                        MyFile.Write(T1 + "\r\n");//For English Word

                    if (T2 != "" && T2 != null && T2 != "Enter Arabic Translation 2")
                        MyFile.Write("," + T2);

                    if (T3 != "" && T3 != null && T3 != "Enter Arabic Translation 3")
                        MyFile.Write("," + T3);

                    if (T4 != "" && T4 != null && T4 != "Enter Arabic Translation 4")
                        MyFile.Write("," + T4);

                    return true;
                }
            }
            return false;

        }

        internal  static bool SaveArabicTranslationsToFile(string Translation1, string FileName, bool WithSeparator = true, string Translation2 = null, string Translation3 = null, string Translation4 = null)
        {
            if (Translation1 == "" || Translation1==null)
            {
                MessageBox.Show("You did'nt enter data", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return _SaveMoreTranslations(Translation1, Translation2, Translation3, Translation4, FileName, WithSeparator);

        }

        internal struct stArabicTranslation
        {
            public string Translation1;
            public string Translation2;
            public string Translation3;
            public string Translation4;
        }

        internal static stArabicTranslation ATranslations;

        internal static List<stArabicTranslation> LoadArabicTranslationsFromFile(string FileName)
        {
            List<string> lWords = new List<string>();
            List<stArabicTranslation> lArabicTranslations = new List<stArabicTranslation>();


            if (File.Exists(FileName))
                using (StreamReader MyFile = new StreamReader(FileName))
                {
                    string Line;
                    stArabicTranslation AT;
                    while ((Line = MyFile.ReadLine()) != null)
                    {

                        if (Line != "#//#" && Line != "")
                        {
                            AT = new stArabicTranslation();
                            lWords = Line.Split(new Char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Where(s => !String.IsNullOrEmpty(s)).ToList();
                            for (short i = 0; i < lWords.Count; i++)
                            {
                                if (i == 0)
                                    AT.Translation1 = lWords[i];
                                else if (i == 1)
                                    AT.Translation2 = lWords[i];
                                else if (i == 2)
                                    AT.Translation3 = lWords[i];
                                else if (i == 3)
                                    AT.Translation4 = lWords[i];
                            }
                            lArabicTranslations.Add(AT);
                            lWords.Clear();
                        }

                    }

                }

            //Second Way:
            //string[] arrTasks = File.ReadAllLines(FileName);//Automatically closes file after open it
            //lTasks.AddRange(arrTasks);

            return lArabicTranslations;
        }

        internal static List<string> LoadEnglishWordsFromFile(string FileName)
        {
            List<string> lWords = new List<string>();

            if (File.Exists(FileName))
                using (StreamReader MyFile = new StreamReader(FileName))
                {
                    string Line;

                    while ((Line = MyFile.ReadLine()) != null)
                    {
                        if (Line != "")
                            lWords.Add(Line.Trim());
                    }

                }

            //Second Way:
            //string[] arrTasks = File.ReadAllLines(FileName);//Automatically closes file after open it
            //lTasks.AddRange(arrTasks);

            return lWords;
        }

        internal static void DeleteAllRecords(string EnglishWordsFileName, string ArabicTranslationsFileName,string CheckedWordsFileName)
        {
            if (File.Exists(EnglishWordsFileName))
                File.Delete(EnglishWordsFileName);

            if (File.Exists(ArabicTranslationsFileName))
                File.Delete(ArabicTranslationsFileName);

            if (File.Exists(CheckedWordsFileName))
                File.Delete(CheckedWordsFileName);
        }

      internal static List<int> LoadCheckedWordsIdFromFile(string FileName)
        {
            List<int> lCheckedWordsID = new List<int>();

            if (File.Exists(FileName))
            {
                using (StreamReader MyFile = new StreamReader(FileName))
                {
                    string Line;
                    while ((Line = MyFile.ReadLine()) != null)
                    {
                        if (Line != "")
                            lCheckedWordsID.Add(int.Parse(Line.Trim()));
                    }
                }
            }
            return lCheckedWordsID;
        }

        static int _GetWordLocationId(List<string> lEnglishWords,string SelectedWordToDelete)
        {
            if (lEnglishWords == null)
                return -1;
            else
            {
                for (int i = 0; i < lEnglishWords.Count; i++)
                {
                    if (lEnglishWords[i] == SelectedWordToDelete)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        internal async static void DeleteWord(string SelectedWord, string EnglishFileName, string ArabicTranslationsFileName, string CheckedWordsFileName)
        {
            if (SelectedWord != null)
            {
                List<string> lEnglishWords = LoadEnglishWordsFromFile(EnglishFileName);
                List<stArabicTranslation> lArabicTranslations = LoadArabicTranslationsFromFile(ArabicTranslationsFileName);
                List<int> lCheckedWordsIds = LoadCheckedWordsIdFromFile(clsWord.FixedCheckedWordsFileLocation);

                DeleteAllRecords(EnglishFileName, ArabicTranslationsFileName, CheckedWordsFileName);

               int SelectedWordLocation = _GetWordLocationId(lEnglishWords, SelectedWord);

                if (SelectedWordLocation != -1) 
               lCheckedWordsIds.Remove(SelectedWordLocation);

                for (int i = 0; i < lEnglishWords.Count; i++)
                {
                    if (lEnglishWords[i] != SelectedWord)
                    {
                        SaveEnglishWordsToFile(lEnglishWords[i], EnglishFileName);
                        SaveArabicTranslationsToFile(lArabicTranslations[i].Translation1, ArabicTranslationsFileName, true, lArabicTranslations[i].Translation2, lArabicTranslations[i].Translation3, lArabicTranslations[i].Translation4);
                        
                    }
                }
                for (int j = 0; j < lCheckedWordsIds.Count; j++)
                {
                    if ((SelectedWordLocation < lCheckedWordsIds[j]))
                        frmMainScreen.AddCheckedWordToFile(FixedCheckedWordsFileLocation, lCheckedWordsIds[j] - 1);
                    else 
                        frmMainScreen.AddCheckedWordToFile(FixedCheckedWordsFileLocation, lCheckedWordsIds[j]);

                }
            }
            else
            {
                MessageBox.Show("You must select a word in order to delete it", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static void EditWord(string OldSelectedWord, string NewWord, string EnglishFileName, string ArabicTranslationsFileName, stArabicTranslation Tranalations, string CheckedWordsFileName)
        {
            if (OldSelectedWord != null && NewWord != null)
            {
                List<string> lEnglishWords = LoadEnglishWordsFromFile(EnglishFileName);
                List<stArabicTranslation> lArabicTranslations = LoadArabicTranslationsFromFile(ArabicTranslationsFileName);

                DeleteAllRecords(EnglishFileName, ArabicTranslationsFileName,CheckedWordsFileName);

                for (int i = 0; i < lEnglishWords.Count; i++)
                {
                    if (lEnglishWords[i] != OldSelectedWord)
                    {
                        SaveEnglishWordsToFile(lEnglishWords[i], EnglishFileName);

                        SaveArabicTranslationsToFile(lArabicTranslations[i].Translation1, ArabicTranslationsFileName, true, lArabicTranslations[i].Translation2, lArabicTranslations[i].Translation3, lArabicTranslations[i].Translation4);
                    }
                    else
                    {
                        SaveEnglishWordsToFile(NewWord, EnglishFileName);

                        SaveArabicTranslationsToFile(Tranalations.Translation1, ArabicTranslationsFileName, true, Tranalations.Translation2, Tranalations.Translation3, Tranalations.Translation4);
                    }

                }

            }
            else
            {
                MessageBox.Show("You must Enter Updated Word with its translation/s", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        internal struct stWordExample
        {
            public string ExampleInEnglish;
            public string ExampleInArabic;
        }

        internal static stWordExample WordExample;

        static string T1 = "", T2 = "", T3 = "", T4 = "";

        private static void _FillArabicTranslations(ListViewItem Items)
        {
            for (short i = 1; i < Items.SubItems.Count; i++)
            {
                if (i == 1)
                    T1 = Items.SubItems[i].Text;
                else if (i == 2)
                    T2 = Items.SubItems[i].Text;
                else if (i == 3)
                    T3 = Items.SubItems[i].Text;
                else if (i == 4)
                    T4 = Items.SubItems[i].Text;
            }
        }
        internal static async Task Run(string EnglishWord, ListViewItem LWordArabicTranslations)
        {
            try
            {
                WordExample = new stWordExample();
                _FillArabicTranslations(LWordArabicTranslations);

                string apiKey = Environment.GetEnvironmentVariable("MY_GOOGLE_API_KEY"); // Replace with your API key

                string prompt = $@"
            You are a professional English-Arabic language assistant.
            Task:
            - You are given an English word: '{EnglishWord}'.
            - Write exactly one short, simple, correct English sentence using this word naturally.
            - Translate this sentence into Arabic.
            - For the target word in Arabic, you must use exactly one of the following translations: {T1}, {T2}, {T3}, {T4}.
            - Do not invent or change the Arabic translation in any way.
            - Ensure the Arabic sentence is grammatically correct, clear, and natural.
            - The English sentence should have proper capitalization and punctuation. The Arabic sentence should have proper spacing and use vowel marks (harakāt) if necessary. Do not include commas. The dot at the end is optional.
            - Return strictly in JSON format, like this (no extra text or explanation):
            
            {{
              ""example_en"": ""<English sentence>"",
              ""example_ar"": ""<Arabic sentence using exactly one of the provided translations>""
            }}
            
            Word: {EnglishWord}
            ";



                string url = "https://generativelanguage.googleapis.com/v1/models/gemini-2.5-flash:generateContent";

                object body = new
                {
                    contents = new object[]
                    {
            new
            {
                parts = new object[]
                {
                    new { text = prompt }
                }
            }
                    }
                };

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(body);

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("x-goog-api-key", apiKey);

                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    // HTTP validation
                    if (response == null || !response.IsSuccessStatusCode)
                    {
                        WordExample.ExampleInEnglish = "";
                        WordExample.ExampleInArabic = "";
                        MessageBox.Show(
                            "HTTP error: " + (response != null ? response.StatusCode.ToString() : "No response"),
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }

                    string responseText = await response.Content.ReadAsStringAsync();

                    // Check empty response
                    if (string.IsNullOrWhiteSpace(responseText))
                    {
                        WordExample.ExampleInEnglish = "";
                        WordExample.ExampleInArabic = "";
                        MessageBox.Show("Empty response from API", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Try to get the first candidate and its parts
                    int startCandidates = responseText.IndexOf("\"candidates\":");
                    if (startCandidates < 0)
                    {
                        WordExample.ExampleInEnglish = "";
                        WordExample.ExampleInArabic = "";
                        MessageBox.Show("No candidates found in response", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Use Newtonsoft to parse root JSON safely
                    Newtonsoft.Json.Linq.JObject root;
                    try
                    {
                        root = Newtonsoft.Json.Linq.JObject.Parse(responseText);
                    }
                    catch
                    {
                        WordExample.ExampleInEnglish = "";
                        WordExample.ExampleInArabic = "";
                        MessageBox.Show("API returned invalid JSON", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var candidates = root["candidates"];
                    if (candidates == null || !candidates.HasValues)
                    {
                        WordExample.ExampleInEnglish = "";
                        WordExample.ExampleInArabic = "";
                        MessageBox.Show("No candidates returned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var parts = candidates[0]["content"]?["parts"];
                    if (parts == null || !parts.HasValues)
                    {
                        WordExample.ExampleInEnglish = "";
                        WordExample.ExampleInArabic = "";
                        MessageBox.Show("No parts returned", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string modelText = parts[0]["text"]?.ToString();
                    if (string.IsNullOrWhiteSpace(modelText))
                    {
                        WordExample.ExampleInEnglish = "";
                        WordExample.ExampleInArabic = "";
                        MessageBox.Show("Empty model text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Extract English and Arabic examples manually
                    int enIndex = modelText.IndexOf("\"example_en\":");
                    int arIndex = modelText.IndexOf("\"example_ar\":");

                    if (enIndex < 0 || arIndex < 0)
                    {
                        WordExample.ExampleInEnglish = "";
                        WordExample.ExampleInArabic = "";
                        MessageBox.Show("Missing keys in model text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    /*
                      Regex.Replace finds every character that matches the pattern (everything not in the allowed set)
                      Then it replaces it with "", which is nothing → effectively erasing it
                     */
                    string exampleEnRaw = modelText.Substring(enIndex + 13, arIndex - (enIndex + 13));
                    string exampleEn = Regex.Replace(exampleEnRaw, @"[^a-zA-Z0-9\s.]", "").Trim();

                    string exampleArRaw = modelText.Substring(arIndex + 13);
                    string exampleAr = Regex.Replace(exampleArRaw, @"[^\u0621-\u063A\u0640-\u064A\s0-9]", "").Trim();
                    WordExample.ExampleInEnglish = exampleEn;
                    WordExample.ExampleInArabic = exampleAr;

                    //// Show result in WinForms
                    //MessageBox.Show(
                    //    "English: " + WordExample.ExampleInEnglish + "\nArabic: " + WordExample.ExampleInArabic,
                    //    "Word Example",
                    //    MessageBoxButtons.OK,
                    //    MessageBoxIcon.Information
                    //);
                }
            }
            catch (Exception ex)
            {
                WordExample.ExampleInEnglish = "";
                WordExample.ExampleInArabic = "";
                MessageBox.Show("An error occurred : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static async Task GetAvailableModels(string apiKey)
        {
            string url = "https://generativelanguage.googleapis.com/v1beta/models";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("x-goog-api-key", apiKey);

                HttpResponseMessage response = await client.GetAsync(url);

                // Validate HTTP response
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        "HTTP error: " + response.StatusCode,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                string responseText = await response.Content.ReadAsStringAsync();

                // Validate response content
                if (string.IsNullOrWhiteSpace(responseText))
                {
                    MessageBox.Show(
                        "No data returned from API",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // Display the raw JSON of available models
                MessageBox.Show(
                    responseText,
                    "Available Models",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

        }

        public static void _CopyPreFilledFileToUserAppDataFile(string PreFilledEnglishWordsFilePath,string PreFilledArabicTFilePath)
        {
            //// the Application.StartupPath is where the prefilled file live .
            //string PreExistEnglishFile = Path.Combine(Application.StartupPath, "EnglishWords.txt");
            //string PreExistArabicTFile = Path.Combine(Application.StartupPath, "ArabicTranslationWords.txt");
                      
            // Application.UserAppDataPath is Where the user file will live but it has changes in every update -> so user data here won't be at same path .
            //string UserEnglishFile = Path.Combine(Application.UserAppDataPath, "EnglishWords.txt");
            //string UserArabicTFile = Path.Combine(Application.UserAppDataPath, "ArabicTranslationWords.txt");    
        
            if(!File.Exists(FixedAppDataFile))
            Directory.CreateDirectory(FixedAppDataFile);

            if (File.Exists(FixedAppDataEnglishWordsLocation) && File.Exists(FixedAppDataArabicTLocation))
            {
                List<string> lUserEnglishWords = clsWord.LoadEnglishWordsFromFile(FixedAppDataEnglishWordsLocation);
                List<string> lPreFilledEnglishWords = clsWord.LoadEnglishWordsFromFile(PreFilledEnglishWordsFilePath);
                List<clsWord.stArabicTranslation> PreFilledArabicTranslations = clsWord.LoadArabicTranslationsFromFile(PreFilledArabicTFilePath);
                List<clsWord.stArabicTranslation> lUserArabicTranslations = clsWord.LoadArabicTranslationsFromFile(FixedAppDataArabicTLocation);

                File.Delete(FixedAppDataEnglishWordsLocation);
                File.Delete(FixedAppDataArabicTLocation);

                bool IsWordNeedsModification = false;
                bool IsPreFilledWord = false;
                int CountEnglishWords = 0;


                    foreach (string PreFilledWord in lPreFilledEnglishWords)
                    {

                    foreach (string UserEWord in lUserEnglishWords)
                    {
                        if (PreFilledWord.Trim() == UserEWord.Trim())
                        {
                            if (!((CountEnglishWords + 1) == lUserEnglishWords.Count))
                                if (!((PreFilledArabicTranslations[CountEnglishWords].Translation1 == lUserArabicTranslations[CountEnglishWords].Translation1) && (PreFilledArabicTranslations[CountEnglishWords].Translation2 == lUserArabicTranslations[CountEnglishWords].Translation2) && (PreFilledArabicTranslations[CountEnglishWords].Translation3 == lUserArabicTranslations[CountEnglishWords].Translation3) && (PreFilledArabicTranslations[CountEnglishWords].Translation4 == lUserArabicTranslations[CountEnglishWords].Translation4)))
                                {
                                    clsWord.stArabicTranslation NewTranslations;
                                    NewTranslations.Translation1 = PreFilledArabicTranslations[CountEnglishWords].Translation1;
                                    NewTranslations.Translation2 = PreFilledArabicTranslations[CountEnglishWords].Translation2;
                                    NewTranslations.Translation3 = PreFilledArabicTranslations[CountEnglishWords].Translation3;
                                    NewTranslations.Translation4 = PreFilledArabicTranslations[CountEnglishWords].Translation4;

                                    lUserArabicTranslations[CountEnglishWords] = NewTranslations;
                                    IsWordNeedsModification = true;
                                }
                        }
                        break;
                    }                      
                        

                        if (!IsWordNeedsModification)
                        {
                            clsWord.SaveEnglishWordsToFile(PreFilledWord, FixedAppDataEnglishWordsLocation);
                            clsWord.SaveArabicTranslationsToFile(PreFilledArabicTranslations[CountEnglishWords].Translation1, FixedAppDataArabicTLocation, true, PreFilledArabicTranslations[CountEnglishWords].Translation2, PreFilledArabicTranslations[CountEnglishWords].Translation3, PreFilledArabicTranslations[CountEnglishWords].Translation4);
                        }
                        else
                        {
                            clsWord.SaveEnglishWordsToFile(PreFilledWord, FixedAppDataEnglishWordsLocation);
                            clsWord.SaveArabicTranslationsToFile(lUserArabicTranslations[CountEnglishWords].Translation1, FixedAppDataArabicTLocation, true, lUserArabicTranslations[CountEnglishWords].Translation2, lUserArabicTranslations[CountEnglishWords].Translation3, lUserArabicTranslations[CountEnglishWords].Translation4);
                        }
                        IsWordNeedsModification = false;
                        CountEnglishWords++;

                    
                    }
                

                    CountEnglishWords = 0;

                    foreach (string UserEWord in lUserEnglishWords)
                    {
                        foreach (string PreFilledWord in lPreFilledEnglishWords)
                        {
                            if (UserEWord.Trim() == PreFilledWord.Trim())
                            {
                                IsPreFilledWord = true;
                                break;
                            }
                        }
                        if (!IsPreFilledWord)
                        {
                            clsWord.SaveEnglishWordsToFile(UserEWord, FixedAppDataEnglishWordsLocation);
                            clsWord.SaveArabicTranslationsToFile(lUserArabicTranslations[CountEnglishWords].Translation1, FixedAppDataArabicTLocation, true, lUserArabicTranslations[CountEnglishWords].Translation2, lUserArabicTranslations[CountEnglishWords].Translation3, lUserArabicTranslations[CountEnglishWords].Translation4);
                        }

                        IsPreFilledWord = false;
                        CountEnglishWords++;
                    
                }
            }

            else
            {
                File.Copy(PreFilledEnglishWordsFilePath, FixedAppDataEnglishWordsLocation);
                File.Copy(PreFilledArabicTFilePath, FixedAppDataArabicTLocation);
            }
        }

    }
}
