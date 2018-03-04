This project is a collection of useful Scripts and Classes that can be used in a variety of games.


# Character Reskin
Add the CharacterReskin script to the GameObject to be reskinned. The script will recursively look through the GameObject for SpriteRenderers and look for a suitable Sprite to assign to it depending on the GameObject's name.

Example use:
character.ChangeCostume (newSkinFile);

The newSkinFile needs to be in the Resources directory. If newSkinFile is "normalCostume", the script will look for a file in the Resources directory like "Assets/Resources/normalCostume.png".

The sprite needs to be split into nultiple sprites. The name of the sub-sprites need to match the name of the GameObject of the SpriteRenderer for it to work.

# Object Shake
Add the ObjectShake script to the object that needs to be shaked. This is useful if it is attached to the Camera in the scene. 

The script can be used to trigger a burst of shaking by using the following code. This will shake it for 1 second.
objectShaker.ShakeForDuration (1.0f);

The object can be triggered to start or stop shaking manually by using the **StartShaking** and **StopShaking** methods.
objectShaker.StartShaking();
objectShaker.StopShaking();

Click the **Shake Object** button to use test the script when the Scene is running. 

# Rotate Game Object
Add the GameObjectRotator script to the GameObject and set the Rotation Speed property in the inspector to specify the continuous z-axis rotation of the GameObject.

# Time
Get the current time
string time = TimeDiff.TimeNow();

Get the amount of hours since a specific time
TimeDiff.HoursSince(time)

Get the amount of minutes since a specific time
TimeDiff.MinutesSince(time)

# Screen Shot Share
Attach the ScreenShotShare script to a GameObject and set the title and bodyText properties. When a screen shot needs to be shared, call the **SaveAndShareImage** method. This saves a screenshot to a temporary file and calls the native share APIs to perform the share.

# Randomizing animations
Attach the StartOnRandomFrame script to an animated object. Define the Animation name that the game object is going to be animated and the script will start the animation at a random frame within the animation. This is useful when instantiating a lot of game objects but want them to get their animations out of sync so it looks less robotic.

# Social API
Enable Google Play Game Services by adding the following define directive GOOGLE_PLAY_GAMES_ENABLED
Edit -> Project Settings -> Player. Add GOOGLE_PLAY_GAMES_ENABLED to the Scripting Define Symbols under the Configuration section.
