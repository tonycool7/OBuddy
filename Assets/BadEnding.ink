EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)

// Charaters Are:
            //Player
            //Major
            //Buddy
EXTERNAL ChangeMood(characterName, mood)

// Moods Are:
            //Good
            //Angry
            //Serious
            //Happy
            //Other



VAR playerCuriosity = 0
VAR characterCounter = 0


-> start

=== start ===

{ShowCharacter("Major", "Right", "Serious")}
{ShowCharacter("Player", "Left", "Serious")}

Boss: Inspector Colagate!
Player: Yes, sir!
Chief: I have two bad news. We found the body of your buddy. He’s dead. And Rabbo is missing. We found that he was poisened yesterday at the party and the drops of poison was exactly the same as we found inside the chest of Rabbo!
Player: Nooooo
Cheif: And Rabbo has run out from our city!
Player: What is the second bad news!
Chief: You are fired for arresting the wrong monster!
{ChangeMood("Major", "Other")}
-> END
