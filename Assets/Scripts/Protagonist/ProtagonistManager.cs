using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtagonistManager : MonoBehaviour
{
    public ProtagonistController Controller;
    public ProtagonistModel Model;

    private void Awake()
    {
        Controller = new ProtagonistController(Model);
    }

    void Update()
    {
       
    }
}
