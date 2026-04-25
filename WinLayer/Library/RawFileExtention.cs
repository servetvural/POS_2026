using System.Net.NetworkInformation;
using WinLayer.Library;

namespace WinLayer;
public class RawFileExtention
{
    private string _Extention = "";
    public string Extention { get { return _Extention; } set { _Extention = value; } }

    private string _Explanation = "";
    public string Explanation { get { return _Explanation; } set { _Explanation = value; } }

    public RawFileExtention()
    {

    }
    public RawFileExtention(string Extention, string Explanation)
    {
        _Extention = Extention;
        _Explanation = Explanation;
    }
}

//[System.Serializable]
//public class LicenceInfo {
//    private string loLicence;
//    private string loClient;
//    public LicenceInfo() {
//    }
//    public LicenceInfo(string Client, string Licence) {
//        this.Client = Client;
//        this.Licence = Licence;
//    }
//    public string Licence {
//        get { return loLicence; }
//        set { loLicence = value; }
//    }
//    public string Client {
//        get { return loClient; }
//        set { loClient = value; }
//    }
//}

[System.Serializable]
public class Parameter
{
    public string ParameterNameLocal;
    public string ParameterValueLocal;
    public string ParameterTextLocal;

    public Parameter()
    {
    }
    public Parameter(string ParamName, string ParamValue)
    {
        ParameterNameLocal = ParamName;
        ParameterValueLocal = ParamValue;
        ParameterTextLocal = ParamName + "=" + ParamValue;
    }
    public string ParameterName
    {
        get { return ParameterNameLocal; }
        set { ParameterNameLocal = value; }
    }
    public string ParameterValue
    {
        get { return ParameterValueLocal; }
        set { ParameterValueLocal = value; }
    }
    public string ParameterText
    {
        get { return ParameterTextLocal; }
        set { ParameterTextLocal = value; }
    }
}

[System.Serializable]
public class DRPrintJob
{
    private int _JobID;
    private string _MachineName;
    private string _PrinterName;
    private int _TotalPages;
    private int _PrintedPageCount;
    private int _PageDifference;

    public DRPrintJob()
    {
        _JobID = 0;
        _MachineName = "";
        _PrinterName = "";
        _TotalPages = 0;
        _PrintedPageCount = 0;
        _PageDifference = 0;
    }
    public DRPrintJob(int JobIID, string MachineName, string PrinterName)
    {
        this.JobID = JobID;
        this.MachineName = MachineName;
        this.PrinterName = PrinterName;
        this.TotalPages = 0;
        this.PrintedPageCount = 0;
        this._PageDifference = 0;
    }
    public DRPrintJob(int JobIID, string MachineName, string PrinterName, int TotalPages, int PrintedPageCount)
    {
        _JobID = JobID;
        _MachineName = MachineName;
        _PrinterName = PrinterName;
        _TotalPages = TotalPages;
        _PrintedPageCount = PrintedPageCount;
        _PageDifference = 0;
    }
    public int JobID { get { return _JobID; } set { _JobID = value; } }
    public string MachineName { get { return _MachineName; } set { _MachineName = value; } }
    public string PureMachineName
    {
        get
        {
            if (_MachineName.Length > 2)
                return _MachineName.Substring(_MachineName.LastIndexOf(@"\") + 1);
            else
                return _MachineName;
        }
    }
    public string PrinterName { get { return _PrinterName; } set { _PrinterName = value; } }
    public int TotalPages { get { return _TotalPages; } set { _TotalPages = value; } }
    public int PrintedPageCount { get { return _PrintedPageCount; } set { _PrintedPageCount = value; } }
    public int PageDifference { get { return _PageDifference; } set { _PageDifference = value; } }
}

[System.Serializable]
public class DRPrinter
{
    private string _Provider;
    private string _Server;

    private string _Fline;
    private string _Sline;
    private string _PrinterShareName;
    public DRPrinter()
    {
        _Provider = "win32spl.dll";
    }
    public DRPrinter(string Server, string PrinterShareName)
    {
        _Fline = "";
        _Sline = "";
        _Server = Server;
        _PrinterShareName = PrinterShareName;
        _Provider = "win32spl.dll";
    }
    public string Key { get { return _Fline + "," + _Sline + "," + _Server + "," + _PrinterShareName; } }
    public string Provider { get { return _Provider; } set { _Provider = value; } }
    public string Server { get { return _Server; } set { _Server = value; } }
    public string Fline { get { return _Fline; } set { _Fline = value; } }
    public string Sline { get { return _Sline; } set { _Sline = value; } }
    public string PrinterShareName { get { return _PrinterShareName; } set { _PrinterShareName = value; } }
}

[System.Serializable]
public class ComPortStatus
{
    public int vBaudRate;
    public bool vBreakState;
    public int vBytesToRead;
    public int vBytesToWrite;

    public bool vCDHolding;
    public bool vCtsHolding;
    public int vDataBits;
    public bool vDiscardNull;
    public bool vDsrHolding;
    public bool vDtrEnable;
    public bool vIsOpen;
    public System.IO.Ports.Parity vParity;
    public string vPortName;
    public int vReadBufferSize;
    public int vReadTimeOut;
    public int vReceivedBytesThreshold;
    public bool vRtsEnable;
    public System.IO.Ports.StopBits vStopBits;
    public int vWriteBufferSize;
    public int vWriteTimeOut;

    public ComPortStatus()
    {

    }
}


public class CommunicationParameter
{
    private string _ParamName;
    public string ParamName { get { return _ParamName; } set { _ParamName = value; } }

    private string _ParamValue;
    public string ParamValue { get { return _ParamValue; } set { _ParamValue = value; } }

    public CommunicationParameter()
    {
        _ParamName = "";
        _ParamValue = "";
    }
    public CommunicationParameter(string ParamName, string ParamValue)
    {
        _ParamName = ParamName;
        _ParamValue = ParamValue;
    }
    public CommunicationParameter(string FullString)
    {
        string[] parts = FullString.Split(new char[] { '=' });
        switch (parts.Length)
        {
            case 0:
                _ParamName = "";
                _ParamValue = "";
                break;
            case 1:
                _ParamName = parts[0];
                _ParamValue = "";
                break;
            case 2:
                _ParamName = parts[0];
                _ParamValue = parts[1];
                break;
            default:
                _ParamName = "";
                _ParamValue = "";
                break;
        }
    }
}

/// <summary>
/// Action comes like & is a seperator, # is endofline
///192.168.0.10&HELLO#
///192.168.0.10&ADDMINUTES&m=10#
///192.168.0.10&ADDAPP&Explorer=C:\Program Files\Internet Explorer\IExplore.exe#
///etc
/// </summary>
public class CommunicationPacket
{
    private string _SenderIP;
    public string SenderIP { get { return _SenderIP; } set { _SenderIP = value; } }

    private ActionTypes _Action;
    public ActionTypes Action { get { return _Action; } set { _Action = value; } }

    private int _ParamCount;
    public int ParamCount { get { return _ParamList.Count; } }

    private string _ParamLine;
    public string ParamLine { get { return _ParamLine; } set { _ParamLine = value; } }

    private List<CommunicationParameter> _ParamList;
    public List<CommunicationParameter> ParamList { get { return _ParamList; } set { _ParamList = value; } }

    private PacketValidationTypes _Status;
    public PacketValidationTypes Status { get { return _Status; } set { _Status = value; } }


    public string GetParameterValue(string ParamName)
    {
        CommunicationParameter param = _ParamList.Find(delegate (CommunicationParameter cp) { return cp.ParamName.ToUpper() == ParamName.ToUpper(); });
        if (param == null)
            return "";
        else
            return param.ParamValue;
    }
    public string GetParameterValueByIndex(int index)
    {
        if (_ParamList.Count > index)
            return _ParamList[index].ParamValue;
        else
            return "";
    }

    public CommunicationPacket()
    {
        _SenderIP = "";
        _Action = ActionTypes.UNKNOWN;
        _ParamLine = "";
        ParamList = new List<CommunicationParameter>();
        _Status = PacketValidationTypes.InValid;
    }
    public CommunicationPacket(string SenderIP, ActionTypes Action)
    {
        _SenderIP = SenderIP;
        _Action = Action;
        _ParamList = new List<CommunicationParameter>();
        _ParamLine = "";
        _Status = Status;
    }
    public static string CreateAsString(string SenderIP, ActionTypes Action)
    {
        return SenderIP + "&" + Action.ToString() + "#";
    }
    public CommunicationPacket(string SenderIP, ActionTypes Action, List<CommunicationParameter> ParamList, PacketValidationTypes Status)
    {
        _SenderIP = SenderIP;
        _Action = Action;

        _ParamList = ParamList;
        if (_ParamList == null)
            _ParamList = new List<CommunicationParameter>();
        _ParamLine = "";
        for (int i = 0; i < _ParamList.Count; i++)
        {
            _ParamLine += _ParamList[i].ParamName + "=" + _ParamList[i].ParamValue;
            if (i < _ParamList.Count - 1)
                _ParamLine += "&";
        }
        _Status = Status;
    }
    public static string CreateAsString(string SenderIP, ActionTypes Action, List<CommunicationParameter> ParamList)
    {
        string str = SenderIP + "&" + Action.ToString();

        for (int i = 0; i < ParamList.Count; i++)
        {
            str += "&" + ParamList[i].ParamName + "=" + ParamList[i].ParamValue;
        }
        return str + "#";
    }
    public static string CreateAsString(string SenderIP, ActionTypes Action, string ParamLine)
    {
        string str = SenderIP + "&" + Action.ToString();
        if (ParamLine.Length > 0 && ParamLine.Contains("="))
            str += "&" + ParamLine;
        return str + "#";
    }
    public static string CreateAsString(string SenderIP, ActionTypes Action, string ParamName, string ParamValue)
    {
        string str = SenderIP + "&" + Action.ToString();
        str += "&" + ParamName + "=" + ParamValue;
        return str + "#";
    }
    public CommunicationPacket(string PacketAsString)
    {

        //Action doesn't have endline sign so return
        if (!PacketAsString.EndsWith("#"))
        {
            _Status = PacketValidationTypes.InValid;
            return;
        }
        PacketAsString = PacketAsString.TrimEnd(new char[] { '#' });

        string[] actionParts = PacketAsString.Split(new char[] { '&' });
        //Action not understood so return
        if (actionParts.Length < 2)
        {
            _Status = PacketValidationTypes.InValid;
            return;
        }

        _SenderIP = actionParts[0];  //Who send this message 

        if (_SenderIP.Split(new char[] { '.' }).Length < 4)
        {
            _Status = PacketValidationTypes.InValid;
            return;
        }

        try
        {
            _Action = (ActionTypes)Enum.Parse(typeof(ActionTypes), actionParts[1].ToUpper()); //Action
        } catch
        {
            _Action = ActionTypes.UNKNOWN;
            _Status = PacketValidationTypes.InValid;
            return;
        }

        //_ParamCount = actionParts.Length - 2; //parameter count 0 is ok for parameterless functions

        _ParamLine = "";
        _ParamList = new List<CommunicationParameter>();
        for (int i = 2; i < actionParts.Length; i++)
        {
            _ParamLine += actionParts[i];
            if (i < actionParts.Length - 1)
                _ParamLine += "&";
            _ParamList.Add(new CommunicationParameter(actionParts[i]));
        }

        _Status = PacketValidationTypes.Valid;
    }

    public bool IsValid()
    {
        if (_Status == PacketValidationTypes.Valid)
            return true;
        else
            return false;
    }

    ///192.168.0.10&ADDAPP&Explorer=C:\Program Files\Internet Explorer\IExplore.exe#
    public string ToCommunicationString()
    {
        string str = SenderIP + "&" + Action.ToString();

        for (int i = 0; i < _ParamList.Count; i++)
        {
            str += "&" + _ParamList[i].ParamName + "=" + _ParamList[i].ParamValue;
        }
        return str + "#";
    }

}

public class ScannedPort
{
    private int _ThreadIndex;
    public int ThreadIndex { get { return _ThreadIndex; } set { _ThreadIndex = value; } }

    private string _IP;
    public string IP { get { return _IP; } set { _IP = value; } }

    private int _PortNumber;
    public int PortNumber { get { return _PortNumber; } set { _PortNumber = value; } }

    private PortStatusTypes _PortStatus;
    public PortStatusTypes PortStatus { get { return _PortStatus; } set { _PortStatus = value; } }

    public ScannedPort()
    {
    }
    public ScannedPort(string IP, int PortNumber)
    {
        _IP = IP;
        _PortNumber = PortNumber;
    }
    public ScannedPort(string IP, int PortNumber, PortStatusTypes PortStatus)
    {
        _IP = IP;
        _PortNumber = PortNumber;
        _PortStatus = PortStatus;
    }

}


public class ComputerWithPorts
{
    private string _IP;
    public string IP { get { return _IP; } set { _IP = value; } }

    private List<ScannedPort> _PortList;
    public List<ScannedPort> PortList { get { return _PortList; } set { _PortList = value; } }

    public ComputerWithPorts()
    {
        _IP = "";
        _PortList = new List<ScannedPort>();
    }
    public ComputerWithPorts(string IP)
    {
        _IP = IP;
        _PortList = new List<ScannedPort>();
    }
    public ComputerWithPorts(string IP, int PortToScan)
    {
        _IP = IP;
        _PortList = new List<ScannedPort>();
        _PortList.Add(new ScannedPort(IP, PortToScan));
    }
    public ComputerWithPorts(string IP, int PortStart, int PortEnd)
    {
        _IP = IP;
        _PortList = new List<ScannedPort>();
        for (int i = PortStart; i <= PortEnd; i++)
            _PortList.Add(new ScannedPort(IP, i));
    }
    public ComputerWithPorts(string IP, int[] Ports)
    {
        _IP = IP;
        _PortList = new List<ScannedPort>();
        for (int i = 0; i < Ports.Length; i++)
            _PortList.Add(new ScannedPort(IP, Ports[i]));
    }
}


public class PortScanner
{
    private int _PortPermutationTotal;
    public int PortPermutationTotal { get { return _PortPermutationTotal; } set { _PortPermutationTotal = value; } }

    private bool _blnStop;
    public bool blnStop { get { return _blnStop; } set { _blnStop = value; } }

    public List<ComputerWithPorts> _ComputerList;
    public List<ComputerWithPorts> ComputerList { get { return _ComputerList; } set { _ComputerList = value; } }

    private ScanStatusTypes _Status;
    public ScanStatusTypes Status { get { return _Status; } set { _Status = value; } }

    private bool _UsePing;
    public bool UsePing { get { return _UsePing; } set { _UsePing = value; } }

    private List<Ping> pngList;

    private int _Progress;
    public int Progress { get { return _Progress; } set { _Progress = value; } }

    private bool _NotifyClosedPorts;
    public bool NotifyClosedPorts { get { return _NotifyClosedPorts; } set { _NotifyClosedPorts = value; } }

    private bool _JustPing;
    public bool JustPing { get { return _JustPing; } set { _JustPing = value; } }

    public event Delegate_String OutputOccured;
    public void OnOutputOccured(string str)
    {
        if (OutputOccured != null)
        {
            OutputOccured(str);
        }
    }

    public event DelegateNoParameter ScanCompleted;
    public void OnScanCompleted()
    {
        _Progress = 0;
        if (ScanCompleted != null)
        {
            ScanCompleted();
        }
    }

    public event Delegate_String PingSuccessful;
    public void OnPingSuccessful(string ComputerIP)
    {
        if (PingSuccessful != null)
        {
            PingSuccessful(ComputerIP);
        }
    }

    public event PortScanDelegate PortScanSuccessful;
    public void OnPortScanSuccessful(ScannedPort port)
    {
        if (PortScanSuccessful != null)
        {
            PortScanSuccessful(port);
        }
    }
    //public event DelegateWithString SingleComputerScanCompleted;
    //public void OnSingleComputerScanCompleted(string ComputerIP) { 
    //    if (SingleComputerScanCompleted != null) {
    //        SingleComputerScanCompleted(ComputerIP);
    //    }
    //}

    public event Delegate_Object_Int_Int ProgressChanged;
    public void OnProgressChanged(PortScanner scanner, int Progress, int Total)
    {
        if (ProgressChanged != null)
        {
            ProgressChanged(this, Progress, Total);
        }
    }

    public PortScanner()
    {
        _ComputerList = new List<ComputerWithPorts>();
        _Progress = 0;
    }

    public PortScanner(string IP, int PortToScan, bool UsePing)
    {
        _ComputerList = new List<ComputerWithPorts>();
        _ComputerList.Add(new ComputerWithPorts(IP, PortToScan));
        _UsePing = UsePing;
        _Progress = 0;
    }

    public PortScanner(string IP, bool UsePing, int StartPort, int EndPort)
    {
        _ComputerList = new List<ComputerWithPorts>();
        _ComputerList.Add(new ComputerWithPorts(IP, StartPort, EndPort));
        _UsePing = UsePing;
        _Progress = 0;
    }

    public PortScanner(string IP, int[] Ports, bool UsePing)
    {
        _ComputerList = new List<ComputerWithPorts>();
        _ComputerList.Add(new ComputerWithPorts(IP, Ports));
        _UsePing = UsePing;
        _Progress = 0;
    }

    public PortScanner(string StartIP, int ComputerRange, int PortToScan, bool UsePing)
    {
        string[] bits = StartIP.Split(new char[] { '.' });
        string rootIP = bits[0] + "." + bits[1] + "." + bits[2] + ".";
        int StartIP4thBit = int.Parse(bits[3]);

        _ComputerList = new List<ComputerWithPorts>();
        for (int i = StartIP4thBit; i <= ComputerRange; i++)
            _ComputerList.Add(new ComputerWithPorts(rootIP + i.ToString(), PortToScan));

        _UsePing = UsePing;
        _Progress = 0;
    }

    public PortScanner(string StartIP, int ComputerRange, int StartPort, int EndPort, bool UsePing)
    {
        string[] bits = StartIP.Split(new char[] { '.' });
        string rootIP = bits[0] + "." + bits[1] + "." + bits[2] + ".";
        int StartIP4thBit = int.Parse(bits[3]);

        _ComputerList = new List<ComputerWithPorts>();
        for (int i = StartIP4thBit; i <= ComputerRange; i++)
            _ComputerList.Add(new ComputerWithPorts(rootIP + i.ToString(), StartPort, EndPort));

        _UsePing = UsePing;
        _Progress = 0;
    }

    public PortScanner(string StartIP, int ComputerRange, int[] Ports, bool UsePing)
    {
        string[] bits = StartIP.Split(new char[] { '.' });
        string rootIP = bits[0] + "." + bits[1] + "." + bits[2] + ".";
        int StartIP4thBit = int.Parse(bits[3]);

        _ComputerList = new List<ComputerWithPorts>();
        for (int i = StartIP4thBit; i <= ComputerRange; i++)
            _ComputerList.Add(new ComputerWithPorts(rootIP + i.ToString(), Ports));

        _UsePing = UsePing;
        _Progress = 0;
    }

    public void StartScanJustPing()
    {
        JustPing = true;
        StartScan();
    }

    public void StartScan()
    {
        blnStop = false;
        pngList = new List<Ping>();

        if (UsePing || JustPing)
            _PortPermutationTotal = 0;
        else
            _PortPermutationTotal = GetComputerPortPermutation();

        //doneEvents = new ManualResetEvent[_PortPermutationTotal];

        // int per = _ComputerList[0].PortList.Count;
        for (int i = 0; i < _ComputerList.Count; i++)
        {
            if (blnStop)
                break;

            if (UsePing || JustPing)
            {
                Ping png = new Ping();
                png.PingCompleted += new PingCompletedEventHandler(png_PingCompleted);
                pngList.Add(png);
                png.SendAsync(_ComputerList[i].IP, 1, _ComputerList[i]);

            } else
            {
                for (int p = 0; p < _ComputerList[i].PortList.Count; p++)
                {
                    Thread t = new Thread(CheckPort);
                    t.Start(_ComputerList[i].PortList[p]);
                }
                //for (int p = 0; p < _ComputerList[i].PortList.Count; p++) {
                //    int threadindex = (i * per) + p;
                //    doneEvents[threadindex] = new ManualResetEvent(false);
                //    _ComputerList[i].PortList[p].ThreadIndex = threadindex;
                //    ThreadPool.QueueUserWorkItem(new WaitCallback(CheckPort), _ComputerList[i].PortList[p]);

                //}

                //for (int p = 0; p < _ComputerList[i].PortList.Count; p++) {
                //    CheckPort(_ComputerList[i].PortList[p]);                       
                //}
            }

        }
        //WaitHandle.WaitAll(doneEvents);
        //OnOutputOccured("Wait All returned as done");

    }

    public void StopScan()
    {
        blnStop = true;
        if (pngList != null)
        {
            foreach (Ping png in pngList)
                png.SendAsyncCancel();
        }
    }

    private void png_PingCompleted(object sender, PingCompletedEventArgs e)
    {

        if (e.Reply.Status == IPStatus.Success)
        {
            //Computer exist so increment total permutations
            _PortPermutationTotal += ComputerList[0].PortList.Count;

            ComputerWithPorts comp = (ComputerWithPorts)e.UserState;

            if (JustPing)
            {
                Thread t = new Thread(CheckPing);
                t.Start(comp.IP);
            } else
            {
                for (int p = 0; p < comp.PortList.Count; p++)
                {
                    Thread t = new Thread(CheckPort);
                    t.Start(comp.PortList[p]);
                }
            }
            //OnSingleComputerScanCompleted(comp.IP);
        }

        Ping png = (Ping)sender;
        pngList.Remove((Ping)sender);
    }

    public int GetComputerPortPermutation()
    {
        int Total = 0;
        if (_ComputerList != null)
        {
            for (int i = 0; i < _ComputerList.Count; i++)
                Total += _ComputerList[i].PortList.Count;
        }
        return Total;
    }

    public void CheckPort(object data)
    {
        ScannedPort port = (ScannedPort)data;
        _Progress++;
        OnProgressChanged(this, Progress, PortPermutationTotal);

        if (DRNetwork.TestPort(port.IP, port.PortNumber))
        {
            port.PortStatus = PortStatusTypes.Listening;
            OnOutputOccured(port.IP + ":" + port.PortNumber + " " + port.PortStatus.ToString());
            OnPortScanSuccessful(port);
        } else if (_NotifyClosedPorts)
            OnOutputOccured(port.IP + ":" + port.PortNumber + " " + port.PortStatus.ToString());

        if (_Progress == PortPermutationTotal)
        {
            OnScanCompleted();
        }

        //doneEvents[port.ThreadIndex].Set();

    }

    public void CheckPing(object data)
    {
        string IP = data.ToString();
        _Progress++;
        OnProgressChanged(this, Progress, PortPermutationTotal);
        OnOutputOccured(IP + ": Visible");
        OnPingSuccessful(IP);

        if (_Progress == PortPermutationTotal)
        {
            OnScanCompleted();
        }

        //doneEvents[port.ThreadIndex].Set();
    }
}



public class DBServer
{
    private string _Name = "";
    public string Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
    private string _FullAddress = "";
    public string FullAddress
    {
        get { return _FullAddress; }
        set { _FullAddress = value; }
    }

    private DBServerTypes _ServerType = DBServerTypes.LocalDefault;
    public DBServerTypes ServerType
    {
        get { return _ServerType; }
        set { _ServerType = value; }
    }
    public DBServer()
    {
    }
    public DBServer(string Name, string FullAddress, DBServerTypes ServerType)
    {
        this.Name = Name;
        this.FullAddress = FullAddress;
        this.ServerType = ServerType;
    }
}

//[System.Serializable]
//public class ScheduledJob : INotifyPropertyChanged
//{

//    private string _IID = Guid.NewGuid().ToString();
//    private int _JobType = 0;
//    private string _JobDescription = "";
//    private string _Param1 = "01/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + " 00:00:00";
//    private string _Param2 = "";
//    private string _Param3 = "";
//    private DateTime _ActionDateTime = new DateTime((DateTime.Now.Month == 12 ? DateTime.Now.AddYears(1).Year : DateTime.Now.Year),
//        (DateTime.Now.Month == 12 ? 1 : DateTime.Now.AddMonths(1).Month), 3, 4, 0, 0);
//    private bool _StatusFlag = false;
//    private int _AttemptCount = 0;

//    //Property for IID
//    public string IID
//    {
//        get { return _IID; }
//        set { _IID = value; this.NotifyPropertyChanged("IID"); }
//    }

//    //Property for JobType
//    public int JobType
//    {
//        get { return _JobType; }
//        set { _JobType = value; this.NotifyPropertyChanged("JobType"); }
//    }

//    public ScheduledJobTypes ScheduledJobType { get { return (ScheduledJobTypes)_JobType; } }


//    //Property for JobDescription
//    public string JobDescription
//    {
//        get { return _JobDescription; }
//        set { _JobDescription = value; this.NotifyPropertyChanged("JobDescription"); }
//    }

//    //Property for Param1
//    public string Param1
//    {
//        get { return _Param1; }
//        set { _Param1 = value; this.NotifyPropertyChanged("Param1"); }
//    }

//    //Property for Param2
//    public string Param2
//    {
//        get { return _Param2; }
//        set { _Param2 = value; this.NotifyPropertyChanged("Param2"); }
//    }

//    //Property for Param3
//    public string Param3
//    {
//        get { return _Param3; }
//        set { _Param3 = value; this.NotifyPropertyChanged("Param3"); }
//    }

//    //Property for ActionDateTime
//    public DateTime ActionDateTime
//    {
//        get { return _ActionDateTime; }
//        set { _ActionDateTime = value; this.NotifyPropertyChanged("ActionDateTime"); }
//    }

//    //Property for StatusFlag
//    public bool StatusFlag
//    {
//        get { return _StatusFlag; }
//        set { _StatusFlag = value; this.NotifyPropertyChanged("StatusFlag"); }
//    }

//    //Property for AttemptCount
//    public int AttemptCount
//    {
//        get { return _AttemptCount; }
//        set { _AttemptCount = value; this.NotifyPropertyChanged("AttemptCount"); }
//    }


//    //Default Constructor	
//    public ScheduledJob()
//    {

//    }

//    //Parameterized constructor	
//    public ScheduledJob(string IID, int JobType, string JobDescription, string Param1, string Param2, string Param3, DateTime ActionDateTime, bool StatusFlag, int AttemptCount)
//    {
//        _IID = IID;
//        _JobType = JobType;
//        _JobDescription = JobDescription;
//        _Param1 = Param1;
//        _Param2 = Param2;
//        _Param3 = Param3;
//        _ActionDateTime = ActionDateTime;
//        _StatusFlag = StatusFlag;
//        _AttemptCount = AttemptCount;

//    }

//    public ScheduledJob(DataTable dt)
//    {
//        _IID = dt.Rows[0]["IID"].ToString();
//        _JobType = int.Parse(dt.Rows[0]["JobType"].ToString());
//        _JobDescription = dt.Rows[0]["JobDescription"].ToString();
//        _Param1 = dt.Rows[0]["Param1"].ToString();
//        _Param2 = dt.Rows[0]["Param2"].ToString();
//        _Param3 = dt.Rows[0]["Param3"].ToString();

//        _ActionDateTime = DateTime.Parse(dt.Rows[0]["ActionDateTime"].ToString());
//        _StatusFlag = bool.Parse(dt.Rows[0]["StatusFlag"].ToString());
//        _AttemptCount = int.Parse(dt.Rows[0]["AttemptCount"].ToString());

//    }

//    public ScheduledJob(DataRow dr)
//    {
//        _IID = dr["IID"].ToString();
//        _JobType = int.Parse(dr["JobType"].ToString());
//        _JobDescription = dr["JobDescription"].ToString();
//        _Param1 = dr["Param1"].ToString();
//        _Param2 = dr["Param2"].ToString();
//        _Param3 = dr["Param3"].ToString();
//        _ActionDateTime = DateTime.Parse(dr["ActionDateTime"].ToString());
//        _StatusFlag = bool.Parse(dr["StatusFlag"].ToString());
//        _AttemptCount = int.Parse(dr["AttemptCount"].ToString());

//    }
//    public bool Delete(DB db)
//    {
//        return db.RunQuery("DeleteScheduledJob " +
//        "'" + _IID.Replace("'", "''") + "'");
//    }
//    public bool Save(DB db)
//    {
//        return db.RunQuery("SaveScheduledJob " +
//    "'" + _IID.Replace("'", "''") + "','" + _JobType + "','" + _JobDescription.Replace("'", "''") + "','" + _Param1.Replace("'", "''") + "','" + _Param2.Replace("'", "''") + "','" + _Param3.Replace("'", "''") + "','" + db.DatetimeToMSSqlDatetime(_ActionDateTime) + "','" + _StatusFlag + "','" + _AttemptCount + "'");
//    }

//    #region INotifyPropertyChanged Members
//    public event PropertyChangedEventHandler PropertyChanged;
//    private void NotifyPropertyChanged(string PropertyName)
//    {
//        if (PropertyChanged != null)
//            PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
//    }
//    #endregion

//}

public class SelectableStringList
{
    private List<string> _StringList;
    public List<string> StringList { get { return _StringList; } set { _StringList = value; } }

    public SelectableStringList()
    {
        _StringList = new List<string>();
    }
    public SelectableStringList(List<string> StringList)
    {
        _StringList = StringList;
    }
    public SelectableStringList(string[] StringArray)
    {
        _StringList = new List<string>(StringArray);
    }

}
