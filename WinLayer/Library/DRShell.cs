using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace WinLayer;
public class DRShell
{
    public DRShell()
    {     
    }

    #region Win32 FUNCTION IMPORTS
    //[DllImport("user32.dll", CharSet = CharSet.Auto)]
    //public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);


    [DllImport("user32.dll")]
    public static extern bool ExitWindowsEx(uint flags, uint reason);

    [DllImport("user32.dll")]
    public static extern bool ExitWindowsEx(ShutdownMethod uMethod, ShutdownReason dwReason);

    [DllImport("user32")]
    public static extern int ExitWindowsEx(int uFlags, int dwReserved);

    [DllImport("advapi32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, UInt32 BufferLength, IntPtr PreviousState, IntPtr ReturnLength);

    [DllImport("advapi32.dll", SetLastError = true)]
    static extern bool OpenProcessToken(IntPtr ProcessHandle, UInt32 DesiredAccess, out IntPtr TokenHandle);

    [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    static extern bool LookupPrivilegeValue(string lpSystemName, string lpName, out LUID lpLuid);

    [DllImport("advapi32")]
    public static extern bool LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, out int phToken);

    [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    public static extern bool LogonUser(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, ref IntPtr phToken);

    [DllImport("advapi32")]
    public static extern bool LogonUserEx(string lpszUsername, string lpszDomain, string lpszPassword, int dwLogonType, int dwLogonProvider, out object phToken, out object ppLogonSid, out object bppProfileBuffer, out object pdwProfileLength, out object pQuotaLimits);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

    //[DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
    //private unsafe static extern int FormatMessage(int dwFlags, ref IntPtr lpSource, int dwMessageId, int dwLanguageId, ref String lpBuffer, int nSize, IntPtr* Arguments);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    public extern static bool CloseHandle(IntPtr handle);

    [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public extern static bool DuplicateToken(IntPtr ExistingTokenHandle, int SECURITY_IMPERSONATION_LEVEL, ref IntPtr DuplicateTokenHandle);

    #endregion

    #region Win32 ENUM DEFINITIONS

    [StructLayout(LayoutKind.Sequential)]
    private struct TOKEN_PRIVILEGES
    {
        public int PrivilegeCount;
        public LUID Luid;
        public int Attributes;
    }

    [StructLayout(LayoutKind.Sequential)]
    private struct LUID
    {
        public uint LowPart;
        public uint HighPart;
    }

    private const int TOKEN_QUERY = 0x08;
    private const int TOKEN_ADJUST_PRIVILEGES = 0x20;
    private const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
    private const int SE_PRIVILEGE_ENABLED = 0x02;


    public const int EWX_LOGOFF = 0;
    public const int EWX_POWEROFF = 8;
    public const int EWX_REBOOT = 2;
    public const int EWX_SHUTDOWN = 1;
    public const int EWX_FORCE = 4;
    public const int EWX_FORCEIFHUNG = 16;


    // Constants used by LogonUser
    public const int LOGON32_PROVIDER_DEFAULT = 0;
    public const int LOGON32_PROVIDER_WINNT50 = 3;
    public const int LOGON32_PROVIDER_WINNT40 = 2;
    public const int LOGON32_PROVIDER_WINNT35 = 1;

    public const int LOGON32_LOGON_INTERACTIVE = 2;
    public const int LOGON32_LOGON_NETWORK = 3;
    public const int LOGON32_LOGON_BATCH = 4;
    public const int LOGON32_LOGON_SERVICE = 5;


    /// <summary>
    /// Defines the methods of shutting down the system.
    /// </summary>
    [Flags]
    public enum ShutdownMethod : uint
    {
        LogOff = 0x00,
        ShutDown = 0x01,
        Reboot = 0x02,
        Force = 0x04,
        PowerOff = 0x08,
        ForceIfHung = 0x10
    }

    /// <summary>
    /// Defines the reason for the shutdown of the system.
    /// </summary>
    [Flags]
    public enum ShutdownReason : uint
    {
        MajorApplication = 0x00040000,
        MajorHardware = 0x00010000,
        MajorLegacyApi = 0x00070000,
        MajorOperatingSystem = 0x00020000,
        MajorOther = 0x00000000,
        MajorPower = 0x00060000,
        MajorSoftware = 0x00030000,
        MajorSystem = 0x00050000,

        MinorBlueScreen = 0x0000000F,
        MinorCordUnplugged = 0x0000000b,
        MinorDisk = 0x00000007,
        MinorEnvironment = 0x0000000c,
        MinorHardwareDriver = 0x0000000d,
        MinorHotfix = 0x00000011,
        MinorHung = 0x00000005,
        MinorInstallation = 0x00000002,
        MinorMaintenance = 0x00000001,
        MinorMMC = 0x00000019,
        MinorNetworkConnectivity = 0x00000014,
        MinorNetworkCard = 0x00000009,
        MinorOther = 0x00000000,
        MinorOtherDriver = 0x0000000e,
        MinorPowerSupply = 0x0000000a,
        MinorProcessor = 0x00000008,
        MinorReconfig = 0x00000004,
        MinorSecurity = 0x00000013,
        MinorSecurityFix = 0x00000012,
        MinorSecurityFixUninstall = 0x00000018,
        MinorServicePack = 0x00000010,
        MinorServicePackUninstall = 0x00000016,
        MinorTermSrv = 0x00000020,
        MinorUnstable = 0x00000006,
        MinorUpgrade = 0x00000003,
        MinorWMI = 0x00000015,

        FlagUserDefined = 0x40000000,
        FlagPlanned = 0x80000000
    }
    #endregion

    #region LOGIN LOGOFF POWEROFF SHUTDOWN RESTART FUNCTIONS
    public static bool LoginUser(string strUserID, string strPassword)
    {
        int Token;
        if (LogonUser(strUserID, ".", strPassword, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, out Token))
        {
            return true;
        } else
        {
            return false;
        }
    }
    public static bool LoginUser(string lpszUsername, string lpszDomain, string lpszPassword,
        int dwLogonType, int dwLogonProvider, out object phToken, out object ppLogonSid, out object bppProfileBuffer,
        out object pdwProfileLength, out object pQuotaLimits)
    {
        return LogonUserEx(lpszUsername, lpszDomain, lpszPassword,
            dwLogonType, dwLogonProvider, out phToken, out ppLogonSid, out bppProfileBuffer,
            out pdwProfileLength, out pQuotaLimits);
    }

    public static void Logoff()
    {
        ExitWindowsEx(EWX_LOGOFF + EWX_FORCE, 0);
    }

    public static void PowerOff()
    {
        ExitWindowsEx(EWX_POWEROFF + EWX_FORCE, 0);
    }
    public static void Reboot()
    {
        ExitWindowsEx(EWX_REBOOT + EWX_FORCE, 0);
    }
    public static void RebootComputer()
    {
        try
        {
            Shutdown(ShutdownMethod.Reboot);
        } catch { }
    }
    public static void ShutDown()
    {
        ExitWindowsEx(EWX_SHUTDOWN + EWX_FORCE, 0);
    }
    public static void ShutDownComputer()
    {
        try
        {
            Shutdown(ShutdownMethod.ForceIfHung);
        } catch { }
    }

    /// <summary>
    /// Properly adjusts the shutdown privilege for this process and shuts down Windows.
    /// </summary>
    /// <param name="Method">The method to use for shutdown.</param>
    /// <returns>True on success, false on error.</returns>
    static public bool Shutdown(ShutdownMethod Method)
    {
        // Adjust the process privilege
        bool ret = AdjustShutdownTokenPriveleges();
        if (!ret)
            return false;

        // exit windows
        return ExitWindowsEx(Method, ShutdownReason.FlagPlanned);
    }

    /// <summary>
    /// Properly adjusts the shutdown privilege for this process and shuts down Windows.
    /// </summary>
    /// <param name="Method">The method to use for shutdown.</param>
    /// <param name="Reason">The reason for the shutdown action.</param>
    /// <returns>True on success, false on error.</returns>
    static public bool Shutdown(ShutdownMethod Method, ShutdownReason Reason)
    {
        // Adjust the process privilege
        bool ret = AdjustShutdownTokenPriveleges();
        if (!ret)
            return false;

        // exit windows
        return ExitWindowsEx(Method, Reason);
    }



    /// <summary>
    /// Adjust the token of the current process to include shutdown privileges.
    /// </summary>
    /// <returns>True on success, false on error.</returns>
    static private bool AdjustShutdownTokenPriveleges()
    {
        bool ret;

        IntPtr hProc = IntPtr.Zero;
        IntPtr hToken = IntPtr.Zero;
        LUID luidRestore;
        TOKEN_PRIVILEGES tokenPriviliges;

        // get the current current process security token
        hProc = System.Diagnostics.Process.GetCurrentProcess().Handle;
        ret = OpenProcessToken(hProc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, out hToken);
        if (!ret)
            return false;


        // lookup the LUID for the shutdown privilege
        ret = LookupPrivilegeValue(String.Empty, SE_SHUTDOWN_NAME, out luidRestore);
        if (!ret)
            return false;

        // adjust the privileges of the current process to include the shutdown privilege
        tokenPriviliges.PrivilegeCount = 1;
        tokenPriviliges.Luid = luidRestore;
        tokenPriviliges.Attributes = SE_PRIVILEGE_ENABLED;

        TOKEN_PRIVILEGES tokenTemp = new TOKEN_PRIVILEGES();

        ret = AdjustTokenPrivileges(hToken, false, ref tokenPriviliges, 0, IntPtr.Zero, IntPtr.Zero);
        if (!ret)
            return false;

        return true;
    }

    #endregion

    #region PRINTER FUNCTIONS AND DECLARATIONS AND DLL IMPORTS
    // Structure and API declarions:
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public class DOCINFOA
    {
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDocName;
        [MarshalAs(UnmanagedType.LPStr)]
        public string pOutputFile;
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDataType;
    }
    [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

    [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool ClosePrinter(IntPtr hPrinter);

    [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

    [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool EndDocPrinter(IntPtr hPrinter);

    [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool StartPagePrinter(IntPtr hPrinter);

    [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool EndPagePrinter(IntPtr hPrinter);

    [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
    public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);


    // When the function is given a printer name and an unmanaged array
    // of bytes, the function sends those bytes to the print queue.
    // Returns true on success, false on failure.
    public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
    {
        Int32 dwError = 0, dwWritten = 0;
        IntPtr hPrinter = new IntPtr(0);
        DOCINFOA di = new DOCINFOA();
        bool bSuccess = false; // Assume failure unless you specifically succeed.

        di.pDocName = "My C#.NET RAW Document";
        di.pDataType = "RAW";

        // Open the printer.
        if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
        {
            // Start a document.
            if (StartDocPrinter(hPrinter, 1, di))
            {
                // Start a page.
                if (StartPagePrinter(hPrinter))
                {
                    // Write your bytes.
                    bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                    EndPagePrinter(hPrinter);
                }
                EndDocPrinter(hPrinter);
            }
            ClosePrinter(hPrinter);
        }
        // If you did not succeed, GetLastError may give more information about why not.
        if (bSuccess == false)
        {
            dwError = Marshal.GetLastWin32Error();
        }
        return bSuccess;
    }

    public static bool SendStringToPrinter(string szPrinterName, string szString)
    {
        IntPtr pBytes;
        Int32 dwCount = dwCount = szString.Length; // How many characters are in the string?
        // Assume that the printer is expecting ANSI text, and then convert the string to ANSI text.
        pBytes = Marshal.StringToCoTaskMemAnsi(szString);
        // Send the converted ANSI string to the printer.
        SendBytesToPrinter(szPrinterName, pBytes, dwCount);
        Marshal.FreeCoTaskMem(pBytes);
        return true;
    }

    #endregion

    #region CASH DRAWER FUNCTIONS
    public static bool SendOpenCashDrawerToPrinter(string szPrinterName)
    {
        //string required to open cash drawer
        string szString = new string(new char[] { (char)27, (char)112, (char)0, (char)50, (char)50 });
        IntPtr pBytes;
        Int32 dwCount = szString.Length; // How many characters are in the string?
        //Assume that the printer is expecting ANSI text, and then convert the string to ANSI text.
        pBytes = Marshal.StringToCoTaskMemAnsi(szString);

        // Send the converted ANSI string to the printer.
        SendBytesToPrinter(szPrinterName, pBytes, dwCount);
        Marshal.FreeCoTaskMem(pBytes);
        return true;
    }

    public static bool SendOpenCashDrawerToUSBPrinter(string szPrinterName)
    {
        //string required to open cash drawer
        string szString = new string(new char[] { (char)7 });
        IntPtr pBytes;
        Int32 dwCount = szString.Length; // How many characters are in the string?
        //Assume that the printer is expecting ANSI text, and then convert the string to ANSI text.
        pBytes = Marshal.StringToCoTaskMemAnsi(szString);

        // Send the converted ANSI string to the printer.
        SendBytesToPrinter(szPrinterName, pBytes, dwCount);
        Marshal.FreeCoTaskMem(pBytes);
        return true;
    }

    public static bool SendCommandToUSBPrinter(string szPrinterName, int chr)
    {
        //string required to open cash drawer
        string szString = new string(new char[] { (char)chr });
        IntPtr pBytes;
        Int32 dwCount = szString.Length; // How many characters are in the string?
        //Assume that the printer is expecting ANSI text, and then convert the string to ANSI text.
        pBytes = Marshal.StringToCoTaskMemAnsi(szString);

        // Send the converted ANSI string to the printer.
        SendBytesToPrinter(szPrinterName, pBytes, dwCount);
        Marshal.FreeCoTaskMem(pBytes);
        return true;
    }

    public static bool SendCutCommandToUSBPrinter(string szPrinterName)
    {
        DRShell.SendCommandToUSBPrinter(szPrinterName, 29); //escape
        DRShell.SendCommandToUSBPrinter(szPrinterName, 86); //"V" 
        DRShell.SendCommandToUSBPrinter(szPrinterName, 66); //66
        DRShell.SendCommandToUSBPrinter(szPrinterName, 80); //80

        return true;
    }


    #endregion

    #region SHELL FUNCTIONS
    public static void SetCustomShell(string ShellExecutableFileName)
    {
        try
        {
            RegistryKey reg = DRRegistry.RegLocalMachineLoginEx();
            reg.SetValue("Shell", ShellExecutableFileName);
        } catch { }
    }

    public static void SetExplorerShell()
    {
        try
        {
            Microsoft.Win32.RegistryKey reg = DRRegistry.RegLocalMachineLoginEx();
            reg.SetValue("Shell", "Explorer.exe");
        } catch { }
    }


    public static int ChangeDesktopWallPaper(string path)
    {
        return SystemParametersInfo(20, 0, path, 0x1 | 0x2);
    }

    /// <summary>
    /// Drive Mask Values 
    /// A=1, B=2, C=4, D=8, E=16, F=32, G=64, H=128, I=256, J=512 and so forth.
    /// Add the numbers for multiple masking A+B = 3 etc
    /// </summary>
    /// <param name="DriveMask"></param>
    public static void SetDriveMask(int DriveMask)
    {
        ////HKEY CURRENT USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer 
        ////In the right pane, double click the item labeled "NoDrives" (or create a DWORD value if it does not exist). 
        ////In the "Edit DWORD value" box, select "Decimal." 
        ////In the "Value data" text box, enter the number that corresponds to your hard drive: A=1, B=2, C=4, D=8, E=16, F=32, G=64, H=128, I=256, J=512 and so forth.
        RegistryKey reg = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
        reg.SetValue("NoDrives", DriveMask, Microsoft.Win32.RegistryValueKind.DWord);
        reg.Close();
    }
    #endregion

    #region CLEANING AND FILE MANAGEMENT
    public static string GetUserFolder(string username)
    {
        string docset = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        int location = docset.IndexOf("\\", 3);
        return docset.Substring(0, location) + "\\" + username;
    }
    public static bool DeleteFolderContent(string path)
    {
        if (Directory.Exists(path))
        {
            string[] dirs = Directory.GetDirectories(path);

            for (int i = 0; i < dirs.Length; i++)
            {
                try
                {
                    Directory.Delete(dirs[i], true);
                } catch { }
            }
            string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                try
                {
                    File.Delete(files[i]);
                } catch { }
            }
        }
        return true;
    }

    public static void DeleteUserFiles(string username)
    {
        string root = GetUserFolder(username);
        DeleteFolderContent(root + @"\Favorites");
        DeleteFolderContent(root + @"\Cookies");
        DeleteFolderContent(root + @"\Desktop");
        DeleteFolderContent(root + @"\My Documents");
        DeleteFolderContent(root + @"\UserData");
        DeleteFolderContent(root + @"\Local Settings\Temp");
        DeleteFolderContent(root + @"\Local Settings\Temporary Internet Files");
        DeleteFolderContent(root + @"\Local Settings\History");

        DeleteFolderContent(root + @"\Application Data\Identities");
        //DeleteOutlookFiles(root);
        DeleteFolderContent(root + @"\Local Settings\Application Data\Identities");

        ////         DeleteFolderContent(root + @"\Favorites");
    }
    public static void DeleteOutlookFiles(string root)
    {
        string[] dirs = Directory.GetDirectories(root + @"\Local Settings\Application Data\Identities");
        for (int i = 0; i < dirs.Length; i++)
            DeleteFolderContent(dirs[i] + @"\Microsoft\Outlook Express");
    }
    #endregion





}
