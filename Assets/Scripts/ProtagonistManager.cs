using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtagonistManager : MonoBehaviour
{
    public MainProtagonistController Controller;
    public MainProtagonistModel Model;
    public MainProtagonistView View;

    private void Awake()
    {
        Controller = new MainProtagonistController(Model, View);
    }

    void Update()
    {
       
    }
}
