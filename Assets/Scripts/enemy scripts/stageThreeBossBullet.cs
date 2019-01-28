using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stageThreeBossBullet : MonoBehaviour {

    private float moveSpeed = 5.0f;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.Translate(0, -1 * moveSpeed * Time.deltaTime, 0);
        
	}
}
