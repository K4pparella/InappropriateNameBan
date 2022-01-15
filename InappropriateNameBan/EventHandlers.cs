using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace Testasdadas
{
    public class EventHandlers
    {
        Random random = Exiled.Loader.Loader.Random;
        public void OnPlayerJoining(VerifiedEventArgs ev)
        {
            int ListCount;
            bool contained;

            ListCount = Plugin.Singleton.Config.BannedNames.Count;
            
            for(int i = 0; i < ListCount; i++)
            {
                contained = ev.Player.Nickname.Contains(Plugin.Singleton.Config.BannedNames[i]);
                if(contained == true)
                {
                    Log.Debug("Attention, a player with a inappropriate name has been found, replacing name...");
                    string[] newnames = Plugin.Singleton.Config.ChangeNames.ToArray();
                    int rn = random.Next(0, newnames.Length);
                    ev.Player.DisplayNickname = Plugin.Singleton.Config.ChangeNames[rn];
                }
            }
        }
    }
}
