using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public int affectRadius = 200;
    //change gravityStrength for different sized planetoids on a case-by-case basis
    public float gravityStrength = 10f;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Collider collider in Physics.OverlapSphere(transform.position, affectRadius))
        {
            //direction of the force
            Vector3 force = transform.position - collider.transform.position;

            //distance between the objects
            float objectDistance = Vector3.Distance(collider.transform.position, transform.position);

            //apply the force
            collider.attachedRigidbody.AddForce(force.normalized * (gravityStrength*0.1f) / objectDistance);
        }
    }
}
