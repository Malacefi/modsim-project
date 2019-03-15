using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject spaceship;
	public Camera mainCamera;

	private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
    	spaceship = GameObject.Find("Spaceship");
        offset = transform.position - spaceship.transform.position;

        mainCamera = Camera.main;
        mainCamera.orthographicSize = 7.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate(){
    	transform.position = spaceship.transform.position + offset;
    }
}
