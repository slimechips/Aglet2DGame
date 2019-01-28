using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlayer : MonoBehaviour {

    AudioSource music;
    public AudioClip notBoss;
    public AudioClip boss;

    private int count = 1;

	void Start ()
    {
        music = GetComponent<AudioSource>();
        music.clip = notBoss;
        music.Play();

	}
	
	void Update ()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("boss");
        GameObject[] enemylist = GameObject.FindGameObjectsWithTag("enemy");
            if (gameObjects.Length == 1 && count == 1 && enemylist.Length == 0)
        {
            music.clip = boss;
            music.Play();
            count--;
        }

    }
}
