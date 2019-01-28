using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastMoving : MonoBehaviour {

    public float batSpeed = 20.0f;

	void Start ()
    {
	}
	
	void Update ()
    {
        transform.Translate(0, -1 * Time.deltaTime * batSpeed, 0);

        if (this.transform.position.y <= Spawner.current.bottomenemyspawnzone)
        {
            Destroy(gameObject);
        }

    }
}
