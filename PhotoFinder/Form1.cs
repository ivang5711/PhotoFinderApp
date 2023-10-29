using System.Diagnostics;
using System.Text;

namespace PhotoFinder
{
    public partial class Form1 : Form
    {
        public string SearchFolder { get; set; } = @"c:\";
        public string Extension { get; set; } = "*";
        public string DestinationFolder { get; set; } = @"c:\";
        public int ProgressB { get; set; } = 500;
        public static int ProgressC { get; set; } = 0;

        public Form1()
        {
            InitializeComponent();
            textBox2.Text = SearchFolder;
            TopMost = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            string[] inputs = temp.Split(' ');

            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = $"*{inputs[i]}*.{Extension}";
            }

            StringBuilder sb = new();
            foreach (string input in inputs)
            {
                sb.Append(input + ", ");
            }

            string result = sb.ToString()[..^2];
            int amount = 0;
            foreach (var item in inputs)
            {
                amount += Directory.GetFiles(SearchFolder, item,
                                           SearchOption.AllDirectories).Length;
            }

            amount *= 3;
            progressBar1.Maximum = amount;
            progressBar1.Value = 0;
            progressBar1.Step = 3;
            progressBar1.Show();
            Command($"for /r \"{SearchFolder}\" %i in ({result}) do copy \"%~fi\" \"{DestinationFolder}\\%~nxi\"");
            progressBar1.Hide();

            void Command(string script)
            {
                string strCmdText;
                strCmdText = $"/C {script}";
                Process myProcess = new();
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = "CMD.exe";
                myProcess.StartInfo.Arguments = strCmdText;
                myProcess.StartInfo.CreateNoWindow = true;
                myProcess.StartInfo.RedirectStandardOutput = true;
                myProcess.Start();
                int couter = 0;
                while (myProcess.StandardOutput.ReadLine() != null)
                {
                    couter++;
                    progressBar1.Increment(1);
                }

                myProcess.WaitForExit();
                int exitCode = myProcess.ExitCode;
                if (exitCode == 0)
                {
                    MessageBox.Show($"Done!\n{couter / 3} files copied");
                }
                else
                {
                    MessageBox.Show($"Error: {exitCode}");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SearchFolder = dialog.SelectedPath;
                textBox2.Text = dialog.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DestinationFolder = dialog.SelectedPath;
                textBox3.Text = dialog.SelectedPath;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Extension = "*CR2";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Extension = "*";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                Extension = "*TIFF*";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Extension = "*PNG*";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Extension = "*JP*G*";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                TopMost = true;
            }
            else
            {
                TopMost = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new();
            fm2.Show();
        }
    }
}