using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace InappropriateNameBan
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Should debug message be enabled?")]
        public bool Debug { get; set; } = false;

        [Description("The list that is used to store all of the inappropriate names")]
        public List<string> BannedNames { get; set; } = new List<string>
        {
            "Fuck",
            "Dick",
            "YourBannedName"
        };

        [Description("The list of the names that will change the inappropriate name (will pick in a random order) (leave one name to use that one)")]
        public List<string> ChangeNames { get; set; } = new List<string> 
        {
            "Censored"
        };
    }
}
