using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StageOneBossHealthBar : MonoBehaviour
{

    public Image healthBar;
    private Vector3 scale;
    private bool start = false;
    private GameObject bossone;
//    private float createdtime = 0;
    private void Awake()
    {
        bossone = GameObject.Find("StageOneBoss(Clone)");
    }
    
    void Start()
    {
        this.transform.SetParent(UIMaster.current.transform);
    }

    void Update()
    {
        {
            if (bossone == null)
            {
                Destroy(gameObject);
            }
            else
            {
                Vector3 scale = new Vector3(bossone.GetComponent<EnemyProperties>().health / 600f, 1, 1);
                this.healthBar.transform.localScale = scale;
            }
        }
    }
}
