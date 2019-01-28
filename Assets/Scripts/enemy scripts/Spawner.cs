using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    private class Container
    {
        public string enemytype;
        public string location;
        public float xdisplacement;
        public float ydisplacement;
        public float interval;
        public bool randompos = false;

        public Container(string etype, float xdisp, float ydisp, float interv)
        { 
            enemytype = etype;
            xdisplacement = xdisp;
            ydisplacement = ydisp;
            interval = interv;
        }
    }
    public static Spawner current;

    [SerializeField]
    public float topenemyspawnzone = 9.2f;
    public float bottomenemyspawnzone = -9.2f;
    public float rightenemyspawnzone = 12.0f;
    public float leftenemyspawnzone = -12.0f;

    private string enemy;

    [SerializeField]
    public GameObject[] enemyprefab;
    public string[] enemynames;
    private Dictionary<string, GameObject> dict = new Dictionary<string, GameObject>();
    private List <Container> queue = new List<Container>();
    private int totalQueue;

    private float lastspawnedtime;

    // Use this for initialization
    private void Awake()
    {
        Spawner.current = this;
        lastspawnedtime = 0f;
    }

    void Start () {	
        for (int i=0; i<enemyprefab.Length; i++)
        {
            dict.Add(enemynames[i], enemyprefab[i]);
        }
	}

    public float QueueScale ()
    {
        if (totalQueue == 0)
        {
            return 0;
        }
        else
        {
            return 1 - ((float)queue.Count / (float)totalQueue);
        }
    }

    public static void spawn(string enemytype, string location, float xdisplacement, float ydisplacement, float interval, bool randompos)
    {
        if (location == "top")
        {
            ydisplacement += Spawner.current.topenemyspawnzone;
            if (randompos == true)
            {
                xdisplacement = Random.Range(boundingBox.current.xlowerlimit, boundingBox.current.xupperlimit);
                ydisplacement += Random.Range(0f, 1.5f);
            }
        }
        else if (location == "bottom")
        {
            ydisplacement += Spawner.current.bottomenemyspawnzone;
            if (randompos == true)
            {
                xdisplacement = Random.Range(boundingBox.current.xlowerlimit, boundingBox.current.xupperlimit);
                ydisplacement += Random.Range(-1.5f, 0f);
            }
        }
        else if (location == "left")
        {
            xdisplacement += Spawner.current.leftenemyspawnzone;
            if (randompos == true)
            {
                xdisplacement = Random.Range(-1.5f, 0f);
                ydisplacement += Random.Range(boundingBox.current.ylowerlimit, boundingBox.current.yupperlimit);
            }
        }
        else if (location == "right")
        {
            xdisplacement += Spawner.current.rightenemyspawnzone;
            if (randompos == true)
            {
                xdisplacement = Random.Range(0f, 1.5f);
                ydisplacement += Random.Range(boundingBox.current.ylowerlimit, boundingBox.current.yupperlimit);
            }
        }
        Container c = new Container(enemytype, xdisplacement, ydisplacement, interval);
        current.queue.Add(c);
        current.totalQueue++;
    }

    // Update is called once per frame
    void Update () {
        if (queue.Count > 0) {
            if (Time.time - lastspawnedtime >= queue[0].interval)
            {
                if (dict[queue[0].enemytype].tag != "boss")
                {
                    Instantiate(dict[queue[0].enemytype], new Vector2(queue[0].xdisplacement, queue[0].ydisplacement), Quaternion.Euler(0, 0, 0));
                    lastspawnedtime = Time.time;
                    queue.RemoveAt(0);
                }
                else
                {
                    GameObject[] enemylist = GameObject.FindGameObjectsWithTag("enemy");
                    if (enemylist.Length == 0)
                    {
                        Instantiate(dict[queue[0].enemytype], new Vector2(queue[0].xdisplacement, queue[0].ydisplacement), Quaternion.Euler(0, 0, 0));
                        lastspawnedtime = Time.time;
                        queue.RemoveAt(0);
                    }
                }

            }
        }
	}
    public static bool CheckSpawningBox (GameObject gobject)
    {
        if ((gobject.transform.position.y > Spawner.current.topenemyspawnzone + 1.5f)
        || (gobject.transform.position.y < Spawner.current.bottomenemyspawnzone - 1.5f)
        || (gobject.transform.position.x > Spawner.current.rightenemyspawnzone + 1.5f)
        || (gobject.transform.position.x < Spawner.current.leftenemyspawnzone -1.5f))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
