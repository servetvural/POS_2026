
namespace Wizard;

public class Work
{
    public string ExecutableFileName { get; set; }
    public string LocatorFileName { get; set; }
    public string BackupFolderName { get; set; } = "Backup";
    public string UserType { get; set; } = "User";
    public string Profile { get; set; } = "123456789";  
    public string[] PossibleFolders { get; set; }
    public string[] args { get; set; }

}
