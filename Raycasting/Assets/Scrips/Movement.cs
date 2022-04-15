using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private int movementSpeed;
    private Rigidbody body;
    private bool left;
    private bool right;
    private bool up;
    private bool down;


    // Update is called once per frame

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        left = false;
        right = false;
        up = false;
        down = false;

    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            left = true;
        }
        else
        {
            left = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            right = true;
        }
        else
        {
            right = false;
        }

        if (Input.GetKey(KeyCode.W))
        {
            up = true;
        }
        else
        {
            up = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            down = true;
        }
        else
        {
            down = false;
        }

     
    }

    private void FixedUpdate()
    {
        if (left)
        {
            body.AddForce(new Vector3(-movementSpeed, 0, 0));

        }

        if (right)
        {
            body.AddForce(new Vector3(movementSpeed, 0, 0));

        }

        if (up)
        {
            body.AddForce(new Vector3(0, 0, movementSpeed));

        }

        if (down)
        {
            body.AddForce(new Vector3(0, 0, -movementSpeed));

        }

        
    }
}
