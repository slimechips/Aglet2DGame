using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIProjectileIcon : MonoBehaviour {

    [SerializeField]
    private Image progress;
    [SerializeField]
    private string projectileBuffName;
    // Use this for initialization
    void Awake()
    {
        progress.color = new Color32(255, 120, 120, 120);
    }

    // Update is called once per frame
    void Update()
    {
        playerShootingBehavior shooter = playerShootingBehavior.current;
        //Checking for shield buff
        if (shooter.projectileBuffType == projectileBuffName)
        {
            progress.fillAmount = 1f - (Time.time - shooter.projectileBuffTime) / shooter.maxProjectileBuffTimer;
            //Check if Buff time is over
            if (Time.time - shooter.projectileBuffTime >= shooter.maxProjectileBuffTimer)
            {
                shooter.projectileBuffType = "none";
            }
        }
        else
        {
            this.gameObject.SetActive(false);  
            if (shooter.projectileBuffType == "none")
            {
                shooter.NoProjectileBuff();
            }
        }
    }


}
