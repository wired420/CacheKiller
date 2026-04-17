using Microsoft.Win32;
using System.Diagnostics;
using System.Security.Policy;
using System.Windows.Forms.VisualStyles;

namespace CacheKiller
{
    public partial class Form1 : Form
    {
        bool firstLine = true;
        List<string> browserList = [];

        public Form1()
        {
            InitializeComponent();
        }

        // Scanner
        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Status: Scanning for browsers";
            string[] item = { "Bravesoft Brave", "Google Chrome", "Microsoft Edge", "Mozilla Firefox", "Opera", "OperaGX" };
            foreach (string browser in item)
            {
                IsProgramInstalled(browser);
            }
            groupBox2.Enabled = true;
            toolStripStatusLabel1.Text = "Status: Idle";
        }

        public bool IsProgramInstalled(string programDisplayName)
        {

            bool edge = false;
            if (File.Exists("C:\\Program Files(x86)\\Microsoft\\Edge\\Application\\msedge.exe") || File.Exists("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe"))
            {
                edge = true;
            }
            var brave = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\brave.exe");
            var opera = Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Opera Software\\Opera Stable\\");
            var operagx = Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Opera Software\\Opera GX Stable\\");
            OutputToLog(string.Format("Checking install status of: {0}", programDisplayName));
            if (programDisplayName == "Bravesoft Brave" && brave != null)
            {
                OutputToLog("Browser Found: Bravesoft Brave");
                CheckSwitch("Brave");
                return true;
            }
            if (programDisplayName == "Microsoft Edge" && edge)
            {
                OutputToLog("Browser Found: Microsoft Edge");
                CheckSwitch("Edge");
                return true;
            }
            if (programDisplayName == "Opera" && opera)
            {
                OutputToLog("Broser Found: Opera Stable");
                CheckSwitch("Opera");
                return true;
            }
            if (programDisplayName == "OperaGX" && operagx)
            {
                OutputToLog("Broser Found: Opera GX Stable");
                CheckSwitch("OperaGX");
                return true;
            }
            foreach (var item in Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall").GetSubKeyNames())
            {
                if (item == null)
                {
                    continue;
                }

                object programName = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\" + item).GetValue("DisplayName");
                if (programName != null)
                {
                    if (programName.ToString().Contains(programDisplayName))
                    {
                        OutputToLog(string.Format("Browser Found: {0}", programName));
                        CheckSwitch(programName.ToString());
                        return true;
                    }
                }
                else
                {
                    continue;
                }
            }
            return false;
        }

        private void CheckSwitch(string programName)
        {
            if (programName.Contains("Brave"))
            {
                checkBoxBrave.Enabled = true;
            }
            else if (programName.Contains("Chrome"))
            {
                checkBoxChrome.Enabled = true;
            }
            else if (programName.Contains("Edge"))
            {
                checkBoxEdge.Enabled = true;
            }
            else if (programName.Contains("Firefox"))
            {
                checkBoxFirefox.Enabled = true;
            }
            else if (programName.Contains("OperaGX"))
            {
                checkBoxOperaGX.Enabled = true;
            }
            else if (programName.Contains("Opera"))
            {
                checkBoxOpera.Enabled = true;
            }
        }

        private void CheckStatus()
        {
            if (!checkBoxBrave.Checked && !checkBoxChrome.Checked && !checkBoxEdge.Checked && !checkBoxFirefox.Checked && !checkBoxOpera.Checked && !checkBoxOperaGX.Checked)
            {
                groupBox3.Enabled = false;
            }
            else
            {
                groupBox3.Enabled = true;
            }
        }

        private void CheckBrowsers()
        {
            if (checkBoxBrave.Checked) { browserList.Add("Brave"); }
            if (checkBoxChrome.Checked) { browserList.Add("Chrome"); }
            if (checkBoxEdge.Checked) { browserList.Add("Edge"); }
            if (checkBoxFirefox.Checked) { browserList.Add("Firefox"); }
            if (checkBoxOpera.Checked) { browserList.Add("Opera"); }
            if (checkBoxOperaGX.Checked) { browserList.Add("OperaGX"); }
        }

        private void OutputToLog(string output)
        {
            if (!firstLine)
            {
                richTextBox1.AppendText("\r\n" + output);
            }
            else
            {
                richTextBox1.AppendText(output);
                firstLine = false;
            }
            richTextBox1.ScrollToCaret();
        }

        private void checkBoxBrave_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void checkBoxChrome_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void checkBoxEdge_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void checkBoxFirefox_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void checkBoxOpera_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void checkBoxOperaGX_CheckedChanged(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Status: Cleaning selected caches";
            DialogResult dialogResult = MessageBox.Show("This operation will close selected browsers that are running entirely. Depending on browser you may lose open tabs.\r\n\r\nAre you sure you wish to continue?", "CacheKiller WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CheckBrowsers();
                if (browserList.Count > 0)
                {
                    foreach (var browser in browserList)
                    {
                        OutputToLog(string.Format("Cleaning: {0}", browser));
                        if (browser == "Brave")
                        {
                            OutputToLog("Closing Brave if running...");
                            KillBrowser("Brave");
                            string[] del = {
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\BraveSoftware\\Brave-Browser\\User Data\\Default\\Cache",
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\BraveSoftware\\Brave-Browser\\User Data\\Default\\Code Cache",
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\BraveSoftware\\Brave-Browser\\User Data\\Default\\GPUCache",
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\BraveSoftware\\Brave-Browser\\User Data\\Default\\Service Worker\\CacheStorage"
                            };
                            DeleteBrowser(del, browser);
                        }
                        if (browser == "Chrome")
                        {
                            OutputToLog("Closing Google Chrome if running...");
                            KillBrowser("Chrome");
                            string[] del = {
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Google\\Chrome\\User Data\\Default\\Cache",
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Google\\Chrome\\User Data\\Default\\Code Cache",
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Google\\Chrome\\User Data\\Default\\GPUCache",
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Google\\Chrome\\User Data\\Default\\Service Worker\\CacheStorage"
                            };
                            DeleteBrowser(del, browser);
                        }
                        if (browser == "Edge")
                        {
                            OutputToLog("Closing Microsoft Edge if running...");
                            KillBrowser("msedge");
                            string[] del = {
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Microsoft\\Edge\\User Data\\Default\\Cache",
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Microsoft\\Edge\\User Data\\Default\\Code Cache",
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Microsoft\\Edge\\User Data\\Default\\GPUCache",
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Microsoft\\Edge\\User Data\\Default\\Service Worker\\CacheStorage"
                            };
                            DeleteBrowser(del, browser);
                        }
                        if (browser == "Firefox")
                        {
                            OutputToLog("Closing Firefox if running...");
                            KillBrowser("Firefox");
                            string[] del = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Mozilla\\Firefox\\Profiles", "cache2", SearchOption.AllDirectories);
                            if (del.Length > 0)
                            {
                                DeleteBrowser(del, browser);
                            }
                        }
                        if (browser == "Opera")
                        {
                            OutputToLog("Closing Opera if running...");
                            KillBrowser("Opera");
                            string[] del = { Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Opera Software\\Opera Stable\\Default\\Cache" };
                            DeleteBrowser(del, browser);
                        }
                        if (browser == "OperaGX")
                        {
                            OutputToLog("Closing Opera GX if running...");
                            KillBrowser("Opera");
                            string[] del = { Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Opera Software\\Opera GX Stable\\Default\\Cache" };
                            DeleteBrowser(del, browser);
                        }
                        OutputToLog(string.Format("{0}: Complete.", browser));
                    }
                }
                else
                {
                    // Just in case someone finds a way.
                    OutputToLog("You must select at least one browser to clean.");
                    return;
                }
                toolStripStatusLabel1.Text = "Status: Idle";
            }
            else if (dialogResult == DialogResult.No)
            {
                OutputToLog("CacheKiller cancelling operation.");
                toolStripStatusLabel1.Text = "Status: Idle";
                return;
            }
        }

        private void DeleteBrowser(string[] del, string browser)
        {
            foreach (string i in del)
            {
                if (i != null && Directory.Exists(i))
                {
                    OutputToLog(string.Format("{0}: Deleting {1}", browser, i));
                    Directory.Delete(i, true);
                }
            }
        }

        private void KillBrowser(string browser)
        {
            foreach (var process in Process.GetProcessesByName(browser))
            {
                try
                {
                    process.Kill();
                    // Optional: Wait for the process to actually finish exiting
                    process.WaitForExit();
                }
                catch (Exception ex)
                {
                    // Handle potential Access Denied or "Process already exited" errors
                    Console.WriteLine($"Could not kill process: {ex.Message}");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var _ = Process.Start(new ProcessStartInfo { FileName = "https://github.com/wired420/CacheKiller", UseShellExecute = true });
        }
    }
}
