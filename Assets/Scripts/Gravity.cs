using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Rigidbody body;
    public int affectRadius = 200;
    public float gravityStrength = 9.82f;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frames
    void Update()
    {
        foreach(Collider collider in Physics.OverlapSphere(transform.position, affectRadius))
        {
            //direction of the force
            Vector3 force = transform.position-collider.transform.position;

            //distance between the objects
            float objectDistance = Vector3.Distance(collider.transform.position, transform.position);

            //apply the force
            collider.attachedRigidbody.AddForce(force.normalized * gravityStrength / objectDistance);
        }
    }
}
