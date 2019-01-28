using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

    [SerializeField]
    private float speed = 8.0f;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transform.Translate(0, 1 * speed * Time.deltaTime, 0);
        if (Spawner.CheckSpawningBox(this.gameObject) == false)
        {
            Destroy(this.gameObject);
        }
    }
}
