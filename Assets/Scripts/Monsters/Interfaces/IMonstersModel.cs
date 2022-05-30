using System;
using System.Collections;
using UnityEngine;

public interface IMonstersModel
{
    public Dialogue dialogueForHandCuff { get; set; }
    public Item handCuff { get; set; }
    public Dialogue dialogueForChest { get; set; }
    public Item chest { get; set; }
    public Vector2 MonsterPosition { get; set; }
    public float MonsterHealth { get; set; }
    public Dialogue monsterDialogue { get; set; }
    public bool Aggressor { get; set; }

    public string MonsterName { get; set; }
}
