using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace InappropriateNameBan
{
    public class EventHandlers
    {
        Random random = Exiled.Loader.Loader.Random;
        public void OnPlayerJoining(VerifiedEventArgs ev)
        {
            int ListCount;
            bool contained;
            bool inappropriatefound = false;
            int i = 0;

            ListCount = Plugin.Singleton.Config.BannedNames.Count;

            while (i < ListCount && inappropriatefound == false)
            {
                contained = ev.Player.Nickname.Contains(Plugin.Singleton.Config.BannedNames[i]);
                if (contained == true)
                {
                    string[] newnames = Plugin.Singleton.Config.ChangeNames.ToArray();
                    int rn = random.Next(0, newnames.Length);
                    ev.Player.DisplayNickname = Plugin.Singleton.Config.ChangeNames[rn];
                    inappropriatefound = true;
                }
            }
        }
    }
}
