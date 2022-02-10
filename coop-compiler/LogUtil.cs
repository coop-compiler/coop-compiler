using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace coop_builder
{
    public class LogUtil
    {
        class LogMessage
        {
            public string message;
            public Color color;
        }

        public static Color stage = Color.DarkGoldenrod;
        public static Color section = Color.CornflowerBlue;
        public static Color subSection = Color.NavajoWhite;
        public static Color error = Color.IndianRed;

        private Form form = null;
        private RichTextBox rtb = null;
        private CustomProgressBar cpb = null;
        private bool threadRunning = false;
        private BackgroundWorker logWork = null;
        private BackgroundWorker progressWork = null;

        private Queue<LogMessage> logQueue = new Queue<LogMessage>();
        private readonly object logLock = new object();

        public LogUtil(Form form, RichTextBox rtb, CustomProgressBar cpb)
        {
            this.form = form;
            this.rtb = rtb;
            this.cpb = cpb;
        }

        private void WriteLogMessage(string line, Color color)
        {
            if (color != rtb.ForeColor)
            {
                rtb.SelectionStart = rtb.TextLength;
                rtb.SelectionLength = 0;
                rtb.SelectionColor = color;
            }

            rtb.AppendText(line);
            cpb.Speed();
        }

        private void WriteLogMessagesAsync()
        {
            lock (logLock) { if (logQueue.Count == 0) { return; } }

            form.Invoke(new Action<Control>(BeginUpdate), new object[] { rtb });

            while (true)
            {
                LogMessage logMessage = null;

                lock (logLock)
                {
                    if (logQueue.Count > 0) { logMessage = logQueue.Dequeue(); }
                }

                if (logMessage == null) { break; }


                form.Invoke(new Action<string, Color>(WriteLogMessage), new object[] { logMessage.message, logMessage.color });
            }
            form.Invoke(new Action<Control>(EndUpdate), new object[] { rtb });
        }

        public void Log(string line, Color color)
        {
            var logMessage = new LogMessage();
            logMessage.message = line + "\n";
            logMessage.color = color;
            lock (logLock)
            {
                logQueue.Enqueue(logMessage);
            }
        }

        public void StartThread()
        {
            if (threadRunning) { return; }
            threadRunning = true;
            logWork = new BackgroundWorker();
            logWork.DoWork += delegate (object sender, DoWorkEventArgs e)
            {
                while (threadRunning)
                {
                    System.Threading.Thread.Sleep(250);
                    try { WriteLogMessagesAsync(); } catch { }
                }
            };
            logWork.RunWorkerAsync();

            progressWork = new BackgroundWorker();
            progressWork.DoWork += delegate (object sender, DoWorkEventArgs e)
            {
                while (threadRunning)
                {
                    System.Threading.Thread.Sleep(1000 / 30);
                    try { cpb.Invalidate(); } catch { }
                }
            };
            progressWork.RunWorkerAsync();
        }

        public void EndThread()
        {
            threadRunning = false;
            WriteLogMessagesAsync();
            rtb.Invalidate();
            form.Invalidate();
        }

        /////////////////////////
        /// begin redraw hacks //
        /////////////////////////
        private const int WM_USER = 0x0400;
        private const int EM_SETEVENTMASK = (WM_USER + 69);
        private const int WM_SETREDRAW = 0x0b;
        private IntPtr OldEventMask;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        private void BeginUpdate(Control control)
        {
            SendMessage(control.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);
            OldEventMask = (IntPtr)SendMessage(control.Handle, EM_SETEVENTMASK, IntPtr.Zero, IntPtr.Zero);
        }

        private void EndUpdate(Control control)
        {
            SendMessage(control.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
            SendMessage(control.Handle, EM_SETEVENTMASK, IntPtr.Zero, OldEventMask);
        }

        ////////////////////////
        /// end redraw hacks ///
        ////////////////////////
    }
}
