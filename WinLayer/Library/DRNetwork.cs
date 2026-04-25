using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace WinLayer;
public class DRNetwork
{
    public DRNetwork()
    {
    }

    public static string GetIP()
    {
        string strHostName = Dns.GetHostName();
        IPAddress[] addressList = Dns.GetHostAddresses(strHostName);
        foreach (IPAddress ip in addressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
                return ip.ToString();
        }
        return "";
    }

    public static bool IsComputerPingable(string ip, int TimeOut)
    {
        Ping png = new Ping();
        return (png.Send(ip, TimeOut).Status == IPStatus.Success);
    }
    public static IPStatus GetRemoteComputerPingStatus(string ip, int TimeOut)
    {
        Ping png = new Ping();
        return png.Send(ip, TimeOut).Status;
    }

    public static bool TestPort(string ServerIP, int PortNumber)
    {
        try
        {
            // Create the socket instance
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Cet the remote IP address
            IPAddress ip = IPAddress.Parse(ServerIP);
            // Create the end point 
            IPEndPoint ipEnd = new IPEndPoint(ip, PortNumber);
            // Connect to the remote host
            socket.Connect(ipEnd);
            if (socket.Connected)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                return true;
            }
            try
            {
                socket.Shutdown(SocketShutdown.Both);
            } catch { }
            try
            {
                socket.Close();
            } catch { }
            return false;
        } catch
        {
            return false;
        }
    }


    public static string GetNetworkInformation()
    {
        string msg = "";
        NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
        foreach (NetworkInterface adapter in adapters)
        {

            if (adapter.OperationalStatus == OperationalStatus.Up &&
                adapter.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                adapter.NetworkInterfaceType != NetworkInterfaceType.Tunnel)
            {
                IPInterfaceProperties adapterProperties = adapter.GetIPProperties();

                msg += adapter.Name + "\r\n";

                //IP Address Details
                UnicastIPAddressInformationCollection unicoll = adapterProperties.UnicastAddresses;
                foreach (UnicastIPAddressInformation ipinfo in unicoll)
                {
                    if (!ipinfo.Address.IsIPv6LinkLocal)
                    {
                        msg += "  IPv4 Address      : " + ipinfo.Address.ToString() + "\r\n";
                        if (ipinfo.IPv4Mask != null)
                            msg += "  Subnet Mask      : " + ipinfo.IPv4Mask.ToString() + "\r\n";
                    }
                }

                //Gateway details
                GatewayIPAddressInformationCollection gatewayList = adapterProperties.GatewayAddresses;
                foreach (GatewayIPAddressInformation gateway in gatewayList)
                {
                    msg += "  Default Gateway : " + gateway.Address.ToString() + "\r\n";
                }

                //DNS details
                IPAddressCollection dnsServers = adapterProperties.DnsAddresses;
                if (dnsServers.Count > 0)
                {
                    foreach (IPAddress dns in dnsServers)
                        msg += "  DNS Server        : " + dns.ToString() + "\r\n";
                }
                msg += "\r\n";
            }
        }
        return msg;
    }
}
