using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHairball : MonoBehaviour {

    private float hairballHealth = 150.0f;
    private float movingSpeed = 2.0f;

	void Start ()
    {
        this.GetComponent<EnemyProperties>().health = hairballHealth;
	}
	
	void Update ()
    {
        this.transform.Translate(0, Time.deltaTime * movingSpeed, 0);
        if (Spawner.CheckSpawningBox(this.gameObject) == false)
        {
            Destroy(gameObject);
        }
    }
}
