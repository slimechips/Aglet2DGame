using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMaster : MonoBehaviour {

    //Contains all prefabs for ui
    public static UIMaster current;
    public GameObject redpulse;
    public GameObject speedicon;
    public GameObject shieldicon;
    public GameObject healthicon;
    public string[] projectileiconnames;
    public GameObject[] projectileicons;
    public Dictionary<string, GameObject> projectileicondict = new Dictionary<string, GameObject>();

    // Use this for initialization
    private void Awake()
    {
        UIMaster.current = this;
        for (int i = 0; i<projectileiconnames.Length; i++)
        {
            projectileicondict.Add(projectileiconnames[i], projectileicons[i]);
        }
    }
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}