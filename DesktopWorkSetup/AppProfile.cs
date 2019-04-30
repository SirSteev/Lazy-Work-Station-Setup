using System;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesktopWorkSetup
{
    class AppProfile
    {
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public string appNickname;

        public int positionX;
        public int positionY;
        public int width;
        public int height;
        
        public string filePath;
        public string windowName;

        public bool requiresCredentials;
        public bool isWebsite;
        public bool isNewTab;

        public int loadTime;

        private bool testRun = false;

        public AppProfile(string _appNickname, int _positionX, int _positionY, int _width, int _height, string _filePath, string _windowName, bool _requiresCredentials, bool _isWebsite, bool _isNewTab, int _loadTime)
        {
            appNickname = _appNickname;

            positionX = _positionX;
            positionY = _positionY;
            width = _width;
            height = _height;

            filePath = _filePath;
            windowName = _windowName;

            requiresCredentials = _requiresCredentials;
            isWebsite = _isWebsite;
            isNewTab = _isNewTab;

            loadTime = _loadTime;
        }

        public AppProfile(string[] _parse)
        {
            appNickname = _parse[0];

            filePath = _parse[1];
            windowName = _parse[2];

            positionX = Int32.Parse(_parse[3]);
            positionY = Int32.Parse(_parse[4]);
            width = Int32.Parse(_parse[5]);
            height = Int32.Parse(_parse[6]);

            requiresCredentials = Convert.ToBoolean(_parse[7]);
            isWebsite = Convert.ToBoolean(_parse[8]);
            isNewTab = Convert.ToBoolean(_parse[9]);

            loadTime = Int32.Parse(_parse[10]);
        }

        public string[] GetToFileFormat()
        {
            string[] format = new string[11];
            
            format[0] = appNickname;

            format[1] = filePath;
            format[2] = windowName;

            format[3] = positionX.ToString();
            format[4] = positionY.ToString();
            format[5] = width.ToString();
            format[6] = height.ToString();

            format[7] = requiresCredentials.ToString();
            format[8] = isWebsite.ToString();
            format[9] = isNewTab.ToString();

            format[10] = loadTime.ToString();

            return format;
        }

        public void Run(string userName, string password)
        {
            try
            {
                if (isWebsite && !isNewTab)
                {
                    Process process = new Process();
                    process.StartInfo.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
                    process.StartInfo.Arguments = filePath + " --new-window";
                    process.Start();
                }
                else
                {
                    Process.Start(filePath);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(appNickname + " file path was not found. Application skipped.", "Error");
                return;
            }


            Thread.Sleep(loadTime);

            try
            {
                MoveWindow(GetWindowProcess(windowName).MainWindowHandle, positionX, positionY, width, height, false);
            }
            catch(Exception err)
            {
                if (!isNewTab)
                {
                    MessageBox.Show(appNickname + "'s window name was not found. window move and/or login was skipped.", "Error");
                    return;
                }
                else if (requiresCredentials)
                {
                    if (MessageBox.Show(appNickname + "'s window name was not found. Do you wish to attempt login?", "Error", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            
            if (requiresCredentials)
            {
                for (int index = 0; index < userName.Length; index++)
                {
                    SendKeys.SendWait(userName[index].ToString());
                    Thread.Sleep(10);
                }

                if (!testRun)
                {
                    SendKeys.SendWait("{TAB}");
                    for (int index = 0; index < password.Length; index++)
                    {
                        SendKeys.SendWait(password[index].ToString());
                        Thread.Sleep(10);
                    }
                    SendKeys.SendWait("{ENTER}");
                    testRun = false;
                }
                
                if (isNewTab)
                {
                    SendKeys.SendWait("^1");
                }
            }
        }

        public void Test()
        {
            testRun = true;
            Run("TESTING", "");
        }

        private Process GetWindowProcess(string windowTitle)
        {
            Process[] procs = Process.GetProcesses();

            foreach (var proc in procs)
            {
                try
                {
                    if (proc.MainWindowTitle == windowTitle)
                    {
                        return proc;
                    }
                }
                catch { }
            }
            return new Process();
        }
    }
}
