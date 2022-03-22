using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtagonistManager : MonoBehaviour
{
    public ProtagonistController Controller;
    public ProtagonistModel Model;
    public ProtagonistView View;

    private void Awake()
    {
        Controller = new ProtagonistController(Model, View);
    }

    void Update()
    {
       
    }
}
