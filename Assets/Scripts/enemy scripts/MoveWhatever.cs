using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWhatever : MonoBehaviour {

    private float movementSpeed = 4.0f;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.position += transform.up * movementSpeed * Time.deltaTime * -1;
    }
}
