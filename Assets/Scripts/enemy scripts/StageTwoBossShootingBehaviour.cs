using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTwoBossShootingBehaviour : MonoBehaviour {

    public bool wideShot = false;
    public float shootInterval = 2.0f;
    private float timeSinceLastShot;

    [SerializeField]
    public GameObject Bullet;


    void Start ()
    {
        timeSinceLastShot = Time.time;
	}
	
	void Update ()
    {
        shoot(Time.time, wideShot);
	}

    private void shoot(float time, bool state)
    {
        if(state == false) //shoot 1 only
        {
            if(time - timeSinceLastShot > shootInterval)
            {
                Instantiate(Bullet, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, 0));
                timeSinceLastShot = Time.time;
            }
        }
        if(state == true) //shoot 5 bullet
        {
            if (time - timeSinceLastShot > shootInterval)
            {
                Instantiate(Bullet, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, -30));
                Instantiate(Bullet, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, -60));
                Instantiate(Bullet, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, 0));
                Instantiate(Bullet, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, 30));
                Instantiate(Bullet, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, 60));
                timeSinceLastShot = Time.time;
            }
        }
    }
}
