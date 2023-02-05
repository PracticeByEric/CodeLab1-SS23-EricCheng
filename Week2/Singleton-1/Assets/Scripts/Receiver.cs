using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // The Singleton instance is passed to scene1
        // Receiver able to call the function native to instance object
        Singleton.instance.DisplayText();
    }
}
