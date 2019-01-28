using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootShoe : MonoBehaviour {

    public GameObject shoe;
    [SerializeField]
    private float spawnInterval = 1.8f;
    private float timeSinceLastSpawn;

	void Start ()
    {
        timeSinceLastSpawn = Time.time;
	}

    void Update()
    {
        if (this.transform.position.y <= GameObject.Find("Bounding Box").GetComponent<boundingBox>().yupperlimit)
        {
            if (Time.time - timeSinceLastSpawn > spawnInterval)
            {
                Instantiate(shoe, this.transform.position, this.transform.rotation);
                timeSinceLastSpawn = Time.time;
            }

        }
    }
}
