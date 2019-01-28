using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserProjectile : MonoBehaviour {

    [SerializeField]
    private float damage = 50f;

    // Use this for initialization
    private void Awake()
    {
    }

    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.parent.position = playerShootingBehavior.current.transform.position;
		if((Input.GetKeyUp(KeyCode.Mouse0) == true) || playerShootingBehavior.current.projectileBuffType != "laser")
        {
            Destroy(this.transform.parent.gameObject);
        }   
	}   

    private void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.layer == LayerMask.NameToLayer("Enemies"))
        {
            collider.gameObject.GetComponent<EnemyProperties>().health -= (damage * Time.deltaTime);
        }
    }
}
