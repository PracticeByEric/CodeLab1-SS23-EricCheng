using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sender : MonoBehaviour
{
    // Start is called before the first frame update

    /*
    private Singleton sin;
    private Singleton sin_2;*/
    void Start()
    {
        // get component from another game object
        /*sin = GameObject.Find("Singleton").GetComponent<Singleton>();
        sin_2 = GameObject.Find("Singleton").GetComponent<Singleton>();
        
        sin.DisplayText();
        sin_2.DisplayText();*/
        
        // create static instance to replace code above
        // easily access singleton object
        // Singleton.instance.DisplayText();
        
        // invoke LoadNewScene function after 3 seconds
        Invoke("LoadNewScene", 3f);
    }

    void LoadNewScene()
    {
        SceneManager.LoadScene("Scene1");
    }

}
