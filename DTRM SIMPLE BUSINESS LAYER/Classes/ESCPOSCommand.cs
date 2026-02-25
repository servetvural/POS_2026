
namespace DTRMNS {

    public class ESCPOSCommand
    {
        public ESCPOSCommand()
        {
        }
        public static string GetCommand(ESCPOSCommandTypes command)
        {
            return GetCommand(command, null);
        }
        public static string GetCommand(ESCPOSCommandTypes command, object[] objArr)
        {
            switch (command)
            {
                case ESCPOSCommandTypes.MoveCursorRight:
                    return new string(new char[] { (char)9 });
                case ESCPOSCommandTypes.MoveCursorLeft:
                    return new string(new char[] { (char)8 });
                case ESCPOSCommandTypes.MoveCursorUp:
                    return new string(new char[] { (char)31, (char)10 });
                case ESCPOSCommandTypes.MoveCursorDown:
                    return new string(new char[] { (char)10 });
                case ESCPOSCommandTypes.MoveCursorToRightEndPosition:
                    return new string(new char[] { (char)31, (char)13 });
                case ESCPOSCommandTypes.MoveCursorToLeftEndPosition:
                    return new string(new char[] { (char)13 });
                case ESCPOSCommandTypes.MoveCursorToHomePosition:
                    return new string(new char[] { (char)11 });
                case ESCPOSCommandTypes.MoveCursorToBottomPosition:
                    return new string(new char[] { (char)31, (char)66 });
                case ESCPOSCommandTypes.MoveCursorToSpecifiedPosition:
                    // Requires int x (1 to 20 or more): break; case int y (1 or 2 as lines)
                    return new string(new char[] { (char)31, (char)36, (char)objArr[0], (char)objArr[1] });
                case ESCPOSCommandTypes.ClearDisplayScreen:
                    return new string(new char[] { (char)12 });
                case ESCPOSCommandTypes.ClearCursorLine:
                    return new string(new char[] { (char)24 });
                case ESCPOSCommandTypes.BlinkDisplayScreen:
                    return new string(new char[] { (char)31, (char)69, (char)objArr[0] });
                case ESCPOSCommandTypes.DisplayTime:
                    return new string(new char[] { (char)27, (char)84, (char)objArr[0], (char)objArr[1] });
                case ESCPOSCommandTypes.SelectInternationalCharacterSet:
                    return new string(new char[] { (char)27, (char)82, (char)objArr[0] });
                case ESCPOSCommandTypes.SetCommandMode_To_ESCPOS_For_VFD450:
                    return new string(new char[] { (char)4, (char)1, (char)77, (char)49, (char)23 });
                case ESCPOSCommandTypes.SetCommandMode_To_ESCPOS_For_CD7220:
                    return new string(new char[] { (char)2, (char)5, (char)67, (char)49, (char)3 });
                default:
                    return "";
            }
        }

    }

}
