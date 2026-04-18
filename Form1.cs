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

        private readonly static bool brave = Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\BraveSoftware\\Brave-Browser\\");
        private readonly static bool chrome = Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Google\\Chrome\\");
        private readonly static bool edge = Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Microsoft\\Edge\\");
        private readonly static bool firefox = Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Mozilla\\Firefox\\");
        private readonly static bool opera = Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Opera Software\\Opera Stable\\");
        private readonly static bool operagx = Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() + "\\Opera Software\\Opera GX Stable\\");

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Status: Scanning for browsers";
            string[] item = { "Brave", "Chrome", "Edge", "Firefox", "OperaGX", "Opera" };
            foreach (string browser in item)
            {
                IsProgramInstalled(browser);
            }
            groupBox2.Enabled = true;
            toolStripStatusLabel1.Text = "Status: Idle";
        }

        public bool IsProgramInstalled(string programDisplayName)
        {

            OutputToLog(string.Format("Checking install status of: {0}", programDisplayName));
            if (programDisplayName == "Brave" && brave)
            {
                OutputToLog(string.Format("Browser Found: {0}", programDisplayName));
                checkBoxBrave.Enabled = true;
                return true;
            }
            if (programDisplayName == "Chrome" && chrome)
            {
                OutputToLog(string.Format("Browser Found: {0}", programDisplayName));
                checkBoxChrome.Enabled = true;
                return true;
            }
            if (programDisplayName == "Edge" && edge)
            {
                OutputToLog(string.Format("Browser Found: {0}", programDisplayName));
                checkBoxEdge.Enabled = true;
                return true;
            }
            if (programDisplayName == "Firefox" && firefox)
            {
                OutputToLog(string.Format("Browser Found: {0}", programDisplayName));
                checkBoxFirefox.Enabled = true;
                return true;
            }
            if (programDisplayName == "Opera" && opera)
            {
                OutputToLog(string.Format("Browser Found: {0}", programDisplayName));
                checkBoxOpera.Enabled = true;
                return true;
            }
            if (programDisplayName == "OperaGX" && operagx)
            {
                OutputToLog(string.Format("Browser Found: {0}", programDisplayName));
                checkBoxOperaGX.Enabled = true;
                return true;
            }
            return false;
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var _ = Process.Start(new ProcessStartInfo { FileName = "https://github.com/wired420/CacheKiller", UseShellExecute = true });
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
    }
}
