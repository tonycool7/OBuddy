using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class for all elements in this application.
public class AccessPoint : MonoBehaviour
{
    // Gives access to the application and all instances.
    public Application App { get { return GameObject.FindObjectOfType<Application>(); } }
}


// Entry point into the app
public class Application : MonoBehaviour
{
    public Model Model { get; private set; }
    public BounceView View { get; private set; }
    public Controller Controller { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
   
    }

}
