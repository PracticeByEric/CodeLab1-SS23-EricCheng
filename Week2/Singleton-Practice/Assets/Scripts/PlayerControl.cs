using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D _rd2D;

    // set applied force amount
    [SerializeField] private int forceAmount = 2;
    // Start is called before the first frame update
    void Start()
    {
        // get RigidBody2D component from gameobject
        _rd2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rd2D.AddForce(Vector2.up * forceAmount);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _rd2D.AddForce(Vector2.down * forceAmount);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _rd2D.AddForce(Vector2.left * forceAmount);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rd2D.AddForce(Vector2.right * forceAmount);
        }
    }
        
}
