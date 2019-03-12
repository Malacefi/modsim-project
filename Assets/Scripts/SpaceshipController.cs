using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{

	private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
    	body = GetComponent<Rigidbody2D>();
    }

    // Physics update
    void FixedUpdate(){
    	float moveHorizontal = Input.GetAxis("Horizontal");
    	float moveVertical = Input.GetAxis("Vertical");
    	Vector2 movement = new Vector2(moveHorizontal, moveVertical);
    	body.AddForce(movement);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
