using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour {

    public Image healthBar;
    private Vector3 scale;

    void Start()
    {

    }

    void Update()
    {
        Vector3 scale = new Vector3(GameObject.Find("Boss").GetComponent<EnemyProperties>().health / 1000f, 1, 1);
        this.healthBar.transform.localScale = scale;
    }
}
