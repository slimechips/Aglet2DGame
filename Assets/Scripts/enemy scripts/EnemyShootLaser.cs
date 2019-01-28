using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootLaser : MonoBehaviour {

    [SerializeField]
    private GameObject laser;
    [SerializeField]
    private Sprite angryKoala;
    // Use this for initialization
    private void Awake()
    {

    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (this.gameObject.GetComponent<EnemyProperties>().health <= 60f)
        {
            laser.SetActive(true);
            this.gameObject.GetComponent<SpriteRenderer>().sprite = angryKoala;
            this.enabled = false;
        }
	}
}
