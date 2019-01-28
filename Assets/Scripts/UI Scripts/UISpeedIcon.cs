using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UISpeedIcon : MonoBehaviour {

    [SerializeField]
    private Image progress;

    // Use this for initialization  
    void Awake () {
        progress.color = new Color32(255, 255, 255, 120);
	}
	
	// Update is called once per frame
	void Update () {
        playerBehavior player = playerBehavior.current;
        //Checking for speed buff
        if (player.playerBuffType == "speed")
        {
            progress.fillAmount = 1f - (Time.time - player.playerBuffTime) / player.maxPlayerBuffTimer;
            //Check if Buff time is over
            if (Time.time - player.playerBuffTime >= player.maxPlayerBuffTimer)
            {
                player.ReturnSpeed();
                //Deactivate speed buff when time is up
                player.playerBuffType = "none";
                playerPowerUpSlot.current.NoBuff(); //Empty power-up slot
            }
        } else {
            //If speed buff is inactive, disable speed icon
            player.ReturnSpeed();   //Function to change player speed back to normal
            UIMaster.current.speedicon.SetActive(false);    //Disable Speed UI icon
        }
    }
}
