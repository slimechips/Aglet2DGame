using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCamera : MonoBehaviour {

	// Use this for initialization
	void Awake () {
        Camera maincamera = this.GetComponent<Camera>();
        maincamera.pixelRect = new Rect(0, 0, 1400, 1400);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
