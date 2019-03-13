using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{

	private Rigidbody body;
    private float rotation;

    // Start is called before the first frame update
    void Start()
    {
    	body = GetComponent<Rigidbody>();
    }

    // Physics update
    void FixedUpdate(){
    	float moveHorizontal = Input.GetAxis("Horizontal");
    	float moveVertical = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3(0, moveVertical, 0);//(0, moveVertical);

        float movementSpeed = -5;

        Vector2 movement = transform.forward * moveVertical * movementSpeed;

        if(moveHorizontal>0)
        {
            rotation -= (float)0.02;
        }
        if(moveHorizontal<0)
        {
            rotation += (float)0.02;
        }
        transform.Rotate(0, 0, rotation, Space.Self);
        /*
        if (moveHorizontal>0)
        {
            transform.Rotate(0, 0, 1, Space.Self);
        }
        if(moveHorizontal<0)
        {
            transform.Rotate(0, 0, -1, Space.Self);
        }*/
        //transform.Rotate(0, 0, 1, Space.Self);



    	body.AddForce(movement);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
