using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundingBox : MonoBehaviour {
    [SerializeField]
    public float xupperlimit = 8.5f;
    public float xlowerlimit = -8.5f;
    public float yupperlimit = 7.3f;
    public float ylowerlimit = -7.3f;

    public static boundingBox current;

        //spawn(top/btm/left/right, displacement coord, time)

	// Use this for initialization
	void Awake() {
        boundingBox.current = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static bool CheckBoundingBox (GameObject gobject)
    {
        if ((gobject.transform.position.y > boundingBox.current.yupperlimit)
                || (gobject.transform.position.y < boundingBox.current.ylowerlimit)
                || (gobject.transform.position.x > boundingBox.current.xupperlimit)
                || (gobject.transform.position.x < boundingBox.current.xlowerlimit))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public static bool CheckBoundingBoxExpanded (GameObject gobject)
    {
        if ((gobject.transform.position.y > boundingBox.current.yupperlimit + 1.0f)
                || (gobject.transform.position.y < boundingBox.current.ylowerlimit - 1.0f)
                || (gobject.transform.position.x > boundingBox.current.xupperlimit + 1.0f)
                || (gobject.transform.position.x < boundingBox.current.xlowerlimit - 1.0f))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

}
