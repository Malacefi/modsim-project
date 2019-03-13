using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject spaceship;
	private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - spaceship.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate(){
    	transform.position = spaceship.transform.position + offset;
    }
}
