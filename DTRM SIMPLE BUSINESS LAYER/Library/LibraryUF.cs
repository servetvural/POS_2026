using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTRMNS.Library {
    public class LibraryUF {


        //public static List<SqlExpressDesc> GetEasyInstalledSqlExpressList() {
        //    List<SqlExpressDesc> serverList = new List<SqlExpressDesc>();
        //    bool bln32 = (IntPtr.Size == 4);
        //    string IP = GetIPAddresses(AddressFamily.InterNetwork);

        //    //32 bit makinada, 32 bit olan default ve instance larin hepsini getiriyor
        //    //64 bit makinada, 32 bit olan hic bir sey getirmiyor
        //    //                 64 bit olan default ve instance larin hepsini getiriyor
        //    try {
        //        //list 64 bit default and instances
        //        RegistryKey registry =
        //            DRRegistry.RegLocalMachineApplicationRead("Microsoft\\Microsoft SQL Server");
        //        //Get server names
        //        string[] strServerNames = (string[])registry.GetValue("InstalledInstances");

        //        RegistryKey registry2 =
        //            DRRegistry.RegLocalMachineApplicationRead("Microsoft\\Microsoft SQL Server\\Instance Names\\SQL");
        //        for (int i = 0; i < strServerNames.Length; i++) {
        //            //Create Server
        //            SqlExpressDesc server = new SqlExpressDesc(strServerNames[i]);
        //            server.IP = IP;
        //            //Assign server 32 or 64 bit
        //            server.osType = bln32 ? OSTypes.Bit32 : OSTypes.Bit64;

        //            string strkey = registry2.GetValue(server.ServerName).ToString();
        //            RegistryKey registry3 =
        //            DRRegistry.RegLocalMachineApplicationRead("Microsoft\\Microsoft SQL Server\\" + strkey + "\\MSSQLServer\\CurrentVersion");
        //            server.Version = registry3.GetValue("CurrentVersion").ToString();
        //            serverList.Add(server);
        //        }

        //        //for (int i = 0; i < strServerNames.Length; i++)
        //        //    serverList.Add(strServerNames[i] + (bln32 ? ", 32bit" : ", 64bit"));
        //    } catch {

        //    }

        //    //32 Bit makinada mevcut degil
        //    //64 bit makinada, 32 bit olan default ve instance larin hepsini getiriyor
        //    try {
        //        //list 32 bit default and instances
        //        RegistryKey registry =
        //            DRRegistry.RegLocalMachineApplicationRead("WOW6432Node\\Microsoft\\Microsoft SQL Server");
        //        //Get server names
        //        string[] strServerNames = (string[])registry.GetValue("InstalledInstances");

        //        RegistryKey registry2 =
        //           DRRegistry.RegLocalMachineApplicationRead("WOW6432Node\\Microsoft\\Microsoft SQL Server\\Instance Names\\SQL");
        //        for (int i = 0; i < strServerNames.Length; i++) {
        //            //Create Server
        //            SqlExpressDesc server = new SqlExpressDesc(strServerNames[i]);
        //            server.IP = IP;
        //            //Assign server 32 or 64 bit
        //            server.osType = OSTypes.Bit32; //bln32 ? OSTypes.Bit32 : OSTypes.Bit64;

        //            string strkey = registry2.GetValue(server.ServerName).ToString();
        //            RegistryKey registry3 =
        //            DRRegistry.RegLocalMachineApplicationRead("WOW6432Node\\Microsoft\\Microsoft SQL Server\\" + strkey + "\\MSSQLServer\\CurrentVersion");
        //            server.Version = registry3.GetValue("CurrentVersion").ToString();
        //            serverList.Add(server);
        //        }

        //    } catch {

        //    }

        //    return serverList;
        //}
    }
}
