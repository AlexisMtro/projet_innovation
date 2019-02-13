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
        SpeechRecognitionEngine RecEngin = new SpeechRecognitionEngine();
        bool CurrentFunction = false;
        string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command, StringBuilder retstring, int Returnlenth, IntPtr callback);
        Choices commands = new Choices();
        Grammar grammar;
        GrammarBuilder gBuilder;


        public Form1()
        {
            InitializeComponent();
            mciSendString("open new Type waveaudio alias recsound", null, 0, IntPtr.Zero);
            //ButtonStopRecord.Click += new EventHandler(this.Button1_Click);

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            /*
            mciSendString("save recsound C:\\Users\\Hadenos_EZ\\Desktop\\Test_Audio\\Value.wav", null, 0, IntPtr.Zero);
            mciSendString("close recsound ", null, 0, IntPtr.Zero);
            */
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



            if (CurrentFunction == false)
            {
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
            }


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
                    WriteFile("testInnovation.txt");
                    break;
                case "print my name":
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (TextBoxPath.Text != null)
            {
                if (CheckIsAFile(TextBoxPath.Text))
                {
                    GetSream(TextBoxPath.Text);
                }
                else
                {
                    MessageBox.Show("Le fichier spécifier n'éxiste pas.", "Erreur");
                }

            }
            else
            {
                MessageBox.Show("Le champs <Chemin du fichier> doit être remplit pour pouvoir utiliser les fonctions", "Erreur");
            }
        }

        private void FileTraitement()
        {
            string[] tab = richTextBox1.Lines;
            for (int i = 0; i < tab.Length; i++)
            {
                int index = i+1;
                tab[i] = index.ToString()+ " : " + tab[i].ToString();
            }
            richTextBox1.Lines = tab;
            this.Hide();
            this.Show();
        }

        private bool CheckIsAFile(String UserFilePath)
        {
            string pathuser = Path.Combine(path, UserFilePath);
            if (File.Exists(pathuser))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void GetSream(string UserFilePath)
        {
            //Nom du fichier de stream
            string FileStream = "StreamVoidReader.txt";
            string pathuser = Path.Combine(path, UserFilePath);
            string PathFileStreamer = Path.Combine(Application.StartupPath, FileStream);

            //Copier le contenu du fichier local dans un fichier externe pour visualisation et modification.
            if (!File.Exists(PathFileStreamer))
            {
                File.Copy(pathuser, PathFileStreamer);
                richTextBox1.Text = File.ReadAllText(PathFileStreamer);
                FileTraitement();
            }
            else
            {
                richTextBox1.Text = File.ReadAllText(PathFileStreamer);
                FileTraitement();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string FileStream = "StreamVoidReader.txt";
         
            string PathFileStreamer = Path.Combine(Application.StartupPath, FileStream);

            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string UserFilePath = openFileDialog1.FileName;
                    string pathuser = Path.Combine(path, UserFilePath);
                    string text = File.ReadAllText(file);
                    File.Copy(pathuser, PathFileStreamer);
                    richTextBox1.Text = File.ReadAllText(PathFileStreamer);
                    TextBoxPath.Text = PathFileStreamer; 
                    FileTraitement();
                }
                catch (IOException)
                {
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }

}
