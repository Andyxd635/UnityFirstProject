using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float rotationSpeed = 10f;
    public Vector3 rotationAxis = Vector3.up; // Rotirea pe axa Y 

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed);
    }
}
