using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        bool CurrentFunction = false; 
        string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command, StringBuilder retstring, int Returnlenth, IntPtr callback);
        SpeechRecognitionEngine RecEngin = new SpeechRecognitionEngine();
        Choices commands = new Choices();
        Grammar grammar;
        GrammarBuilder gBuilder;


        public Form1()
        {
            InitializeComponent();
            mciSendString("open new Type waveaudio alias recsound", null, 0, IntPtr.Zero);
            ButtonStopRecord.Click += new EventHandler(this.Button1_Click);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                RecEngin.LoadGrammarAsync(grammar);
                RecEngin.RecognizeAsyncStop();
            }
            catch
            {
                MessageBox.Show("Vous n'avez pas de microphone connecté. Vous devez avoir un microphone pour utiliser l'application correctement.", "Erreur");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WriteFile(TraitementPath(PathFile.Text));
            /*
            if (CurrentFunction == false)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\celia\\Desktop\\testg.gif");
                commands.Add(new string[] { "test", "print my name" });
                gBuilder = new GrammarBuilder();
                gBuilder.Append(commands);
                grammar = new Grammar(gBuilder);
                RecEngin.LoadGrammarAsync(grammar);
                RecEngin.SetInputToDefaultAudioDevice();
                RecEngin.RecognizeAsync(RecognizeMode.Multiple);
                RecEngin.SpeechRecognized += RecognizeWord;
                CurrentFunction = true;
            }
            else
            {
                RecEngin.RecognizeAsyncStop();
                CurrentFunction = false;
                pictureBox1.Image = null; 
            }
            */
        }
        public string TraitementPath(string TextBoxPath)
        {
            string TraitementPath = TextBoxPath ;
            TraitementPath.Replace("/", "\\");
            TraitementPath.Replace("\"", "\\");
            return TraitementPath; 
        }
        public void WriteFile(string fn)
        {
            string filename = System.IO.Path.Combine(path, fn);
            if (System.IO.File.Exists(filename))
            {
                using (var sw = new StreamWriter(filename, true))
                {
                    sw.WriteLine("On a reussi à écrire dans le fichier.");
                }
            }
        }
        void RecognizeWord(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "test":
                    WriteFile(TraitementPath(PathFile.Text));
                    break;
                case "print my name":
                    break;
            }
        }

    }
}
