using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProperties : MonoBehaviour
{

    [SerializeField]
    public float health = 30;
    public int score = 100;

    [SerializeField]
    private bool resetScoreOnExit = false;
    public bool destroyoncontact = true;

    private bool playerCollided = false;

    private bool enteredScreen = false;


    private void Awake()
    {
        this.GetComponent<Rigidbody2D>().sleepMode = RigidbodySleepMode2D.NeverSleep;

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0 && score >= 0)
        {
            Destroy(this.gameObject);
            GameObject playerscore = (GameObject)GameObject.Find("Score Text");
            playerscore.GetComponent<PlayerScore>().update_score(score);
            ComboTracker.current.Combo(1);
        }
        if (resetScoreOnExit == true)
        {
            if (enteredScreen == false)
            {
                if (boundingBox.CheckBoundingBox(this.gameObject) == true)
                {
                    enteredScreen = true;
                }
            }
            else if (enteredScreen == true)
            {
                if (boundingBox.CheckBoundingBoxExpanded(this.gameObject) == false)
                {
                    ComboTracker.current.Combo("reset");
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            playerBehavior.current.Health(-1);
            if (destroyoncontact == true)
            {
                Destroy(this.gameObject);
            }
            else
            {
                collision.transform.Translate((collision.transform.position - this.transform.position).normalized * 0.75f);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            playerBehavior.current.Health(-1);
            if (destroyoncontact == true)
            {
                Destroy(this.gameObject);
            }
            else
            {
                collision.transform.Translate((collision.transform.position - this.transform.position).normalized * 0.75f);
            }
        }
    }

}
