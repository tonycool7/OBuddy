# OBuddy
Point and Click Narrative Based Adventure Game

# #AboutTheProject
This project was made during one-two monthes as a final project for the Advanced Game Development course at Tallinn University.

The project's primary focus is to create a point anc click adventure game.

The important keys are

## 1. Clean Code
Use consistent and readable naming conventions and coding style.
The entire code base should follow a unified coding style.

## 2. Script Persistence System
One (or more) scripts, such as a game manager or sound manager script, should exist between multiple scenes in your game, the way that it doesn't duplicate itself if the original scene is returned to.

## 3. Inventory System
The player has an inventory, 
The player is able to pick up items from the game world and carry them in inventory, 
The player is able to access these items from the inventory to use them in another location in the game world.

## 4. Dialogue System
The game has one form or another of dialogue. 
The background narrative, 
Talk between the player character and other game characters, or anything else. 

## 5. Playable Game
The game is playable from start to finish without any game-breaking bugs.

## 6. Game Polish 
The game has all graphics, 
The game has audio, U
The game has UI and other elements present. (No placeholders or missing visuals/audio.)

# #AboutAssets

Graphics are downloaded free from the websites providing free assets. All sound and music is originally made by me.

# #FurtherContributionsAndCurrentBugs
- Remove/comment out the print and Debug.Logs from the code. 
- Interacting with objects would be more intuitive to interact by clicking on the object the player wants to interact with, and if the player is just moving around, they don't interact when passing over other objects.
- Bug: Player changes direction as soon as it interacts with objects. Always looks right instead of keeping the look direction.
- Bug: Information text in corner says "CatModel" instead of "Cyclocat".
- Bug: The "X" icon to remove the equipped item doesn't work when the floor is behind it.
- The dialogue choice of telling the boss who the player arrested doesn't have an effect on the gameplay, and the player already made the choice. 
- Ink stories are in the asset folder, better put them in a folder and keep things organised like the rest of the project.
- The latest version on master branch has some bugs not in the build. the player keeps moving in place after stopping (level 1).
- There are a couple null reference errors in the third level. The game breaks at this point in editor & main character cannot be controlled.
- Text animation speed isn't consistent between editor and build. 
- It would be better to assigne variables using GetComponent, or check if GetComponent can be used once and cache the result in a variable (if will be used multiple times).
- To avoid passing data as reference (for example CharacterData), either instantiate a new class as we did, or use structs, which are value types, as opposed to classes which are reference types.
- CharacterEnums & SceneEnums are placed in a namespace for no reason.
- SaveData file won't store data correctly, because Unity doesn't serialize properties. 
- In InkManager, EndOfInvestigation property. Not to use getters and setters for more than validation and basic logic that is directly related to the prop and variable it's accessing. Setting variables and calling methods unrelated to the property is misleading and difficult to track. Place this logic in an explicit method to be called within the class itself, not the property in the class.
- Remove commented-out and unused code/scripts (e.g. MainMenu) to keep the project clean and easier to return to if needed.
- In  Inventory, OnItemAdded/Removed handlers. the ItemAdded/Removed classes seem a bit overkill for such a simple event, where you can simply pass the Item class directly without wrapping it in another class. Using EventHandler instead of Action also seems like another overkill, since you're not using the sender argument.
- In the AbstractProtagonistView we call MoveProtagonist in Update instead of taking advantage of the OnPositionChanged event in the Model script.

# #Team
* Artyom Grigoryan <sup>RockArt13</sup> - Developer, Narrative Designer, Music Composer
* Anthony Femi-Oke <sup>tonycool7</sup> - Developer

# #Comments

- Model–view–controller (MVC) is a software architectural pattern was implemented on this project.

# #RunTheGame
Play the game here: https://rockart13.itch.io/o-buddy
The game is created on Unity/C# for WebGL.


