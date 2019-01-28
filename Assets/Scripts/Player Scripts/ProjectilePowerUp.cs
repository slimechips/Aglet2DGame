﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePowerUp : MonoBehaviour {

    [SerializeField]
    private float speed = 5f;
    public string bufftype;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1 * speed * Time.deltaTime, 0);
        if (this.transform.position.y <= Spawner.current.bottomenemyspawnzone)
        {
            Destroy(this.gameObject);
        }
    }
    //Checks for collision of power up with player, destroys when condition fufilled
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerShootingBehavior shooting = collision.GetComponent<playerShootingBehavior>();

        if (shooting != null)
        {
            if (Input.GetKey(KeyCode.Mouse0) == true) {
                shooting.keydown = true;
            }
            shooting.UpgradeProjectile(bufftype, Time.time);   //Function to increase speed
            UIMaster.current.projectileicondict[bufftype].SetActive(true); // Activates speed timer
            Destroy(this.gameObject);
        }
    }

}
