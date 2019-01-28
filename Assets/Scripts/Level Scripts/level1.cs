using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1 : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        //Format: Spawner.spawn("enemy type", "spawner position", x offset position, y offset position", time interval, randomise position?);
        Spawner.spawn("apple", "top", 0, 0, 3, false);
        Spawner.spawn("apple", "top", 3, 0, 0, false);
        Spawner.spawn("apple", "top", 6, 0, 0, false);
        Spawner.spawn("apple", "top", 9, 0, 0, false);
        Spawner.spawn("apple", "top", -3, 0, 0, false);
        Spawner.spawn("apple", "top", -6, 0, 0, false);
        Spawner.spawn("apple", "top", -9, 0, 0, false); //wave 1


        Spawner.spawn("golden apple", "top", 0, 1, 2.5f, true);
        Spawner.spawn("shoe", "top", -5, 1, 0, false);
        Spawner.spawn("shoe", "top", 5, 1, 0, false); //wave 2


        Spawner.spawn("apple", "top", -7, 1, 3, false);
        Spawner.spawn("apple", "top", -2, 2, 0, false);
        Spawner.spawn("apple", "top", 1, 0, 0, false);
        Spawner.spawn("apple", "top", 4, 3, 0, false);
        Spawner.spawn("apple", "top", 10, 1, 0, false);
        Spawner.spawn("bat", "top", 3, 1, 1, false);
        Spawner.spawn("head", "top", -4, 0, 0, false);
        Spawner.spawn("head", "top", 7, 0, 0, false); // wave 3


        Spawner.spawn("butterfly", "left", -12, 5, 3.5f, false);
        Spawner.spawn("butterfly", "left", -12, 5, 1, false);
        Spawner.spawn("butterfly", "left", -12, 5, 1, false);
        Spawner.spawn("butterfly", "left", -12, 5, 1, false); //wave 4


        Spawner.spawn("butterfly", "right", 16, 2, 3.5f, false);
        Spawner.spawn("butterfly", "right", 16, 2, 1, false);
        Spawner.spawn("butterfly", "right", 16, 2, 1, false);
        Spawner.spawn("butterfly", "right", 16, 2, 1, false); //wave 5


        Spawner.spawn("apple", "top", -10, 1, 3.5f, false);
        Spawner.spawn("apple", "top", -7, 2, 0, false);
        Spawner.spawn("apple", "top", -5, 0, 0, false);
        Spawner.spawn("head", "top", -2, 3, 0, false);
        Spawner.spawn("head", "top", 0, 1, 0, false);
        Spawner.spawn("head", "top", 3, 1, 1, false);
        Spawner.spawn("apple", "top", 5, 2, 0, false);
        Spawner.spawn("apple", "top", 9, 2, 0, false);
        Spawner.spawn("golden apple", "top", 0, 1, 1, true);//wave 6


        Spawner.spawn("butterfly", "left", -12, -1, 3, false);
        Spawner.spawn("butterfly", "left", -12, -1, 1, false);
        Spawner.spawn("butterfly", "left", -12, -1, 1, false);
        Spawner.spawn("butterfly", "left", -12, -1, 1, false); //wave 7


        Spawner.spawn("butterfly", "right", 16, -3, 3, false);
        Spawner.spawn("butterfly", "right", 16, -3, 1, false);
        Spawner.spawn("butterfly", "right", 16, -3, 1, false);
        Spawner.spawn("butterfly", "right", 16, -3, 1, false); //wave 8


        Spawner.spawn("shoe", "top", -8, 1, 3, false);
        Spawner.spawn("shoe", "top", -5, 1, 0, false);
        Spawner.spawn("shoe", "top", 1, 1, 0, false);
        Spawner.spawn("shoe", "top", 6, 1, 0, false);
        Spawner.spawn("shoe", "top", 10, 1, 0, false);
        Spawner.spawn("bat", "top", -7, 3, 0, false);
        Spawner.spawn("bat", "top", -1, 2, 0, false);
        Spawner.spawn("bat", "top", 9, 4, 0, false); // wave 9

        //repeat starts here

        Spawner.spawn("apple", "top", 0, 2, 3, false);
        Spawner.spawn("apple", "top", 3, 1, 0, false);
        Spawner.spawn("apple", "top", 6, 4, 0, false);
        Spawner.spawn("apple", "top", 9, 3, 0, false);
        Spawner.spawn("apple", "top", -3, 1, 0, false);
        Spawner.spawn("apple", "top", -6, 0, 0, false);
        Spawner.spawn("apple", "top", -9, 2, 0, false); //wave 1

        Spawner.spawn("butterfly", "left", -12, -1, 3, false);
        Spawner.spawn("butterfly", "left", -12, -1, 1, false);
        Spawner.spawn("butterfly", "left", -12, -1, 1, false);
        Spawner.spawn("butterfly", "left", -12, -1, 1, false); //wave 7

        Spawner.spawn("golden apple", "top", 0, 1, 2, true);
        Spawner.spawn("shoe", "top", -5, 1, 0, false);
        Spawner.spawn("shoe", "top", 5, 1, 0, false); //wave 2

        Spawner.spawn("apple", "top", -10, 1, 3, false);
        Spawner.spawn("apple", "top", -7, 2, 0, false);
        Spawner.spawn("apple", "top", -5, 0, 0, false);
        Spawner.spawn("head", "top", -2, 3, 0, false);
        Spawner.spawn("head", "top", 0, 1, 0, false);
        Spawner.spawn("head", "top", 3, 1, 1, false);
        Spawner.spawn("apple", "top", 5, 2, 0, false);
        Spawner.spawn("apple", "top", 9, 2, 0, false);
        Spawner.spawn("golden apple", "top", 0, 1, 1, true);//wave 6
        
        Spawner.spawn("stage one boss", "top", 0, 2, 3, false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
