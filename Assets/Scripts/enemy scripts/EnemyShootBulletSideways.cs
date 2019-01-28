using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyShootBulletSideways : MonoBehaviour
{

    //public GameObject Enemy;
    public GameObject Bullet;
    public float BulletSpeed = 300f;
    public float timeBetweenBullets = 1.0f;

    private DateTime interval;
    private DateTime wait;

    // Use this for initialization
    void Start()
    {
        interval = DateTime.Now.AddSeconds(timeBetweenBullets);

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y >= GameObject.Find("Bounding Box").GetComponent<boundingBox>().ylowerlimit)
        {
            if (DateTime.Now >= interval)

            {
                GameObject TempBullet;
                TempBullet = Instantiate(Bullet, this.transform.position, this.transform.rotation) as GameObject;

                Rigidbody2D TempRigidbody;
                TempRigidbody = TempBullet.GetComponent<Rigidbody2D>();

                TempRigidbody.AddForce(-transform.right * BulletSpeed);
                TempRigidbody.AddForce(transform.up * 85);
                //self destruct code in EnemyProjectileDamage (attached to projectile)

                TempBullet = Instantiate(Bullet, this.transform.position, this.transform.rotation) as GameObject;
                TempRigidbody = TempBullet.GetComponent<Rigidbody2D>();
                TempRigidbody.AddForce(transform.right * BulletSpeed);
                TempRigidbody.AddForce(transform.up * 85);

                interval = DateTime.Now.AddSeconds(timeBetweenBullets);
            }

        }

    }

}

