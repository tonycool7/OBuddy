using System;
using UnityEngine;

public interface IMonstersModel
{
    public Vector2 MonsterPosition { get; set; }
    public float MonsterHealth { get; set; }
    public Enum MonsterDialogues { get; set; }
    public bool Aggressor { get; set; }
}
