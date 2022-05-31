using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

[System.Serializable]
public class Dialogue
{
    public string characterName;

    [TextArea(3,10)]
    public string[] sentences;
}
