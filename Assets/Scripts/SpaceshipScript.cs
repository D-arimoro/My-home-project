using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpaceshipScript : MonoBehaviour
{
    public KeyCode left;
    public KeyCode right;
    private KeyCode boost = KeyCode.LeftShift;
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;
    public ParticleSystem myPart;
    public Rigidbody2D myRigid;
    private float movementX = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myPart = GameObject.Find("EngineBoost").GetComponent<ParticleSystem>();
        myRigid = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        movementX = 0f;

        if (Input.GetKey(left))
        {
            movementX = -1f;
        }

        if (Input.GetKey(right))
        {
            movementX = 1f;
        }

    }
    void FixedUpdate()
    {
        myRigid.linearVelocity = new Vector2(movementX * moveSpeed, myRigid.linearVelocity.y);

        if(Input.GetKey(boost))
        {
            if (!myPart.isEmitting)
                myPart.Play();
        }
        else
        {
            if (myPart.isEmitting)
            {
                myPart.Stop();
            }
        }
    }
}