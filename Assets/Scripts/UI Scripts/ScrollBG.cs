using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScrollBG : MonoBehaviour {

    public float scrollSpeed = 3.0f;
    private Rigidbody2D rb2d;
    public static Camera bgcamera;

    private void Awake()
    {
        bgcamera = this.GetComponent<Camera>();
    }

    void Start ()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        rb2d.velocity = new Vector2(0, -1 * scrollSpeed);
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("enemy");
	}
}
