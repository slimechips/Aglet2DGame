using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour {

    public static UIHealthBar current;
    private List<GameObject> healthlist = new List<GameObject>();   //Instantiate list for containing all health icons
    [SerializeField]
    private float iconwidth = 0.5f;
    private Vector3 repeat; //Vector for width
    private bool shakeScreen = false;

    float timer;

    void Awake()
    {
        //CURRENT
        UIHealthBar.current = this;
    }

    private void Start()
    {
        //sets vector for the width
        this.repeat = new Vector3(iconwidth, 0, 0);
        //Instantiate First icon
        GameObject newicon = Instantiate(UIMaster.current.healthicon, this.transform.position, this.transform.rotation);
        healthlist.Add(newicon);
        //Set first icon to child of ui
        newicon.transform.SetParent(this.gameObject.transform);

        //Loop to instantiate the other health icons
        for (int i = 1; i < playerBehavior.current.currentLife; i++)
        {
            newicon = Instantiate(UIMaster.current.healthicon, (this.healthlist[i - 1].transform.position + this.repeat), this.transform.rotation);
            healthlist.Add(newicon);
            newicon.transform.SetParent(this.gameObject.transform);
        }
    }
    //Function called from playerBehavior script, when health changes
    public void UpdateHealthBar(int healthupdate)
    {
        if (healthupdate < 0 && healthlist.Count > 0)   //When player loses health
        {
            timer = Time.time;
            //Destroy right most health icon
            Destroy(this.healthlist[this.healthlist.Count - 1]);
            healthlist.RemoveAt(healthlist.Count - 1);
            shakeScreen = true;

        }
        else if (healthupdate > 0)    //When player gains health
        {
            //Add icon to the right
            for (int i = 0; i < healthupdate; i++)
            {
                GameObject newicon = Instantiate(UIMaster.current.healthicon, (this.healthlist[healthlist.Count - 1].transform.position + this.repeat), this.transform.rotation);
                healthlist.Add(newicon);
                newicon.transform.SetParent(this.gameObject.transform);
            }
        }
    }

    public void UpdateHealthBar(int healthupdate, Vector3 healthOrigin)
    {
        if (healthupdate > 0)    //When player gains health
        {
            //Add icon to the right
            for (int i = 0; i < healthupdate; i++)
            {
                GameObject newicon = Instantiate(UIMaster.current.healthicon, healthOrigin + new Vector3(0.3f*i, 0, 0), this.transform.rotation);
                newicon.GetComponent<HealthIconMovement>().enabled = true;
                newicon.GetComponent<HealthIconMovement>().target = this.healthlist[this.healthlist.Count - 1].transform.position + this.repeat;
                newicon.GetComponent<HealthIconMovement>().directionalVector = ((newicon.GetComponent<HealthIconMovement>().target) - newicon.transform.position).normalized;
                healthlist.Add(newicon);
                newicon.transform.SetParent(this.gameObject.transform);
            }
        }
    }


    private void Update()
    {
        if (shakeScreen == true)
        {
            if (0.2f > Time.time - timer)
            {
                UIMaster.current.redpulse.GetComponent<Image>().color = new Color32(255, 0, 0, 120);
            } else if (Time.time - timer >= 0.2f)
            {
                UIMaster.current.redpulse.GetComponent<Image>().color = new Color32(255, 0, 0, 0);
                shakeScreen = false;
            }

        }

    }
}
