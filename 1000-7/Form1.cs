using System.DirectoryServices.ActiveDirectory;
using static System.Windows.Forms.LinkLabel;

namespace _1000_7
{
    public partial class Form1 : Form
    {
        string line;
        Random ded = new Random();
        List<string> spisok = new List<string>() { "deadinside✓", "emo✓", "drain✓", "epileptic✓", "paranoid✓", "toxic✓", "bipolar✓", "depressed✓", "tilted✓", "antisocial✓", "sad✓", "broken✓", "aggressive✓", "psycho✓", "apathetic✓" };


        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("1000-7.txt"))
            {
                var stream = File.Create("1000-7.txt");
                stream.Close();
                File.WriteAllText("1000-7.txt", "1000");
            }

            StreamReader sr = new StreamReader("1000-7.txt");
            line = sr.ReadLine();
            sr.Close();

            textBox1.Text = line;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int i = ded.Next(0, 14);

            MessageBox.Show(spisok[i], "");
            File.WriteAllText("1000-7.txt", Convert.ToString(Convert.ToInt32(line) - 7));
            StreamReader sr = new StreamReader("1000-7.txt");
            line = sr.ReadLine();
            sr.Close();
            textBox1.Text = line;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}