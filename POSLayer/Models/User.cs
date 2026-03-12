using System;
using System.Collections.Generic;

using POSLayer.Library;

namespace POSLayer.Models;

public partial class User : BaseClass
{
    public string? UserName { get; set; } = "unknown";

    public string? UserPassword { get; set; } = string.Empty;

    public POSLayer.Library.AccessLevels AccessLevel { get; set; }   = AccessLevels.User;


    public User(string UserName, string UserPassword, AccessLevels AccessLevel)
    {
        this.UserName = UserName;
        this.UserPassword = UserPassword;
        this.AccessLevel = AccessLevel;
    }
    public User(string IID, string UserName, string UserPassword, AccessLevels AccessLevel)
    {
        this.IID = IID;
        this.UserName = UserName;
        this.UserPassword = UserPassword;
        this.AccessLevel = AccessLevel;
    }

    public User Clone()
    {
        return new User(this.IID, this.UserName, this.UserPassword, this.AccessLevel);
    }
    //User, Manager, SuperUser, TechnicalSupport
    public bool IsManagerOrMore()
    {
        return ((int)AccessLevel >= (int)AccessLevels.Manager);
    }
    public bool IsSuperUserOrMore()
    {
        return ((int)AccessLevel >= (int)AccessLevels.SuperUser);
    }
    public bool IsTechnicalOrMore()
    {
        return ((int)AccessLevel >= (int)AccessLevels.TechnicalSupport);
    }
}
