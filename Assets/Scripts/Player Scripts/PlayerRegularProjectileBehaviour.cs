using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this to the player projectile
    public class PlayerRegularProjectileBehaviour : MonoBehaviour {

    [SerializeField]
    private float projectilespeed = 8.0f;
    public int damage = 10;
    private float projectilerange = 6.0f;

    AudioSource music;


    // Use this for initialization
    void Start()
    {
        music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(0, 1 * projectilespeed * Time.deltaTime, 0);
        if (boundingBox.CheckBoundingBox(this.gameObject) == false)
        {
            Destroy(this.gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.gameObject.layer == LayerMask.NameToLayer("Enemies"))
        {
            music.Play();
            if(collider.gameObject.tag == "enemy")
            {
                collider.gameObject.GetComponent<EnemyProperties>().health -= damage;
                Destroy(this.gameObject, 0.08f);

                if (collider.gameObject.name != "Hairball(Clone)" && collider.gameObject.name != "turtlelimb-inv" )
                {
                    collider.transform.Translate(0, 0.2f, 0, Space.World);
                }
            }
            if(collider.gameObject.tag == "boss")
            {
                collider.gameObject.GetComponent<EnemyProperties>().health -= damage;
                Destroy(this.gameObject, 0.08f);
            }
            if(collider.gameObject.tag == "special enemy")
            {
                collider.gameObject.GetComponent<EnemyProperties>().health -= damage;
                Destroy(this.gameObject, 0.08f);
            }
            if (collider.gameObject.tag == "final boss")
            {
                if(GameObject.Find("Boss").GetComponent<BossSkill>().vulnerable == true)
                {
                    collider.gameObject.GetComponent<EnemyProperties>().health -= damage;
                    Destroy(this.gameObject, 0.08f);
                }
                else
                {
                    Destroy(this.gameObject, 0.08f);
                }
            }
        }
    }
        

}
