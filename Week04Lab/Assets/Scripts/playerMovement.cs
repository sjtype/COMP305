using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax;
}

public class playerMovement : MonoBehaviour {

    //public float is now available in unity
    public float speed;
    public Boundary boundary;

    private Rigidbody2D rBody;

    // Use this for initialization
    void Start()
    {
        //cached to save this -> establish connection to RigidBody2D
        rBody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Use this for physics
    void FixedUpdate()
    {
        float horizMove = Input.GetAxis("Horizontal");

        //to move character along 2 axis
        Vector3 movement = new Vector3(horizMove, 0, 0);

        //to alter speed of movement
        rBody.velocity = movement * speed;
        rBody.position = new Vector3(Mathf.Clamp(rBody.position.x, boundary.xMin, boundary.xMax), 0, 0);
    }
}
