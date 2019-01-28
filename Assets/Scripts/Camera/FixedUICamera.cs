using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUICamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Camera uicamera = this.GetComponent<Camera>();
        uicamera.pixelRect = new Rect(0, 0, 1222, 949);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
