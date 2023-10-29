using System.Diagnostics;

namespace PhotoFinder
{
    public static class CommandLineHandler
    {
        public static void Command(string script)
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
                Form1.ProgressC = couter;
            }

            myProcess.WaitForExit();
            int exitCode = myProcess.ExitCode;
            if (exitCode == 0)
            {
                MessageBox.Show($"Done!\n{couter} files copied");
            }
            else
            {
                MessageBox.Show($"Error: {exitCode}");
            }
        }
    }
}
