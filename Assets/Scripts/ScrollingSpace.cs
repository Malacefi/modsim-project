using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingSpace : MonoBehaviour
{
	private GameObject spaceship;
    // Start is called before the first frame update
    void Start()
    {
    	spaceship = GameObject.Find("Spaceship");
    }

    // Update is called once per frame
    void Update()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        Material mat = meshRenderer.material;

        Vector2 offset = mat.mainTextureOffset;

        offset.x = transform.position.x / transform.localScale.x;
        offset.y = transform.position.y / transform.localScale.y;

        mat.mainTextureOffset = offset;
    }
}
