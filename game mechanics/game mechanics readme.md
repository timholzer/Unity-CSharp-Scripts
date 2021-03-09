How to use different game mechanics scripts:
  ## Table of Contents
    1. GameTime.cs




## GameTime.cs
![](screenshots/gametime.png)

  GameTime.cs is a script which adds game day and time to the UI. It also has a total seconds int, as well as a days, hours, minutes, seconds to allow for a game tick system to be tied to other things. I also have scripting that allows for 10x and 100x speed of the game seconds ticks.

## To make this script work:
    
You'll need 1 or 2 UI Text elements, one for the GameClock and an optional one for TotalSeconds. Comment out lines 74 and 11 if you don't want the TotalSeconds. If you want to have the speed changes then create a onex, tenx, and hundredx UI button. You'll also need to keybind keys to activate each button and call them "1x Speed", 10x Speed", and "100x Speed" I used the 1, 2, and 3 keys for them. If you don't want speed changes you'll need to comment out line 12-14 and maybe lines 44-62. Drag this script onto you player object or other persistant object and link up your game objects, and you should then be good to go.