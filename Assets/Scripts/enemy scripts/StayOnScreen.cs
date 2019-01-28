using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayOnScreen : MonoBehaviour {

    [SerializeField]
    public float height = 3.6f;
    private float speed = 3.0f;

	void Start ()
    {
    }
	
	void Update ()
    {
        //just enter (y>=4.4), got health. moves slightly lower to y=3.6 and stays there. 
        if (this.transform.position.y >= height)
        {
            transform.Translate(0, -1.0f * speed * Time.deltaTime, 0);
        }
        //transform.position = Vector2.MoveTowards(this.transform.position, new Vector2(this.transform.position.x, height), Time.deltaTime * speed);
	}
}
