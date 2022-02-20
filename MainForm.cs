using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Ashraf_Letters_Speaker_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) => textBox1.Text = Validate_Speak_Letter(e);

        private string SpeakLetter(string _text)
        {
            // upper case : 65 to 90
            //lower case : 97 to 122
            //space 32
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.SetOutputToDefaultAudioDevice();
            speechSynthesizer.Speak(_text);
            return _text;
        }

        private string Validate_Speak_Letter(KeyEventArgs e)
        {
            int _keyCode = (int)e.KeyCode;
            if ((_keyCode >= 65 && _keyCode <= 90) ||
                    (_keyCode >= 97 && _keyCode <= 122))
            {
                string letter = e.KeyCode.ToString();
                SpeakLetter(letter);
                return letter;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
