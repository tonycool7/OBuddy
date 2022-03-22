using System;
using System.Collections;
using UnityEngine;

public interface IMonstersModel
{
    public Vector2 MonsterPosition { get; set; }
    public float MonsterHealth { get; set; }
    public string[] MonsterDialogues { get; set; }
    public bool Aggressor { get; set; }

    public string MonsterName { get; set; }
}
