using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShieldIcon : MonoBehaviour {

    [SerializeField]
    private Image progress;
    [SerializeField]
    private Text shieldsLeft;
    // Use this for initialization
    void Awake()
    {
        progress.color = new Color32(255, 255, 255, 120);
    }

    // Update is called once per frame
    void Update()
    {
        playerBehavior player = playerBehavior.current;
        shieldsLeft.text = player.shield.ToString();
        //Checking for shield buff
        if (player.playerBuffType == "shield")
        {
            progress.fillAmount = 1f - (Time.time - player.playerBuffTime) / player.maxPlayerBuffTimer;
            //Check if Buff time is over
            if (Time.time - player.playerBuffTime >= player.maxPlayerBuffTimer || player.shield == 0)
            {
                player.ShieldDown();
                //Deactivate speed buff when time is up
                player.playerBuffType = "none";
                playerPowerUpSlot.current.NoBuff(); //Empties powerup slot
            }
        }
        else
        {
            //If speed buff is inactive, disable speed icon
            player.ShieldDown();    //Function to remove shield
            UIMaster.current.shieldicon.SetActive(false);   //Function to remove UI Shield Icon
        }
    }
}
