using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVelocity : MonoBehaviour
{
    private Vector3 velocityVector;
    private Rigidbody rigidbody3D; 

    private void Awake()
    {
        rigidbody3D = GetComponent<Rigidbody>(); 
    }

    public void SetVelocity(Vector3 velocityVector)
    {
        this.velocityVector = velocityVector;
    }

    private void FixedUpdate()
    {
        rigidbody3D.velocity = velocityVector;
    }
}
