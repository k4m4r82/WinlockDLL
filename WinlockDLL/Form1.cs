using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace WinlockDLLCSharp
{    
    public partial class Form1 : Form
    {

        [DllImport("WinLockDll.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern IntPtr TaskManager_Enable_Disable(bool bEnableDisable);

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnableTaskManager_Click(object sender, EventArgs e)
        {            
            TaskManager_Enable_Disable(true);
        }

        private void btnDisableTaskManager_Click(object sender, EventArgs e)
        {
            TaskManager_Enable_Disable(false);   
        }
    }
}

