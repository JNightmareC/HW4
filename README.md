# HW4
## Devlog

The Model view controler pattern is actually quite easy to see in this project. Like the example in the slides, it involes the aesthetics (the view), being the sound effects in the game (the Audio class I made), along with the UI that is shown on screen (The game UI class that I made). Those two bits were subscribed to the player class via the locator of the "GameController" class. Those were intermingled with pipes as well, but they controled when the View would change in the game.
My singleton used in this project was in the game controller. Its purpose was to have a locator reference for the Player script, so that all other scripts realated to it would have easy acsess to when its events were called, like playing noises when it interacted with the world, and changing the UI point counter every time it went through a pipe sucsessfully. Instead of having to make a reference of player in every script, I just need to subscribe the instance in start of both scripts that directly need the Player data to function. The events I mainly used were hte delegates "_flapped" to track when a player pressed space so that it played a new noise, "_hitPipe" to track when a pipe is hit to play a noise and stop the game, and the "_points", which plays a noise and changes the UI points. 


## Open-Source Assets
If you added any other assets, list them here!
- [_Wolf__'s Industrial Pipe Platformer Tileset](https://wwolf-w.itch.io/industrial-pipe-platformer-tileset) - Pipes
- [carysaurus' Bird Sprites with Animations](https://carysaurus.itch.io/bird-sprites) - Crow sprite
- [Sounds By Dane](https://soundsbydane.itch.io/8-bit-sound-pack) - Sound effects