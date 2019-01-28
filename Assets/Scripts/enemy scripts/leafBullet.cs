using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leafBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0, -6f * Time.deltaTime, 0, Space.Self);
    }
}
