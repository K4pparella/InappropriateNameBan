![Github All Releases](https://img.shields.io/github/downloads/quazEx/InappropriateNameBan/total.svg)
# InappropriateNameBan
A plugin that helps server admin to censor / change inappropriate player nicknames


# Installation
You will (obviusly) need Exiled 4.2.2 (download found [**here**](https://github.com/Exiled-Team/EXILED/releases))(installation guide found [**here**](https://github.com/Exiled-Team/EXILED#installation).

Then if you have windows move InappropriateNameBan.dll into C:\Users\(Your_User)\AppData\Roaming\EXILED\Plugins

If you have linux move InappropriateNameBan.dll into ~/.config/EXILED/Plugins

# Default Config
```
# Is the plugin enabled?
  is_enabled: true
  # The list that is used to store all of the inappropriate names
  banned_names:
  - Fuck
  - Dick
  - YourBannedName
  # The list of the names that will change the inappropriate name (will pick in a random order) (leave one name to use that one)
  change_names:
  - Inappropriate Name
  ```
