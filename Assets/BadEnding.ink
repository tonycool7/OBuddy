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
VAR endOfInvestigation = false


-> start

=== start ===

{ShowCharacter("Major", "Right", "Serious")}
{ShowCharacter("Player", "Left", "Serious")}

Boss: Inspector Colagate!
Player: Yes, sir!
Boss: Did you arrest someone?
Player: What to say? #askQuestion
* I think so.
Boss: What does it mean? You either did or you did not!
~playerCuriosity+=10
->part2
+ Yes, I, did.
Boss: Well done.
->part2

=== part2 ===
Boss: So, whom you did arrest?
Player: I arrested...

*Cyclocat
Boss: No more meow in this city!
->part3
*Lizzard
Boss: Insects will be happy!
->part3
*Rabbo
Boss: Who will but carrots from Granny Babushka?
->part3

=== part3 ===
Player: Haha
Boss: What you think did you caught the right guy?
Player: Hmm... I think

*Yes
Boss: I have bad three bad news for you. First, you very inqnavstah!
->part4
*No
Boss: I have two bad news and one good. Good news is that you are right!
->part4
*Maybe
Boss: I see you always was this kind of uncertain person!
->part4

=== part4 ===

Chief: I have two bad news. We found the body of your buddy. He’s dead. And Rabbo is missing. We found that he was poisened yesterday at the party and the drops of poison was exactly the same as we found inside the chest of Rabbo!
Player: Nooooo
Cheif: And Rabbo has run out from our city!
Player: What is the second bad news!
Chief: You are fired for arresting the wrong monster!
{ChangeMood("Major", "Other")}
~endOfInvestigation = true
-> END
