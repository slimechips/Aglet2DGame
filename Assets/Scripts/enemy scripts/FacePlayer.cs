using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour {

    private float rotationSpeed = 90.0f;


	void Start ()
    {
		
	}
	
	void Update ()
    {
        if(this.transform.position.y <= 3.6)
        {
            Vector3 distToPlayer = this.transform.position - GameObject.Find("Player").transform.position;
            float angleToPlayer = Mathf.Rad2Deg * Mathf.Atan2(distToPlayer.y, distToPlayer.x);
            Vector3 angle = this.transform.localEulerAngles;
            angle.z = Mathf.MoveTowardsAngle(angle.z, angleToPlayer - 90, this.rotationSpeed * Time.deltaTime);
            this.transform.localEulerAngles = angle;
        }
    }
}
