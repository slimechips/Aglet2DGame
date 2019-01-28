using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyButterfly : MonoBehaviour {

    public float butterflySpeed = 5.0f;
    private float butterflyHealth = 20.0f;

	void Start ()
    {
        this.GetComponent<EnemyProperties>().health = butterflyHealth;
	}
	
	void Update ()
    {
	    if(this.transform.position.x < Spawner.current.leftenemyspawnzone)
        {
            butterflySpeed = 5.0f;
        }
        if(this.transform.position.x > Spawner.current.rightenemyspawnzone)
        {
            butterflySpeed = -5.0f;
        }
        this.transform.Translate(Time.deltaTime * butterflySpeed, 0, 0);
	}
}
