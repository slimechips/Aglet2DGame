using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageThreeBossHealthBar : MonoBehaviour {

    public Image healthBar;
    private Vector3 scale;
    private bool start = false;
    private GameObject bossThree;
    //    private float createdtime = 0;
    private void Awake()
    {
        bossThree = GameObject.Find("Stage Three Boss(Clone)");
    }

    void Start()
    {
        this.transform.SetParent(UIMaster.current.transform);
    }

    void Update()
    {

        if (bossThree == null)
        {
            Destroy(gameObject);
        }
        else
        {
            Vector3 scale = new Vector3(bossThree.GetComponent<EnemyProperties>().health / 1200f, 1, 1);
            this.healthBar.transform.localScale = scale;
        }

    }
}
