# Plan of Action

- Create a DLL Modding tool for Donkey Kong that alters the base game experience
- One design pattern of my choice (State Pattern) to allow for double jump DLL Mod

# Extra Jumps DLL Mod

The purpose of this DLL mod is to enable the player to perform multiple jumps, as set by the user. The design pattern that would be utilized in this case would be a state pattern, as this would allow for rapid state changes from idle to jumping upon the request of the user. The player will enter a jump amount into a text file that will be read by the DLL, dynamically being added into the games memory in real-time. During the game, the user can jump the specified amount of jumps within a given airtime window. Some modifications may need to be made to the Game game movement scripts in order to accommodate for this new modded functionality.

# Diagram Example

![image.png](https://prod-files-secure.s3.us-west-2.amazonaws.com/6d3e1fab-4dc4-4ea5-a1e2-02577c83cb86/0945dbf6-db73-4d92-a27c-087ab6c58d6d/image.png)
