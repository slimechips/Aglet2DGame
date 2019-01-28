using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySnek : MonoBehaviour {

    private float timeSinceSpawn;
    [SerializeField]
    private float snekSpeed = 8f;

	// Use this for initialization
	void Start ()
    {
        timeSinceSpawn = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //transform.position += transform.forward * Time.deltaTime * 1.0f;
        transform.Translate(0, -snekSpeed * Time.deltaTime, 0, Space.Self);
        if(Time.time - timeSinceSpawn > 8.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
