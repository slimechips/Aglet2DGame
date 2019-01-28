using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

    public static PlayerScore current;
    Text text;
    public int score=0;

    private void Awake()
    {
        PlayerScore.current = this;
        text = GetComponent<Text>();

    }
    // Use this for initialization
    void Start () {
        // Set up the reference.
        if (GlobalSceneManager.save == true)
        {
            score = GlobalSceneManager.current.savedScore;
        }
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "" + (score);

    }

    public void update_score(int value)
    {
        score += value;
    }

    public void scoreReset()
    {
        score = 0;
    }
}
