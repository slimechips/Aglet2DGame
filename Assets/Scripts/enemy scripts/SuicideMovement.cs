using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuicideMovement : MonoBehaviour {

    private float rotationSpeed = 90f;
    private float movementSpeed = 3.0f;

	void Start ()
    {
    }
	
	void Update ()
    {
        Vector3 distToPlayer = this.transform.position - GameObject.Find("Player").transform.position;
        float angleToPlayer = Mathf.Rad2Deg * Mathf.Atan2(distToPlayer.y, distToPlayer.x);

        Vector3 angle = this.transform.localEulerAngles;
        angle.z = Mathf.MoveTowardsAngle(angle.z, angleToPlayer, this.rotationSpeed * Time.deltaTime);
        this.transform.localEulerAngles = angle;

        transform.position = Vector3.MoveTowards(this.transform.position, GameObject.Find("Player").transform.position, Time.deltaTime * movementSpeed);

        if(Spawner.CheckSpawningBox(this.gameObject) == false)
        {
            Destroy(this.gameObject);
        }
    }
}
