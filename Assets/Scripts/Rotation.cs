using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float Speed = 5f;

	
	// Update is called once per frame
	void Update ()
    {
        float inputH = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, inputH * Speed, 0));

	}
}
