using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurtleMovement : MonoBehaviour
{

    // Use this for initialization
    [SerializeField]
    private float enterSpeed = 5f;
    private float rotationSpeed = 40f;
    private float hoverSpeed = 3f;
    private float directionChangeCd = 10f;
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

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float y_value = Random.Range(-2, 3);
        if (this.transform.position.y >= y_value && enter == false)
        {
            this.transform.Translate(0, -enterSpeed * Time.deltaTime, 0);
        }
        else
        {
            this.transform.Rotate(0, 0, rotationSpeed * rotationDirection * Time.deltaTime);
            enter = true;
            if (Time.time - timeOfLastDirectionChange >= directionChangeCd)
            {
                rotationDirection *= -1;
                timeOfLastDirectionChange = Time.time;
                directionChangeCd = Random.Range(5, 15);
            }
        }
    }
}
