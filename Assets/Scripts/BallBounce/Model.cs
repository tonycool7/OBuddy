using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : AccessPoint
{
    // Data
    public int BounceCount;
    public int WinCondition;

    public void IncreaseBounce() { BounceCount++; }
}
