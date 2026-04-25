using System.Drawing.Imaging;
using System.IO.Compression;

namespace WinLayer;
public class DRFile
{

    public DRFile()
    {
    }
    #region FILENAME GENERATORS
    public static string GenerateFileName(DateTime startDate, DateTime endDate, string extention)
    {
        return startDate.ToString("yyyyMMdd_HHmmss") + "_to_" + endDate.ToString("yyyyMMdd_HHmmss") + "." + extention;
    }

    public static string GenerateFileName(string StartDateAsString, string EndDateAsString, string extention)
    {
        DateTime startDate = DateTime.Parse(StartDateAsString);
        DateTime endDate = DateTime.Parse(EndDateAsString);
        return GenerateFileName(startDate, endDate, extention);
    }
    #endregion

    #region DIRECTORY FUNCTIONS
    public static void EnsureDirectory(string FileDirectory)
    {
        DirectoryInfo di = new DirectoryInfo(FileDirectory);
        if (!di.Exists)
            di.Create();
    }

    #endregion

    public static string ClearExtentionFromFullFileName(string FullFileName)
    {
        FileInfo finfo = new FileInfo(FullFileName);
        return finfo.FullName.Remove(finfo.FullName.Length - finfo.Extension.Length, finfo.Extension.Length);
    }

    public static string GetCleanFileNameOnly(string FullFileName)
    {
        FileInfo finfo = new FileInfo(FullFileName);
        return finfo.Name.Remove(finfo.Name.Length - finfo.Extension.Length, finfo.Extension.Length);
    }

    public static string GetApplicationPath()
    {
        //string str = Path.GetDirectoryName(Application.ExecutablePath + "\\");
        // str = Application.;
        FileInfo finfo = new FileInfo(Application.ExecutablePath);
        return finfo.Directory.ToString() + "\\";
    }
    //public static string GetApplicationDirectory() {
    //    return Path.GetDirectoryName(Application.ExecutablePath + "\\");
    //}

    public static string GetDialogFilter(string Extention)
    {
        return " " + Extention.ToUpper() + " Files |*" + Extention;
    }
    public static string GetDialogFilter(string[] Extentions)
    {
        string result = "";
        for (int i = 0; i < Extentions.Length; i++)
        {
            result += " " + Extentions[i].ToUpper() + " Files |*" + Extentions[i];
            if (i < Extentions.Length - 1)
                result += "|";
        }
        return result;
    }
    public static string GetDialogFilter(RawFileExtention[] ExtentionList)
    {
        string result = "";
        for (int i = 0; i < ExtentionList.Length; i++)
        {
            RawFileExtention ext = ExtentionList[i];
            result += " " + ext.Explanation + " |*" + ext.Extention;
            if (i < ExtentionList.Length - 1)
                result += "|";
        }
        return result;
    }
    public static bool ClearDirectoryContent(string directory)
    {
        try
        {
            DirectoryInfo dinfo = new DirectoryInfo(directory);
            DirectoryInfo[] subDirs = dinfo.GetDirectories();
            for (int i = 0; i < subDirs.Length; i++)
                subDirs[i].Delete(true);

            FileInfo[] files = dinfo.GetFiles();
            for (int i = 0; i < files.Length; i++)
                File.Delete(files[i].FullName);
            return true;
        } catch
        {
            return false;
        }
    }


    #region SERIALIZERS
    public static bool XmlSerialize(string filename, object obj, Type typ, bool blnInApplicationDirectory)
    {
        try
        {
            System.Xml.Serialization.XmlSerializer xser = new System.Xml.Serialization.XmlSerializer(typ);
            TextWriter writer = null;
            if (blnInApplicationDirectory)
                writer = new StreamWriter(DRFile.GetApplicationPath() + filename);
            else
                writer = new StreamWriter(filename);
            xser.Serialize(writer, obj);
            writer.Close();
            return true;
        } catch (Exception ex)
        {
            System.Windows.Forms.MessageBox.Show(ex.Message);
            return false;
        }
    }
    public static object XmlDeSerialize(string filename, Type typ, bool blnInCurrentDirectory, bool blnShowMessageBox = false)
    {
        try
        {
            System.Xml.Serialization.XmlSerializer xser = new System.Xml.Serialization.XmlSerializer(typ);
            FileStream fs = null;
            if (blnInCurrentDirectory)
                fs = new FileStream(DRFile.GetApplicationPath() + filename, FileMode.Open);
            else
                fs = new FileStream(filename, FileMode.Open);
            System.Xml.XmlReader reader = new System.Xml.XmlTextReader(fs);

            object obj = xser.Deserialize(reader);
            fs.Close();
            return obj;
        } catch (Exception ex)
        {
            if (blnShowMessageBox)
                System.Windows.Forms.MessageBox.Show(ex.Message);
            return null;
        }
    }

    /// <summary>
    /// Serializes object to a file with the given name to application directory where the .exe exist.
    /// </summary>
    /// <param name="filename"></param>
    /// <param name="obj"></param>
    /// <returns></returns>
    //public static bool BinarySerialize(string filename, object obj) {
    //    try {
    //        FileStream fs = new FileStream(filename, FileMode.Create);
    //        BinaryFormatter bf = new BinaryFormatter();
    //        bf.Serialize(fs, obj);
    //        fs.Flush();
    //        fs.Close();
    //        return true;
    //    } catch (Exception ex) {
    //        string str = ex.Message;
    //        return false;
    //    }
    //}

    /// <summary>
    /// DeSerializes object from the file with the given name. If file not in application exe directory use a full address for the file
    /// </summary>
    /// <param name="filename"></param>
    /// <returns></returns>
    //public static object BinaryDeSerialize(string filename) {
    //    string s = "";
    //    FileStream fs = null;
    //    object obj = null;
    //    try {
    //        fs = new FileStream(filename + "", FileMode.Open, FileAccess.Read);
    //        BinaryFormatter bf = new BinaryFormatter();
    //        obj = bf.Deserialize(fs);
    //        fs.Flush();
    //        fs.Close();
    //        return obj;
    //    } catch (Exception ex) {
    //        try {
    //            s = ex.Message;
    //            fs.Flush();
    //            fs.Close();
    //        } catch { }
    //        return obj;
    //    }
    //}

    //public static bool BinarySerialize(string filename, object obj,/*otherwise current directory*/ bool blnSystemDirectory) {
    //    try {
    //        FileStream fs = null;
    //        if (blnSystemDirectory)
    //            fs = new FileStream(System.Environment.SystemDirectory + "\\" + filename + "", FileMode.Create);
    //        else
    //            fs = new FileStream(System.Environment.CurrentDirectory + "\\" + filename + "", FileMode.Create);
    //        BinaryFormatter bf = new BinaryFormatter();

    //        bf.Serialize(fs, obj);

    //        fs.Flush();
    //        fs.Close();
    //        return true;
    //    } catch (Exception ex) {
    //        string str = ex.Message;
    //        return false;
    //    }
    //}

    //public static object BinaryDeSerialize(string filename, /*otherwise current directory*/ bool blnSystemDirectory) {
    //    string s = "";
    //    FileStream fs = null;
    //    object obj = null;
    //    try {
    //        if (blnSystemDirectory)
    //            fs = new FileStream(System.Environment.SystemDirectory + "\\" + filename + "", FileMode.Open, FileAccess.Read);
    //        else
    //            fs = new FileStream(System.Environment.CurrentDirectory + "\\" + filename + "", FileMode.Open, FileAccess.Read);
    //        BinaryFormatter bf = new BinaryFormatter();
    //        obj = bf.Deserialize(fs);
    //        fs.Flush();
    //        fs.Close();
    //        return obj;
    //    } catch (Exception ex) {
    //        try {
    //            s = ex.Message;
    //            fs.Flush();
    //            fs.Close();
    //        } catch { }
    //        return obj;
    //    }
    //}

    //public static bool BinarySerialize(string directory, string filename, object obj) {
    //    FileStream fs = null;
    //    try {
    //        fs = new FileStream(directory + "\\" + filename + "", FileMode.Create);
    //        BinaryFormatter bf = new BinaryFormatter();

    //        bf.Serialize(fs, obj);
    //        fs.Flush();
    //        fs.Close();
    //        return true;
    //    } catch {
    //        fs.Close();
    //        return false;
    //    }
    //}

    //public static object BinaryDeSerialize(string directory, string filename) {
    //    FileStream fs = null;
    //    object obj = null;
    //    try {
    //        fs = new FileStream(directory + "\\" + filename + "", FileMode.Open);
    //        BinaryFormatter bf = new BinaryFormatter();
    //        obj = bf.Deserialize(fs);
    //        fs.Flush();
    //        fs.Close();
    //        return obj;
    //    } catch {
    //        if (fs != null) {
    //            fs.Flush();
    //            fs.Close();
    //        }
    //        return obj;
    //    }
    //}


    public static string GetImageFormatExtention(ImageFormat format)
    {
        return format.ToString();
        //switch (format) {
        //    case ImageFormat.Bmp:
        //        return "bmp";
        //    case ImageFormat.Emf:
        //        return "emf";
        //    case ImageFormat.Exif:
        //        return "exif";
        //    case ImageFormat.Gif:
        //        return "gif";
        //    case ImageFormat.Icon:
        //        return "ico";
        //    case ImageFormat.Jpeg:
        //        return "jpeg";
        //    case ImageFormat.MemoryBmp:
        //        return "bmp";
        //    case ImageFormat.Png:
        //        return "png";
        //    case ImageFormat.Tiff:
        //        return "tiff";
        //    case ImageFormat.Wmf:
        //        return "wmf";
        //}
    }
    #endregion

    #region ZIP FUNCTIONS
    private void TestCompress()
    {
        string srcFile = "C:\\temp\\file-to-compress.txt";
        string dstFile = "C:\\temp\\compressed-file.gzip";

        FileStream fsIn = null; // will open and read the srcFile
        FileStream fsOut = null; // will be used by the GZipStream for output to the dstFile
        GZipStream gzip = null;
        byte[] buffer;
        int count = 0;

        try
        {
            fsOut = new FileStream(dstFile, FileMode.Create, FileAccess.Write, FileShare.None);
            gzip = new GZipStream(fsOut, CompressionMode.Compress, true);

            fsIn = new FileStream(srcFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            buffer = new byte[fsIn.Length];
            count = fsIn.Read(buffer, 0, buffer.Length);
            fsIn.Close();
            fsIn = null;

            // compress to the destination file
            gzip.Write(buffer, 0, buffer.Length);
        } catch (Exception ex)
        {
            // handle or display the error 
            System.Diagnostics.Debug.Assert(false, ex.ToString());
        } finally
        {
            if (gzip != null)
            {
                gzip.Close();
                gzip = null;
            }
            if (fsOut != null)
            {
                fsOut.Close();
                fsOut = null;
            }
            if (fsIn != null)
            {
                fsIn.Close();
                fsIn = null;
            }
        }
    }


    private void TestDecompress()
    {
        string srcFile = "C:\\temp\\compressed-file.gzip";
        string dstFile = "C:\\temp\\decompressed-file.txt";

        FileStream fsIn = null; // will open and read the srcFile
        FileStream fsOut = null; // will be used by the GZipStream for output to the dstFile
        GZipStream gzip = null;
        const int bufferSize = 4096;
        byte[] buffer = new byte[bufferSize];
        int count = 0;

        try
        {

            fsIn = new FileStream(srcFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            fsOut = new FileStream(dstFile, FileMode.Create, FileAccess.Write, FileShare.None);
            gzip = new GZipStream(fsIn, CompressionMode.Decompress, true);
            while (true)
            {
                count = gzip.Read(buffer, 0, bufferSize);
                if (count != 0)
                {
                    fsOut.Write(buffer, 0, count);
                }
                if (count != bufferSize)
                {
                    // have reached the end
                    break;
                }
            }
        } catch (Exception ex)
        {
            // handle or display the error 
            System.Diagnostics.Debug.Assert(false, ex.ToString());
        } finally
        {
            if (gzip != null)
            {
                gzip.Close();
                gzip = null;
            }
            if (fsOut != null)
            {
                fsOut.Close();
                fsOut = null;
            }
            if (fsIn != null)
            {
                fsIn.Close();
                fsIn = null;
            }
        }
    }
    #endregion

    public static List<string> GetLinesAsListFromTextFile(string FullFileName)
    {
        List<string> theList = new List<string>();
        if (File.Exists(FullFileName))
        {
            theList.AddRange(File.ReadAllLines(FullFileName));
        }
        return theList;
    }
}
