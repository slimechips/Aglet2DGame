using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupDrop : MonoBehaviour {

    private int goldenHealth = 50;
    public GameObject[] powerups;
    private float moveSpeed = 3.0f;

	void Start ()
    {
        this.GetComponent<EnemyProperties>().health = goldenHealth;
	}
	
	void Update ()
    {
        transform.Translate(0, -1 * Time.deltaTime * moveSpeed, 0);
        if (this.transform.position.y <= Spawner.current.bottomenemyspawnzone)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (this.GetComponent<EnemyProperties>().health <= 0)
        {
            Instantiate(powerups[Random.Range(0, 8)], this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
