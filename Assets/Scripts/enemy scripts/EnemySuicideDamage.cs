using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySuicideDamage : MonoBehaviour {

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        playerBehavior player = collider.GetComponent<playerBehavior>();

        if (player != null)
        {
            player.Health(-1);
            this.GetComponent<EnemyProperties>().health -= 10;
        }
    }
}
