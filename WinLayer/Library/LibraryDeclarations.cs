using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;



namespace WinLayer.Library;


public enum ActionTypes
{
    UNKNOWN,
    HELLO, GETCONFIG, SAVECONFIG, RELOADCONFIG, RETURNEDCONFIG,
    ADDMINUTES, INCREMENTCREDIT, CANCELCREDIT, GETCREDITENDPOINT, RETURNEDCREDITENDPOINT, GETCREDITSECONDS, RETURNEDCREDITSECONDS, /*SETCREDIT, SETCREDITSECONDS,*/
    ACTIVATEGINA, DISABLEGINA, SETLOGONHOOK, UNSETLOGONHOOK,
    ENSUREDESKTOP, SETDESKTOPBG,
    RESETSTAT, RESETPERMSTAT, SETSTAT, SETPERMSTAT, GETSTAT, GETPERMSTAT, RETURNEDSTAT, RETURNEDPERMSTAT,
    GETCONFIGPACKET, RETURNEDCONFIGPACKET,
    SETNORMALSHELL, SETBLANKSHELL, LOCK, UNLOCK,
    RESTARTBAR,
    LOGOFF, SHUTDOWN, RESTART,
    STARTCMD, STARTREGEDIT,
    GETAPPLIST, DELETEAPP, ADDAPP, RETURNEDAPPLIST, CLEARAPPS, RELOADAPPS,
    SETDRIVEMASK,
    CLEARPRINTERS,
    STATUSCHANGED,
    CREATEUSER, ENSUREUSER, DELETEUSER, BARSTARTINGLOGOFF
}

public enum PacketValidationTypes { InValid, Valid }
public enum PortStatusTypes { NotListening, Listening }
public enum ScanStatusTypes { Idle, InProgress, Completed, CompletedWithErrors, Cancelled }

public delegate void Delegate_String(string str);
public delegate void DelegateNoParameter();
public delegate void PortScanDelegate(ScannedPort port);
public delegate void Delegate_Object_Int_Int(object obj, int i, int j);
public delegate void Delegate_BackGroundWork(object args, BackgroundWorker worker, DoWorkEventArgs e);
public delegate void Delegate_Int_String(int val, string str);
public delegate void Delegate_Bool(bool Success);

public delegate void Delegate_Int(int val);
public delegate void Delegate_Int_Int(int i, int j);
public delegate void Delegate_Int_Control(int val, System.Windows.Forms.Control ctl);

public delegate bool Delegate_Int_ReturnBool(int val);

public delegate bool Delegate_Int_String_ReturnBool(int val, string str);

public delegate bool Delegate_Int_Int_String_ReturnBool(int val, int val2, string str);

public delegate void Delegate_String_Int(string str, int val);

public delegate void Delegate_Object(object obj);
public delegate void Delegate_ObjectArray(object[] objParams);

public delegate void Delegate_Control(System.Windows.Forms.Control ctl);



//public delegate ErrorSet Delegate_BackGroundWork_ReturnErrorSet(object arg, BackgroundWorker worker, DoWorkEventArgs e);

public delegate void Delegate_Int_String_Object(int val, string str, object obj);


public delegate Image DelegateGetImageAfter(DateTime LastImageDateTime);
public delegate Image DelegateGetImage();

public delegate bool DelegatePutImageConfirm(Image img, string ImageFileName);
public delegate void DelegatePutImage(Image img, string ImageFileName);

public enum ScheduledJobTypes { Unknown, ClearFolderContent, ProcessSessions }

public enum AsyncWorkResultTypes { Unknown, CompletedWithSuccess, CompletedWithErrors, Cancelled }


public enum DBServerTypes { LocalDefault, LocalNameInstance, PosServer, RemoteOther, PosPOSServer }
public enum ProgressDetailTypes { NoDetails, HeadersOnly, FullDetails }
public enum ProgressDialogViewTypes { CompactView, ExpandedView }