using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private SphereCollider ownCollider;
    private float radius;

    public int affectRadius = 1000;
    //change gravityStrength for different sized planetoids on a case-by-case basis
    public float gravityStrength = 10f;
    

    private void Start()
    {
        ownCollider = GetComponent<SphereCollider>();
        radius = ownCollider.radius;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        CapsuleCollider collider = player.GetComponent<CapsuleCollider>();

        //direction of the force
        Vector3 force = transform.position - collider.transform.position;

        //distance between the objects
        float objectDistance = Vector3.Distance(collider.transform.position, transform.position);

        //apply the force
        collider.attachedRigidbody.AddForce(force.normalized * Mathf.Abs((gravityStrength * 0.1f) / (objectDistance - radius)));

        /*
        foreach(Collider collider in Physics.OverlapSphere(transform.position, affectRadius))
        {
            //direction of the force
            Vector3 force = transform.position - collider.transform.position;

            //distance between the objects
            float objectDistance = Vector3.Distance(collider.transform.position, transform.position);

            //apply the force
            collider.attachedRigidbody.AddForce(force.normalized * (gravityStrength * 0.1f) / (objectDistance - radius));
        }*/
    }
}
