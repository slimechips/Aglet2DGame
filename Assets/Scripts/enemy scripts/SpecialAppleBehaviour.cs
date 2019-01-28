using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAppleBehaviour : MonoBehaviour
{

    //for (int i=0;i<2;i++) { };
    private float speed = 0.7f;
    private bool moving;
    private double y_stay = 5.79;
    public float health = 100;

    public MonoBehaviour enemyScript;
    [SerializeField]
    private bool enableobject = true;

    private void Awake()
    {
        this.gameObject.SetActive(enableobject);
    }

    // Use this for initialization
    void Start()
    {

        //enemyScript.enabled = false;
        moving = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving == true)
        {
            transform.Translate(0, -1.0f * speed * Time.deltaTime, 0);
        }

        //onvisible
        if (transform.position.y <= GameObject.Find("Bounding Box").GetComponent<boundingBox>().yupperlimit)
        {
            enemyScript.enabled = true;
            moving = false;
        }

        if (this.transform.position.y < GameObject.Find("Bounding Box").GetComponent<boundingBox>().ylowerlimit)
        {
            Destroy(this.gameObject);
        }
        if (health <= 0)
        {
            var score = (GameObject)GameObject.Find("Text");
            score.GetComponent<PlayerScore>().update_score(100);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            playerBehavior.current.Health(-1);
            Destroy(this.gameObject);
        }
    }


}