using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StageTwoBossHealthBar : MonoBehaviour
{

    public Image healthBar;
    private Vector3 scale;
    private bool start = false;
    private GameObject bosstwo;
    //    private float createdtime = 0;
    private void Awake()
    {
        bosstwo = GameObject.Find("Stage Two Boss(Clone)");
    }

    void Start()
    {
        this.transform.SetParent(UIMaster.current.transform);
    }

    void Update()
    {

        if (bosstwo == null)
        {
            Destroy(gameObject);
        }   
        else
        {
            Vector3 scale = new Vector3(bosstwo.GetComponent<EnemyProperties>().health / 1000f, 1, 1);
            this.healthBar.transform.localScale = scale;
        }

    }
}
