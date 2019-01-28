using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField]
    public float health = 100;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0)
        {
            Destroy(this.gameObject);
            var score = (GameObject)GameObject.Find("Text");
            score.GetComponent<PlayerScore>().update_score(100);
        }
	}
}
