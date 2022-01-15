using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace Testasdadas
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("The list that is used to store all of the bad names")]
        public List<string> BannedNames { get; set; } = new List<string>
        {
            "BOSSETTI"
        };

        [Description("The list of the names that will change the bad name (will pick in a random order)")]
        public List<string> ChangeNames { get; set; } = new List<string> 
        {
            "CENSURATO"
        };
    }
}
