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
VAR endOfInvestigation = 0


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
Boss: I have three pieces of good news for you. First and foremost, you are the best!
->part4
*No
Boss: I have two pieces of good news and one piece of bad news. The bad news is that you are wrong! Haha, joking!
->part4
*Maybe
Boss: I see you've always been self-conscious!
->part4

=== part4 ===
{ChangeMood("Major", "Good")}
Boss: Let's get started with the two pieces of good news I have for you!
{ChangeMood("Player", "Serious")}
Player: Okay!
Boss: Rabbo was involved in the crime!
{ChangeMood("Player", "Angry")}
Player: Oh, I knew that! What's the other good news?
{ChangeMood("Major", "Angry")}
Boss: I'll go now, and your buddy will tell you the rest!
{HideCharacter("Major")}
{ChangeMood("Player", "Happy")}
{ShowCharacter("Patrick", "Right", "Good")}
Buddy: Buddyyy!!
{ChangeMood("Player", "Happy")}
Player: Buddddy!
{ChangeMood("Patrick", "Happy")}
Buddy: That racist Rabbo wanted to poison me!
{ChangeMood("Player", "Angry")}
Player: Piece of a carrot!
Buddy: She hates us just because we are humanoids! Freaking Monster!
Player: What about Lizzard? Was she with you yesterday?
{ChangeMood("Patrick", "Good")}
Buddy: Yes, she also was there!
{ChangeMood("Player", "Angry")}
Player: But she assured me that she was not.
Buddy: Perhaps she was just scared. After all, she fought with Cyclocat and caged him. So she probably believed she'd done enough to be labeled as a suspect.
{ChangeMood("Player", "Happy")}
Player: That was really dumb of her.
{ChangeMood("Patrick", "Happy")}
Buddy: Indeed. Anyway, I'd probably be dead if you hadn't arrested Rabbo today!
Player: Your buddy knows his job!
{ChangeMood("Player", "Good")}
Buddy: And that's why I am proud of it!
{ChangeMood("Patrick", "Good")}
{HideCharacter("Player")}
{HideCharacter("Patrick")}
~endOfInvestigation = 2
-> END
