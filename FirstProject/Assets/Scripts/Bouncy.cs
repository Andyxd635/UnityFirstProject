using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour
{
    public float bounceForce = 5f;
    public float gravity = -9.81f;

    private float verticalVelocity;
    void Start()
    {
        verticalVelocity = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalVelocity += gravity * Time.deltaTime;
      
        transform.position += new Vector3(0, verticalVelocity*Time.deltaTime, 0);

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            verticalVelocity = bounceForce;
        }
    }

}

