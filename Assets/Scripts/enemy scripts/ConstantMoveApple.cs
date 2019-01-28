using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMoveApple : MonoBehaviour {

    private float moveSpeed = 3.0f;

	void Start ()
    {
	}
	
	void Update ()
    {
        transform.Translate(0, -1 * Time.deltaTime * moveSpeed, 0);

        if (Spawner.CheckSpawningBox(this.gameObject) == false)
        {
            Destroy(gameObject);
        }

    }
}
