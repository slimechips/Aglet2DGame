using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedPowerUp : MonoBehaviour {

    [SerializeField]
    private float speed = 5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, -1 * speed * Time.deltaTime, 0);
        if(this.transform.position.y <= Spawner.current.bottomenemyspawnzone)
        {
            Destroy(this.gameObject);
        }
    }
    //Checks for collision of power up with player, destroys when condition fufilled
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerBehavior player = collision.GetComponent<playerBehavior>();

        if (player != null)
        {
            player.playerBuffType = "speed";  //Changes active buff to speed
            player.playerBuffTime = Time.time;    //Records  buff time
            player.IncreaseSpeed();   //Function to increase speed
            UIMaster.current.speedicon.SetActive(true); // Activates speed timer
            playerPowerUpSlot.current.SpeedBuff();  //Changes visual powerup slot around player to speed
            Destroy(this.gameObject);        
        }
    }
}
