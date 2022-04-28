using System;
using System.Collections;
using UnityEngine;

public interface IMonstersModel
{
    public Vector2 MonsterPosition { get; set; }
    public float MonsterHealth { get; set; }
    public Dialogue MonsterDialogue { get; set; }
    public bool Aggressor { get; set; }

    public string MonsterName { get; set; }
}
