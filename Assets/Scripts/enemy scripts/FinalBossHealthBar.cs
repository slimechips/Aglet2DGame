using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FinalBossHealthBar : MonoBehaviour {

    public Image healthBar;
    private Vector3 scale;
    private bool start = false;
    private GameObject finalBoss;
    //    private float createdtime = 0;

    private void Awake()
    {
        finalBoss = GameObject.Find("Boss");
    }

    void Start()
    {
        this.transform.SetParent(UIMaster.current.transform);
    }

    void Update()
    {

        if (finalBoss == null)
        {
            Destroy(gameObject);
        }
        else
        {
            Vector3 scale = new Vector3(finalBoss.GetComponent<EnemyProperties>().health / 1500f, 1, 1);
            this.healthBar.transform.localScale = scale;
        }

    }
}
