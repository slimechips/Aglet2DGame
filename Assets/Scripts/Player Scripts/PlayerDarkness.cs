using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDarkness : MonoBehaviour {

    private bool transparency;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        transparency = GameObject.Find("Boss").GetComponent<BossSkill>().state;
		if(transparency == true)
        {
            GameObject.FindGameObjectWithTag("darkness").GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        }
        else
        {
            GameObject.FindGameObjectWithTag("darkness").GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0f);
        }
    }
}
