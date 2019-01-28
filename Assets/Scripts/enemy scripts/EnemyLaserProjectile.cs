using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserProjectile : MonoBehaviour
{
    // Use this for initialization
    private void Awake()
    {
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            collider.gameObject.GetComponent<playerBehavior>().Health(-1);
        }
    }
}
