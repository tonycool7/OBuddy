EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)

// Charaters Are:
            //Player
            //Cyclocat
            //Lizzard
            //Rabbo
            //Major
            //Buddy
EXTERNAL ChangeMood(characterName, mood)

// Moods Are:
            //Good
            //Angry
            //Serious
            //Happy
            //Other

EXTERNAL ShowScene(sceneName, position)

// variables
// curiosity for Easter Egg
VAR playerCuriosity = 0
VAR characterCounter = 0
VAR endOfInvestigation = 0



-> start

=== start ===

{ShowCharacter("Player", "Left", "Serious")}

Player: So, let's start investigation! #askQuestion


-> character_choose




===character_choose===

{characterCounter < 3:
   *** Cyclocat, get in here!
    -> cyclocat_story
    *** Lizzard, get in here!
    -> lizzard_story
    *** Rabbo, get in here!
    -> rabbo_story

  - else:
    -> major_story
}



=== cyclocat_story ===
{ShowCharacter("Cyclocat", "Right", "Good")}
Player: So, Cyclocat. 
Cyclocat: Yes, sir. 
{ChangeMood("Player", "Good")}
Player: What question to ask, hmm?. #askQuestion
-> cage_question
=== cage_question ===
* How are you?
Cyclocat: Don't you see, sir?  
~playerCuriosity += 10
-> cage_question 
->DONE
* What time is now?
{ChangeMood("Cyclocat", "Happy")}
Cyclocat: I really don't know? Maybe it's 2:95? 
{ChangeMood("Player", "Angry")}
Player: You are a real idiot!
~playerCuriosity += 20
-> cage_question
->DONE
* What the hell were you doing in the cage?
{ChangeMood("Cyclocat", "Happy")}
Cyclocat: Huh.... I told ya! After sipping Lizzard's favorite smoothie...
{ChangeMood("Player", "Angry")}
Player: Such a horrible day, and now you? Stop joking, you freak! 
Cyclocat: Why, sir? What did happen?
{ChangeMood("Player", "Serious")}
Player: I can't find my buddy since early morning, the city is in chaos. You were in a cage... So, everything is horrible!
Cyclocat: Maybe I can help you to find your buddy? I saw him yesterday at the party.
{ChangeMood("Player", "Angry")}
Player: This freak is kidding me. #askQuestion

->buddy_question

=== buddy_question ===
*** Tell me what you know about my buddy?
-> tell_about_buddy
*** Tell me who put you in the cage?
-> tell_about_who
*** Tell me about the party yesterday?
-> tell_about_party



=== tell_about_buddy===
{ChangeMood("Cyclocat", "Other")}
Cyclocat: Your buddy was with us yesterday.
{ChangeMood("Player", "Happy")}
Player: With the freaks like you? Imposible!
Cyclocat: Yes, sir! And he was drinking his favourite whiskey with joogya!
{ChangeMood("Player", "Angry")}
Player: I don't beleive you.
Cyclocat: I'll tell one thing, and you'll absolutely believe me after that.
{ChangeMood("Player", "Serious")}
Player: Okay, so tell me!
{ChangeMood("Cyclocat", "Serious")}
Cyclocat: I'll say it since you let me out of the cage!
{ChangeMood("Player", "Angry")}
Player: Nooo! Stop this pathos, you freak! Tell me right now!
{ChangeMood("Cyclocat", "Happy")}
Cyclocat: So your buddy was wearing The Scrolling Thrones T-shirt you got him for his birthday.
{ChangeMood("Player", "Happy")}
Player: No way! How do you know these details?!
{ChangeMood("Cyclocat", "Good")}
Cyclocat: I told ya! He was with us yesterday and he told me that!
{ChangeMood("Player", "Serious")}
Player: Okay! Now I guess I beleive you that he was with you yesterday.
-> cyclocat_questions 

=== tell_about_who ===
{ChangeMood("Player", "Serious")}
Player: So, Lizzard put you in the cage?
{ChangeMood("Cyclocat", "Angry")}
Cyclocat: Yes, that freak!
{ChangeMood("Player", "Happy")}
Player: Because you drank her smoothie?
Cyclocat: Yes.
Player: Bastard!
{ChangeMood("Cyclocat", "Serious")}
Cyclocat: Thank's for support, sir.
{ChangeMood("Player", "Angry")}
Player: I don't support you, freak! I'm angry because the only person in this city who can put someone in a cage is ME!
{ChangeMood("Cyclocat", "Other")}
Cyclocat: Looks like Mr. Lizzard too.
{ChangeMood("Player", "Other")}
Player: That we will see!
~playerCuriosity += 15
-> buddy_question

=== tell_about_party ===
{ChangeMood("Cyclocat", "Happy")}
Cyclocat: It was simply a regular party, nothing out of the usual. It lasted long, though!
{ChangeMood("Player", "Other")}
Player: How much did you drink yesterday?
{ChangeMood("Cyclocat", "Good")}
Cyclocat: Math isn't my strong suit. I have no idea how to do arithmetic. Maybe 42?
{ChangeMood("Player", "Serious")}
Player: 42 bottles?
{ChangeMood("Cyclocat", "Good")}
Cyclocat: Maybe not bottles, but shotes. I don't know.
~playerCuriosity += 10
-> buddy_question


=== cyclocat_questions ===
*** How did you find the chest?
-> tell_about_chest
*** Who was with you at the party?
-> tell_about_company
*** When did my buddy arrive at the party?
-> tell_about_buddy_arrive


=== tell_about_chest ===
{ChangeMood("Cyclocat", "Happy")}
Cyclocat: I saw it around 2 hours later, when the party began. It was right there on our table. And it was quite heavy. It bothered me, so I set it away.
{ChangeMood("Player", "Other")}
Player: Heavy? But it was empty and not heavy at all!
{ChangeMood("Cyclocat", "Good")}
Cyclocat: Yes, I noticed it was empty at the end of the party. Someone most likely removed something from the chest. There were a few drips of liquid as well.
{ChangeMood("Player", "Serious")}
Player: Do you know who brought the chest?
{ChangeMood("Cyclocat", "Good")}
Cyclocat: No idea!
-> cyclocat_byebye

=== tell_about_company ===
{ChangeMood("Cyclocat", "Happy")}
Cyclocat: Lizzard and I were there, and later Rabbo and, as I said, your buddy arrived.
{ChangeMood("Player", "Other")}
Player: Lizzard? But she told me that she wasn't at the party 
{ChangeMood("Cyclocat", "Good")}
Cyclocat: Sir, you've been fooled by this liar. All night, she was with us. She also argued that insects were better than salmon in terms of flavor.
{ChangeMood("Player", "Angry")}
Player: Stop telling me about your idiotic conversations with Lizzard!
{ChangeMood("Cyclocat", "Serious")}
Cyclocat: I am sorry sir.
~playerCuriosity += 5
-> cyclocat_questions

=== tell_about_buddy_arrive ===
{ChangeMood("Cyclocat", "Happy")}
Cyclocat: We had already there when he came.
{ChangeMood("Player", "Other")}
Player: You, Lizzard and Rabbo?
{ChangeMood("Cyclocat", "Good")}
Cyclocat: No, Lizzard and me. Rabbo came after your buddy!
{ChangeMood("Player", "Angry")}
Player: When my buddy left?
{ChangeMood("Cyclocat", "Serious")}
Cyclocat: I don't remember. But he left even without saying goodbye.
{ChangeMood("Player", "Happy")}
Player: It's okay. Freaks like you don't need to say goodbye!
~playerCuriosity += 10
-> cyclocat_questions

=== cyclocat_byebye ===
{ChangeMood("Player", "Happy")}
Player: Ok, get out now!
Cyclocat: Bye, sir.
{HideCharacter("Cyclocat")}
~characterCounter++
-> character_choose





=== lizzard_story ===

{ShowCharacter("Lizzard", "Right", "Good")}
{ChangeMood("Player", "Good")}
Lizzard: Hey, sir!
Player: Let's ask her... #askQuestion
-> Lizzard_question

=== Lizzard_question ===
*** Tell me what you know about my buddy?
-> tell_about_buddy2
*** Tell me why you put Cyclocat in the cage?
-> tell_about_why
*** Tell me about the party yesterday?
-> tell_about_party2


=== tell_about_buddy2 ===
Lizzard: I'm completely unaware of the situation.
Player: Who knows?
Lizzard: I don't know who knows!
{ChangeMood("Player", "Angry")}
Player: What you know?
{ChangeMood("Lizzard", "Other")}
Lizzard: I do no nothing.
~playerCuriosity += 10
-> Lizzard_question

=== tell_about_why ===
{ChangeMood("Lizzard", "Angry")}
Lizzard: Because that freak drank my smoothie.
{ChangeMood("Player", "Serious")}
Player: Stop calling each other freaks! You, Freaks!
{ChangeMood("Lizzard", "Other")}
Lizzard: But...
{ChangeMood("Player", "Angry")}
Player: Who do you think you are? Only I can put monsters like you in cages in this city!
{ChangeMood("Lizzard", "Angry")}
Lizzard: But...
{ChangeMood("Player", "Other")}
Player: Shut up!
~playerCuriosity += 10
-> Lizzard_question

===tell_about_party2===
{ChangeMood("Lizzard", "Serious")}
Lizzard: I wasn't at the party.
Player: Why?
{ChangeMood("Lizzard", "Happy")}
Lizzard: Because I dont have a QR!
{ChangeMood("Player", "Happy")}
Player: Oh, I see.
{ChangeMood("Lizzard", "Happy")}
Lizzard: Any other question?
{ChangeMood("Player", "Angry")}
Player: You think I'm as dumb as you are to have taken your word for it? Stop playing games and give me the truth, because I know you were at the party the other night.
{ChangeMood("Lizzard", "Serious")}
Lizzard: Whoever said I was at the party, they were lying! They're deceiving you, sir!
{ChangeMood("Player", "Good")}
Player: Okay, I'll go ahead and get on with my investigation. Don't you ever try to fool me!
{ChangeMood("Lizzard", "Good")}
Lizzard: Sir, I only need to prove my innocence.
{ChangeMood("Player", "Happy")}
Player: Well, get out now!
{HideCharacter("Lizzard")}
~characterCounter++
->character_choose

=== rabbo_story ===
{ShowCharacter("Rabbo", "Right", "Good")}
{ChangeMood("Player", "Good")}
Rabbo: I am here, sir!
Player: Let's ask her... #askQuestion
-> Rabbo_question

=== Rabbo_question ===
*** Tell me what you know about my buddy!
-> tell_about_buddy3
*** Tell me about the chest!
-> tell_about_chest2
*** Tell me about the party yesterday!
-> tell_about_party3


===tell_about_buddy3===
{ChangeMood("Rabbo", "Serious")}
Rabbo: Last night, he was with us at the party!
{ChangeMood("Player", "Good")}
Player: When he came?
{ChangeMood("Rabbo", "Good")}
Rabbo: Honestly, I can't really remember. Yesterday, I arrived really too late. He just stayed for a few minutes and then left. He wasn't drinking.
Player: When he went, did he say goodbye?
{ChangeMood("Rabbo", "Happy")}
Rabbo: Yes, he and I shook hands.
{ChangeMood("Player", "Angry")}
Player: I can't believe he was at the same party with idiots like you. What he was wearing?
{ChangeMood("Rabbo", "Good")}
Rabbo: Maybe a t-shirt with the logo of some well-known musical group?
{ChangeMood("Player", "Happy")}
Player: The Scrolling Thrones T-shirt?
{ChangeMood("Rabbo", "Happy")}
Rabbo: Yes, exactly!
~playerCuriosity += 10
->Rabbo_question

===tell_about_chest2===
{ChangeMood("Rabbo", "Serious")}
Rabbo: There was a gift for my boyfriend.
Player: Who is your boyfriend?
{ChangeMood("Rabbo", "Other")}
Rabbo: Grizzly, and I bought a teddy bear for him!
{ChangeMood("Player", "Angry")}
Player: Stop telling me about your idiotic gifts to your boyfriend!
{ChangeMood("Rabbo", "Angry")}
Rabbo: But you just asked me to tell it, sir!
{ChangeMood("Player", "Good")}
Player: Was there any bottle or some liquid in the chest?
{ChangeMood("Rabbo", "Good")}
Rabbo: No, sir. There was only the teddy bear!
Player: Okey, get out!
{ChangeMood("Rabbo", "Happy")}
Rabbo: What?
{ChangeMood("Player", "Angry")}
Player: Get out!
{ChangeMood("Rabbo", "Good")}
{HideCharacter("Rabbo")}
~characterCounter++
->character_choose


===tell_about_party3===
{ChangeMood("Rabbo", "Serious")}
Rabbo: Drinks, music, dances. 
{ChangeMood("Player", "Serious")}
Player: Who was there with you?
{ChangeMood("Rabbo", "Serious")}
Rabbo: Cyclocat and Lizzard.
{ChangeMood("Player", "Happy")}
Player: So, Lizzard was with you?
{ChangeMood("Rabbo", "Angry")}
Rabbo: They were arguing all night long over some foods, wasn't that the case?
{ChangeMood("Player", "Angry")}
Player: I am asking questions, not you!
~playerCuriosity += 15
->Rabbo_question

===major_story===
{ShowCharacter("Major", "Right", "Good")}
Boss: Ispector Colgate!
{ChangeMood("Player", "Good")}
Player: Yes, sir!
{ChangeMood("Major", "Serious")}
Boss: Could you find Patrick, your buddy?
{ChangeMood("Player", "Serious")}
Player: Sir, I've been digging into who was involved in my friend's disappearance!
Boss: Could you collect enough evidence to arrest someone?
Player: Yes, I think I have now!
{ChangeMood("Major", "Good")}
Boss: Then, all the best! Let the person who committed this crime be arrested!
~endOfInvestigation = 1
->END
