using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Extensions;


namespace vsg_test
{
    public class Program
    {
        Process process = new Process();
        public static string python;
        [STAThread]
        static void Main()
        {
            find_python();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static private void find_python()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = "/C where py";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            using (Process pythonProcess = Process.Start(startInfo))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = pythonProcess.StandardOutput)
                {
                    python = reader.ReadToEnd();
                    Console.Write(python);
                }
            }
            if (!python.Contains("exe"))
            {
                startInfo.Arguments = "/C where python";
                using (Process pythonProcess2 = Process.Start(startInfo))
                {
                    using (StreamReader reader = pythonProcess2.StandardOutput)
                    {
                        python = reader.ReadToEnd();
                        Console.Write(python);
                    }
                }
            }
        }
        public async Task run_python_async(string cmd, string args)
        {
            if (process == null)
            {
                Process process = new Process();
            }
            using (process)
            {
                try
                {
                    process.StartInfo = new ProcessStartInfo
                    {
                        FileName = python,
                        Arguments = string.Format("{0} {1}", cmd, args),
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true
                    };
                    process.EnableRaisingEvents = true;
                    Application.ApplicationExit += new EventHandler(this.CloseProgram);
                    process.Start();
                    await process.WaitForExitAsync();
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.Write(result);
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error:{ex.Message}");
                    return;
                }
            }
        }

        private void CloseProgram(object sender, System.EventArgs e)
        {
            try
            {
                process.Kill();
            }
            catch
            {
                return;
            }
        }
    }
}



