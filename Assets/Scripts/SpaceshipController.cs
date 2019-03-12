using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{

	private Rigidbody2D body;
    private float rotation;

    // Start is called before the first frame update
    void Start()
    {
    	body = GetComponent<Rigidbody2D>();
    }

    // Physics update
    void FixedUpdate(){
    	float moveHorizontal = Input.GetAxis("Horizontal");
    	float moveVertical = Input.GetAxis("Vertical");
    	Vector2 movement = new Vector2(0, moveVertical);

        if(moveHorizontal>0)
        {
            rotation += (float)0.2;
        }
        if(moveHorizontal<0)
        {
            rotation -= (float)0.2;
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
