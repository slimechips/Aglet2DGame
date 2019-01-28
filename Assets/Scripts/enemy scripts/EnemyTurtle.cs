using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurtle : MonoBehaviour {

    public GameObject laser1;
    public GameObject laser2;
    public GameObject laser3;
    public GameObject laser4;
    private float turtleHealth = 150.0f;

    // Use this for initialization
    void Start () {
        this.GetComponent<EnemyProperties>().health = turtleHealth;
    }
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.GetComponent<EnemyProperties>().health <= 149f)
        {
            laser1.SetActive(true);
            laser2.SetActive(true);
            laser3.SetActive(true);
            laser4.SetActive(true);
            this.enabled = false;

        }
    }
}
