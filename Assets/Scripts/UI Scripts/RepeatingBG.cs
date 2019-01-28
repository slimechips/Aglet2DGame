using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour {

    private BoxCollider2D bgCollider;
    private float bgVerticalLength;
    public GameObject otherBG;
    private float offset;

    [SerializeField]
    public float multiplier = 1.5f;

    [SerializeField]
    public float extraOffset = 2.0f;

	void Start ()
    {
        bgCollider = GetComponent<BoxCollider2D>();
        bgVerticalLength = bgCollider.size.y;
	}
	
	void FixedUpdate ()
    {
		if (transform.position.y <= -0.5f * bgVerticalLength)
        {
            repositionBG();
        }
	}

    private void repositionBG()
    {
        offset = otherBG.transform.position.y + multiplier *bgVerticalLength;
        Vector2 move = new Vector2(0, offset - extraOffset);
        transform.position = (Vector2)transform.position + move;
        /*
        Vector2 bgOffset = new Vector2(0, multiplier * bgVerticalLength);
        transform.position = (Vector2)transform.position + bgOffset;
        */
    }

}
