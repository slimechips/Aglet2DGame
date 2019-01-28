using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLaserShooter : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    private float enterSpeed = 5f;
    private float rotationSpeed = 50f;
    private float hoverSpeed = 3f;
    private float directionChangeCd = 6f;
    private float directionChangeTime = 1.5f;
    private float timeOfLastDirectionChange;
    private float rotationDirection;
    private bool enter = false;

    private void Awake()
    {
        timeOfLastDirectionChange = Time.time;
        rotationDirection = Random.Range(0, 2);
        Debug.Log(rotationDirection);
        if (rotationDirection == 0)
        {
            rotationDirection--;
        }
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.y >= 0 && enter == false)
        {
            this.transform.Translate(0, -enterSpeed * Time.deltaTime, 0);
        }
        else
        {
            enter = true;
            if (Time.time - timeOfLastDirectionChange >= directionChangeCd)
            {
                rotationDirection *= -1;
                timeOfLastDirectionChange = Time.time;
                directionChangeTime = 1.5f;
            }
            else if (boundingBox.CheckBoundingBox(this.gameObject) == false)
            {
                this.transform.Translate(0, 0.01f, 0);
                rotationDirection *= -1;
                timeOfLastDirectionChange = Time.time;
                directionChangeTime = Random.Range(3.0f, 4.5f);
            } else if(Time.time - timeOfLastDirectionChange <= directionChangeTime)
            {
                this.transform.Rotate(0, 0, rotationSpeed * rotationDirection * Time.deltaTime);
            } else
            {
                this.transform.Rotate(0, 0, rotationSpeed * rotationDirection * Time.deltaTime);
                this.transform.Translate(0, -hoverSpeed * Time.deltaTime, 0);
            }
        }
	}
}
