using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileDamage : MonoBehaviour {


	void Start ()
    {

	}
	
	void Update ()
    {
        if (Spawner.CheckSpawningBox(this.gameObject) == false)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LayerMask layertype = collision.gameObject.layer;

        if (layertype == LayerMask.NameToLayer("Player")) 
        {
            playerBehavior.current.Health(-1);
            Destroy(this.gameObject);
        }
    }
}
