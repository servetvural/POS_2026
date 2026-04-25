using System;
using System.Runtime.InteropServices;

namespace DTRMNS {
    public static class KernelFunctions
    {
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern bool IsIconic(IntPtr hWnd);

        public const int SW_HIDE = 0;
        public const int SW_SHOWNORMAL = 1;
        public const int SW_SHOWMINIMIZED = 2;
        public const int SW_SHOWMAXIMIZED = 3;
        public const int SW_SHOWNOACTIVATE = 4;
        public const int SW_RESTORE = 9;
        public const int SW_SHOWDEFAULT = 10;

        //public static void CheckProcess(AppButton btn)
        //{

        //    string[] SplitProcerssName = btn.ProcessName.Split('.');
        //    string ProcName = SplitProcerssName[0];
        //    Process[] plist = Process.GetProcessesByName(ProcName);
        //    if (plist.Length > 0)
        //    {
        //        if (btn.ProcessType == ProcessTypes.SingleProcess)
        //        {

        //            IntPtr hWnd = plist[0].MainWindowHandle;
        //            // if iconic, we need to restore the window
        //            if (KernelFunctions.IsIconic(hWnd))
        //            {
        //                KernelFunctions.ShowWindowAsync(hWnd, KernelFunctions.SW_RESTORE);
        //            }
        //            // bring it to the foreground
        //            KernelFunctions.SetForegroundWindow(hWnd);
        //            // exit our process
        //            return;
        //        }
        //        else
        //        {
        //            try
        //            {
        //                Process.Start(btn.ShellCommand);
        //            }
        //            catch { }
        //        }
        //    }
        //    else
        //    {
        //        try
        //        {
        //            Process.Start(btn.ShellCommand);
        //        }
        //        catch { }
        //    }
        //}
    }

}
