using System;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesktopWorkSetup
{
    class AppProfile
    {
        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

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

        private bool longLoad = false;

        public AppProfile(string _appNickname, int _positionX, int _positionY, int _width, int _height, string _filePath, string _windowName, bool _requiresCredentials, bool _isWebsite, bool _isNewTab)
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
        }

        public AppProfile(string _appNickname, string _filePath)
        {
            appNickname = _appNickname;

            positionX = 0;
            positionY = 0;
            width = 0;
            height = 0;

            filePath = _filePath;
            windowName = string.Empty;

            requiresCredentials = false;
            isWebsite = false;
            isNewTab = false;

            longLoad = true;
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

            longLoad = Convert.ToBoolean(_parse[10]);
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

            format[10] = longLoad.ToString();

            return format;
        }

        public void Run(string userName, string password)
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
            

            if (!longLoad)
            {
                Thread.Sleep(3000);

                try
                {
                    MoveWindow(GetWindowProcess(windowName).MainWindowHandle, positionX, positionY, width, height, false);
                }
                catch(Exception err)
                {
                    MessageBox.Show("Program failed to load or was not found. window move and/or login was skipped." + Environment.NewLine + err, "Error");
                    return;
                }
                
                if (requiresCredentials)
                {
                    for (int index = 0; index < userName.Length; index++)
                    {
                        SendKeys.SendWait(userName[index].ToString());
                        Thread.Sleep(10);
                    }
                    SendKeys.SendWait("{TAB}");
                    for (int index = 0; index < password.Length; index++)
                    {
                        SendKeys.SendWait(password[index].ToString());
                        Thread.Sleep(10);
                    }
                    SendKeys.SendWait("{ENTER}");

                    if (isNewTab)
                    {
                        SendKeys.SendWait("^1");
                    }
                }
            }
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
