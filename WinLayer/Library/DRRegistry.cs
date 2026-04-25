using Microsoft.Win32;

namespace WinLayer;
public class DRRegistry
{
    public DRRegistry()
    {
    }

    public static RegistryKey RegLocalMachineApplicationRead(string ApplicationName)
    {
        return Registry.LocalMachine.OpenSubKey("SOFTWARE\\" + ApplicationName);
    }
    public static RegistryKey RegLocalMachineApplicationEx(string ApplicationName)
    {
        return Registry.LocalMachine.CreateSubKey("SOFTWARE\\" + ApplicationName);
    }
    public static RegistryKey RegLocalMachineApplicationSubKeyRead(string ApplicationName, string SubKeyName)
    {
        return Registry.LocalMachine.OpenSubKey("SOFTWARE\\" + ApplicationName + "\\" + SubKeyName);
    }
    public static RegistryKey RegLocalMachineApplicationSubKeyEx(string ApplicationName, string SubKeyName)
    {
        return Registry.LocalMachine.CreateSubKey("SOFTWARE\\" + ApplicationName + "\\" + SubKeyName);
    }

    public static RegistryKey RegCurrentUserApplicationRead(string ApplicationName)
    {
        return Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + ApplicationName);
    }
    public static RegistryKey RegCurrentUserApplicationEx(string ApplicationName)
    {
        return Registry.CurrentUser.CreateSubKey("SOFTWARE\\" + ApplicationName);
    }
    public static RegistryKey RegCurrentUserApplicationSubKeyRead(string ApplicationName, string SubKeyName)
    {
        return Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + ApplicationName + "\\" + SubKeyName);
    }
    public static RegistryKey RegCurrentUserApplicationSubKeyEx(string ApplicationName, string SubKeyName)
    {
        return Registry.CurrentUser.CreateSubKey("SOFTWARE\\" + ApplicationName + "\\" + SubKeyName);
    }

    public static void SaveUserAppDataRegistryItemEx(string name, object value, bool Encode)
    {
        string valueLocal = "";
        try
        {
            valueLocal = (Encode ? DRFormat.Encode(value.ToString()) : value.ToString());
            Application.UserAppDataRegistry.SetValue(name, valueLocal);
        } catch
        {
        }
    }

    #region INTERNET EXPLORER FUNCTIONS
    public static RegistryKey RegLocalMachineInternetExplorerEx()
    {
        return Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Internet Explorer\\Main");
    }
    public static RegistryKey RegLocalMachineInternetExplorerRead()
    {
        return Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main");
    }

    public static void SetLocalMachineIEValue(string name, object value)
    {
        RegLocalMachineInternetExplorerEx().SetValue(name, value);
    }
    public static void SetLocalMachineIEDefaults(bool AlwaysShowMenus, string Default_Page_URL, bool FullScreen,
        bool Show_StatusBar, bool Show_ToolBar, string Start_Page, string Window_Title)
    {
        RegCurrentUserInternetExplorerEx().SetValue("AlwaysShowMenus", (AlwaysShowMenus ? 1 : 0));
        RegCurrentUserInternetExplorerEx().SetValue("Default_Page_URL", "about:blank");
        RegCurrentUserInternetExplorerEx().SetValue("FullScreen", (FullScreen ? "yes" : "no")); //
        RegCurrentUserInternetExplorerEx().SetValue("Show_StatusBar", (Show_StatusBar ? "yes" : "no"));
        RegCurrentUserInternetExplorerEx().SetValue("Show_ToolBar", (Show_ToolBar ? "yes" : "no"));
        RegCurrentUserInternetExplorerEx().SetValue("Start Page", Start_Page);
        RegCurrentUserInternetExplorerEx().SetValue("Window Title", Window_Title);
    }


    public static RegistryKey RegCurrentUser()
    {
        return Registry.CurrentUser;
    }
    public static RegistryKey RegCurrentUserInternetExplorerEx()
    {
        return Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Internet Explorer\\Main");
    }
    public static RegistryKey RegCurrentUserInternetExplorerRead()
    {
        return Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Internet Explorer\\Main");
    }
    public static void SetCurrentUserIEValue(string name, object value)
    {
        RegCurrentUserInternetExplorerEx().SetValue(name, value);
    }
    public static void SetCurrentUserIEDefaults(bool AlwaysShowMenus, string Default_Page_URL, bool FullScreen,
        bool Show_StatusBar, bool Show_ToolBar, string Start_Page, string Window_Title)
    {
        RegCurrentUserInternetExplorerEx().SetValue("AlwaysShowMenus", (AlwaysShowMenus ? 1 : 0));
        RegCurrentUserInternetExplorerEx().SetValue("Default_Page_URL", "about:blank");
        RegCurrentUserInternetExplorerEx().SetValue("FullScreen", (FullScreen ? "yes" : "no")); //
        RegCurrentUserInternetExplorerEx().SetValue("Show_StatusBar", (Show_StatusBar ? "yes" : "no"));
        RegCurrentUserInternetExplorerEx().SetValue("Show_ToolBar", (Show_ToolBar ? "yes" : "no"));
        RegCurrentUserInternetExplorerEx().SetValue("Start Page", Start_Page);
        RegCurrentUserInternetExplorerEx().SetValue("Window Title", Window_Title);
    }
    #endregion

    #region "AUTO LOGIN REGISTRY FUNCTIONS"

    public static RegistryKey RegLocalMachineLoginEx()
    {
        return Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
    }
    public static RegistryKey RegLocalMachineLoginRead()
    {
        return Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
    }

    public static void SetLocalMachineAutoLoginValues(string UserName, string Password)
    {
        RegistryKey reg = RegLocalMachineLoginEx();

        reg.SetValue("DefaultDomainName", ".");
        reg.SetValue("DefaultUserName", UserName);
        reg.SetValue("DefaultPassword", Password);
        reg.SetValue("AutoAdminLogon", "1");

        reg.SetValue("DontDisplayLastUserName", 0);
        reg.SetValue("DisableCAD", 1);

        reg.SetValue("ForceAutoLogon", "1");
        reg.SetValue("IgnoreShiftOverride", "1");
    }

    public static void UnSetAutoLoginValues()
    {
        RegistryKey reg = RegLocalMachineLoginEx();

        reg.SetValue("DefaultDomainName", "");
        reg.SetValue("DefaultUserName", "");
        reg.SetValue("DefaultPassword", "");
        reg.SetValue("AutoAdminLogon", "0");

        reg.SetValue("DontDisplayLastUserName", 0);
        reg.SetValue("DisableCAD", 1);

        reg.SetValue("ForceAutoLogon", "0");
        reg.SetValue("IgnoreShiftOverride", "0");
    }

    #endregion

}
