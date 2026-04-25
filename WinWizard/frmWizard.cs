using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinWizard
{
    public partial class frmWizard : Form
    {
        private Work work;
        private bool blnFoundDirectory;

        public frmWizard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            work = XmlDeSerialize("work.xml", typeof(Work)) as Work;
            if (work == null)
            {
                MessageBox.Show("Error loading configuration.");
                Application.Exit();
            } else
                
            if (work == null)
            {
                MessageBox.Show("Error loading configuration. Please ensure work.xml is present and properly formatted.");
                // Application.Exit();
            } else
            {
                    string backupPath = Path.Combine(Application.StartupPath, work.BackupFolderName);
                    List<string> args = new() { work.UserType, work.Profile , backupPath};
                    lblBackupLocation.Text = backupPath;
                    work.args = args.ToArray();
                    LocateDirectory();
                if (blnFoundDirectory)
                {
                    CopyFilesToFolder();
                        StartApplication();
                } else
                {
                    MessageBox.Show("Program directory not found. Please locate the directory and try again.");
                }
            }

        }



        private void btnCopyFiles_Click(object sender, EventArgs e)
        {
            //CopyFiles();
        }

        public bool XmlSerialize(string filename, object obj, Type typ)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer xser = new System.Xml.Serialization.XmlSerializer(typ);
                TextWriter writer = null;
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

        public static object XmlDeSerialize(string filename, Type typ)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer xser = new System.Xml.Serialization.XmlSerializer(typ);
                FileStream fs = null;
                fs = new FileStream(filename, FileMode.Open);
                System.Xml.XmlReader reader = new System.Xml.XmlTextReader(fs);

                object obj = xser.Deserialize(reader);
                fs.Close();
                return obj;
            } catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void brnLocateDirectory_Click(object sender, EventArgs e)
        {
            LocateDirectory();
        }

        private void LocateDirectory()
        {
            string programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            string programDirectory = string.Empty;

            if (work == null || work.PossibleFolders == null || work.PossibleFolders.Length == 0)
            {
                MessageBox.Show("No potential folder names defined in configuration. Please check work.xml.");
                return;
            }

            foreach (string folderName in work.PossibleFolders)
            {
                string testPath = Path.Combine(programFiles, folderName);

                // Use Directory.Exists for folders, not File.Exists
                if (Directory.Exists(testPath))
                {
                    programDirectory = testPath;
                    blnFoundDirectory = true;
                    break; // Stop searching once we find a match
                }
            }

            // Fallback to FolderBrowserDialog if no default folders exist
            if (!blnFoundDirectory)
            {
                using (FolderBrowserDialog dlg = new FolderBrowserDialog())
                {
                    dlg.Description = "Select the Program Installation Directory";
                    if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        programDirectory = dlg.SelectedPath;
                    }
                }
            }

            blnFoundDirectory = File.Exists(Path.Combine(programDirectory, work.LocatorFileName));
            if (blnFoundDirectory)
                lblProgramDirectory.Text = programDirectory;
            else
            {
                programDirectory = string.Empty;
                lblProgramDirectory.Text = "Not Found";
            }
        }

        private void btnCopyFileToProgramFolder_Click(object sender, EventArgs e)
        {
            if (blnFoundDirectory)
            {
                CopyFilesToFolder();
            }
        }

        private bool CopyFilesToFolder()
        {
            if (blnFoundDirectory)
            {
                try
                {
                    DirectoryInfo pdir = new DirectoryInfo("Files"); //new DirectoryInfo(lblProgramDirectory.Text);
                    FileInfo[] filesToCopy = pdir.GetFiles();

                    int count = 0;
                    foreach (FileInfo file in filesToCopy)
                    {
                        file.CopyTo(Path.Combine(lblProgramDirectory.Text, file.Name), true);
                        count++;
                    }
                    if (count == filesToCopy.Length)
                        return true;
                    else
                    {
                        MessageBox.Show("Not all files were copied successfully. Please check the program directory and try again.");
                        return false;
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Error copying files: " + ex.Message);
                    return false;
                }
            } else
            {
                MessageBox.Show("Program directory not found. Please locate the directory and try again.");
                return false;
            }
        }

        private void btnClearFilesFromProgramFolder_Click(object sender, EventArgs e)
        {
            if (blnFoundDirectory)
            {
                ClearFilesFromProgramFolder();
            }
        }

        private bool ClearFilesFromProgramFolder()
        {
            if (blnFoundDirectory)
            {
                try
                {
                    DirectoryInfo pdir = new DirectoryInfo("Files");
                    FileInfo[] filesToCopy = pdir.GetFiles();

                    int count = 0;
                    foreach (FileInfo file in filesToCopy)
                    {
                        File.Delete(Path.Combine(lblProgramDirectory.Text, file.Name));
                        count++;
                    }
                    if (count == filesToCopy.Length)
                        return true;
                    else
                    {
                        MessageBox.Show("Not all files deleted successfully. Please check the program directory and try again.");
                        return false;
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Error deleting files: " + ex.Message);
                    return false;
                }
            } else
            {
                MessageBox.Show("Program directory not found. Please locate the directory and try again.");
                return false;
            }
        }

        private void btnStartApplication_Click(object sender, EventArgs e)
        {
            if (blnFoundDirectory)
            {
                StartApplication();
            }
        }

        private void StartApplication()
        {
            if (blnFoundDirectory && work != null)
            {
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        //FileName = Path.Combine(lblProgramDirectory.Text, "POS Office.exe"),
                        FileName = Path.Combine(lblProgramDirectory.Text, work.ExecutableFileName),
                        Arguments = string.Join(" ", work.args),
                        // RedirectStandardOutput = true, // Optional: redirect output if needed
                        //RedirectStandardError = true,  // Optional: redirect error if needed
                        // 2. Explicitly set the working directory
                        WorkingDirectory = lblProgramDirectory.Text ?? string.Empty,
                        // UseShellExecute = true,
                        //Verb = "runas" // Still including this for the admin rights you asked for!
                    };
                    //Process.Start(startInfo);

                    Process proc = new Process { StartInfo = startInfo };

                    // 1. Enable event notification
                    proc.EnableRaisingEvents = true;

                    // 2. Define what happens when the external app closes
                    proc.Exited += (sender, e) =>
                    {
                        // Ensure UI thread safety when closing the form
                        this.Invoke(new Action(() => this.Close()));
                    };

                    proc.Start();
                } catch (Exception ex)
                {
                    MessageBox.Show("Error starting application: " + ex.Message);
                }
            } else
            {
                MessageBox.Show("Program directory not found. Please locate the directory and try again.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            work = new Work
            {
                ExecutableFileName = "POS Office.exe"
            };

            work.args = new string[] { "Accountant", "Owner" };
            work.PossibleFolders = new string[] { "POS", "DTRM", "DTRMPos", "DronaxPOS" };

            XmlSerialize("work.xml", work, typeof(Work));
        }

        private void frmProcess_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (blnFoundDirectory && work != null)
            {
                if (IsProcessRunning(Path.GetFileNameWithoutExtension(work.ExecutableFileName)))
                    e.Cancel = true;
                else 
                    ClearFilesFromProgramFolder();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool IsProcessRunning(string name)
        {
            // If you are looking for "Notepad.exe", use "Notepad"
            Process[] processes = Process.GetProcessesByName(name);

            if (processes.Length > 0)
            {
                return true; // The program is running
            } else
            {
                return false; // Not found
            }
        }
    }
}
