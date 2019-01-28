using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpiky : MonoBehaviour {

    private float spikyHealth = 1000.0f;
    private float spikySpeed = 1.2f;
    [SerializeField]
    private float direction;
    private float ydirection;
    public GameObject spawned;
    private bool burst;

    // Use this for initialization

    private void Awake()
    {
        burst = false;
        ydirection = Random.Range(-1f, 1f) * Time.deltaTime;
    }
    void Start () {
        this.GetComponent<EnemyProperties>().health = spikyHealth;

    
}
	
	// Update is called once per frame
	void Update () {
        
        this.transform.Translate(spikySpeed*direction*Time.deltaTime, ydirection,0);

        if(Spawner.CheckSpawningBox(this.gameObject) == false)
        {
            Destroy(this.gameObject);
        }

        if (this.GetComponent<EnemyProperties>().health <= 980.0f)
        {
            burst = true;

        }
        if (burst == true)
        {
            Destroy(this.gameObject);

            for (int i = 1; i <= 18; i++)
            {
                GameObject TempSnek;
                TempSnek = Instantiate(spawned, this.transform.position, this.transform.rotation) as GameObject;
                TempSnek.transform.Rotate(Vector3.forward * 20 * i);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            burst = true;
        }
    }
}
