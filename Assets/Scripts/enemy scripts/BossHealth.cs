using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour {

    public float bossHealth;

	void Start ()
    {

    }

    void Update ()
    {
		if(bossHealth <= 0.0f)
        {
            Destroy(this.gameObject);
        }
	}
}
//255,72,0