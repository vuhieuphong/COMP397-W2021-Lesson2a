using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame - once every 16.6666ms
    // 1000ms for each second
    // approximately update 60 times per second = 60fps
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal")>0)
        {
            //move right
            rigidBody.AddForce(Vector3.right*movementForce);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //move left
            rigidBody.AddForce(Vector3.left * movementForce);
        }
    }
}
