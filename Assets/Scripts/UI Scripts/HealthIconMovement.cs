using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIconMovement : MonoBehaviour {

    private float healthIconSpeed = 10f;
    public Vector3 directionalVector = new Vector3();
    public Vector3 target = new Vector3();

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
		if ((this.transform.position - this.target).magnitude >= 0.2)
        {
            this.transform.Translate(directionalVector * healthIconSpeed * Time.deltaTime);

        }
        else
        {
            this.transform.position = target;
            this.enabled = false;
        }
    }
}
