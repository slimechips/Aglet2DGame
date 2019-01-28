using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRedAppleForGolden : MonoBehaviour
{

    [SerializeField]
    public float speed = 1.0f;

    [SerializeField]
    private float strafecooldown = 1.8f;

    [SerializeField]
    private float strafedirection = 1.0f;

    private float timesincelaststrafe;

    // Use this for initialization
    void Start()
    {
        timesincelaststrafe = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x <= boundingBox.current.xlowerlimit)
        {
            strafedirection *= 1.0f;
        }
        else if (this.transform.position.x >= boundingBox.current.xupperlimit)
        {
            strafedirection *= -1.0f;
        }
        if (Time.time - timesincelaststrafe <= strafecooldown)
        {
            transform.Translate(1.0f * strafedirection * speed * Time.deltaTime, -1.0f * speed * Time.deltaTime, 0);
        }
        else
        {
            strafedirection *= -1.0f;
            timesincelaststrafe = Time.time;
        }

        if (this.transform.position.y <= Spawner.current.bottomenemyspawnzone)
        {
            Destroy(gameObject);
        }
    }
}
