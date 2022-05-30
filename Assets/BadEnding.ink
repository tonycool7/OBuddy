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
{ChangeMood("Player", "Good")}
Player: What to say? #askQuestion
* I think so.
Boss: What does it mean? You either did or you did not!
~playerCuriosity+=10
->part2
+ Yes, I, did.
Boss: Well done.
->part2

=== part2 ===
{ChangeMood("Major", "Good")}
Boss: So, who you did arrest?
{ChangeMood("Player", "Serious")}
Player: I arrested...

*Cyclocat
Boss: No more meows in our city!
->part3
*Lizzard
Boss: Insects will be happy!
->part3
*Rabbo
Boss: Who will buy carrots from Granny Babushka?
->part3

=== part3 ===
{ChangeMood("Player", "Happy")}
Player: Haha!
{ChangeMood("Major", "Serious")}
Boss: What you think did you caught the right guy?
{ChangeMood("Player", "Serious")}
Player: Hmm... I think

*Yes
Boss: I have three pieces of awful news for you. First and foremost, you are overconfident in yourself!
->part4
*No
Boss: I have two pieces of bad news and one piece of good news. The good news is that you are right!
->part4
*Maybe
Boss: I see you've always been self-conscious!
->part4

=== part4 ===
{ChangeMood("Major", "Good")}
Boss: Let's get started with the two pieces of bad news I have for you!
{ChangeMood("Player", "Serious")}
Player: Okay!
Boss: Rabbo has vanished. We discovered that she poisoned your buddy at the party yesterday, and the poison drops collected at the crime scene were identical to those found in Rabbo's chest!
{ChangeMood("Player", "Angry")}
Player: Oh, no! What's the other bad news?
{ChangeMood("Major", "Angry")}
Boss: We found the dead body of your buddy. 
{ChangeMood("Player", "Other")}
Player: Nooooo... 
Boss: And Rabbo has run out from our city!
Player: No, my buuuudddyyyy....
Boss: There's one more piece of bad news!
{ChangeMood("Player", "Serious")}
Player: Hm...
Chief: You're fired for arresting the wrong monster!
{ChangeMood("Player", "Other")}
{HideCharacter("Player")}
{HideCharacter("Major")}
~endOfInvestigation = true
-> END
