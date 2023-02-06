using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        LoadNewScene();
        

        PropellerRotation.Instance.rAngle += 50;
    }

    void LoadNewScene()
    {
        SceneManager.LoadScene("Scene1");
    }
}
