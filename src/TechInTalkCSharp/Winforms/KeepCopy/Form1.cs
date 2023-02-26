using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeepCopy
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        private IntPtr _ClipboardViewerNext;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ClipboardViewerNext = SetClipboardViewer(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_DRAWCLIPBOARD = 0x308;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    ProcessClipboardValue();
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void ProcessClipboardValue()
        {
            if (Clipboard.ContainsText())
            {
                Debug.WriteLine(Clipboard.GetText());
            }
            else if (Clipboard.ContainsImage())
            {

            }
            else if (Clipboard.ContainsAudio())
            {

            }
        }
    }
}
