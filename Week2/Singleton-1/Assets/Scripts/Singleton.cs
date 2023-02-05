using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// a class is a blur print of creating object
public class Singleton : MonoBehaviour
{
    // create an object from Singleton class within the Singleton class
    // allocate space on memory for Singleton instance
    public static Singleton instance;
    // Start is called before the first frame update

    private void Awake()
    {
        // create a static object instance when script loaded
        MakeSingleton();
    }

    void Start()
    {
        DisplayText();
    }

    // create singleton
    void MakeSingleton()
    {
        // if Singleton object exists
        if (instance != null)
        {
            Destroy(gameObject);
        }
        // if no Singleton instance created
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void DisplayText()
    {
        print("Excuted from function");
    }
}
