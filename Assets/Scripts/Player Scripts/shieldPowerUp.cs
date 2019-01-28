using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldPowerUp : MonoBehaviour {

    [SerializeField]
    private float speed = 5f;

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
        playerBehavior player = collision.GetComponent<playerBehavior>();
        //Shield Power-up
        if (player != null)
        {
            player.playerBuffType = "shield"; //Changes active buff to shield
            player.playerBuffTime = Time.time;    //Records buff time
            player.ShieldUp();    //Function to shield up
            UIMaster.current.shieldicon.SetActive(true);    //Activate shield timer, need to add shield hit count also
            playerPowerUpSlot.current.ShieldBuff();     //Changes visual powerup slot
            Destroy(this.gameObject);
        }
    }
}
