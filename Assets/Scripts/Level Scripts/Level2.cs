using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2 : MonoBehaviour {

    [SerializeField]
    private float minefieldIntervalOne = 0.5f;

	// Use this for initialization
	void Start () {
        //Format: Spawner.spawn("enemy type", "spawner position", x offset position, y offset position", time interval, randomise position?);
        
        //Wave 1 (Powerup golden apple)
        Spawner.spawn("golden apple", "top", 0f, 0f, 0.5f, false);
        Spawner.spawn("green apple", "top", -1.5f, 0.0f, 0f, false);
        Spawner.spawn("green apple", "top", -0.5f, 1.2f, 0f, false);
        Spawner.spawn("green apple", "top", 0.5f, 1.2f, 0f, false);
        Spawner.spawn("green apple", "top", 1.5f, 0.0f, 0f, false);
        Spawner.spawn("green apple", "top", 0.5f, -1.2f, 0f, false);
        Spawner.spawn("green apple", "top", -0.5f, -1.2f, 0f, false);

        //Wave 2 (Random red applex5 wavex3)
        Spawner.spawn("apple", "top", 0f, 0f, 5f, true);//set1
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 4f, true);//set2
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 4f, true);//set3
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        //Wave 3 (Batx6 wave)
        Spawner.spawn("bat", "top", 0f, 0f, 5f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);

        //Wave 4 (Random Red applex3 bat 2x Wavex3 +)
        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);//set1
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 2f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 0.5f, true);//set2
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 2f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 0.5f, true);//set3
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 2f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);

        //Wave 5 (Batx6 wave)
        Spawner.spawn("bat", "top", 0f, 0f, 5f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);

        //Wave 6 (Powerup golden apple x 3)
        Spawner.spawn("golden apple", "top", 0f, 0f, 0.5f, false);
        Spawner.spawn("green apple", "top", -1.5f, 0.0f, 0f, false);
        Spawner.spawn("green apple", "top", -0.5f, 1.2f, 0f, false);
        Spawner.spawn("green apple", "top", 0.5f, 1.2f, 0f, false);
        Spawner.spawn("green apple", "top", 1.5f, 0.0f, 0f, false);
        Spawner.spawn("green apple", "top", 0.5f, -1.2f, 0f, false);
        Spawner.spawn("green apple", "top", -0.5f, -1.2f, 0f, false);

        Spawner.spawn("golden apple", "top", -5f, 0f, 4f, false);
        Spawner.spawn("green apple", "top", -6.5f, 0.0f, 0f, false);
        Spawner.spawn("green apple", "top", -5.5f, 1.2f, 0f, false);
        Spawner.spawn("green apple", "top", -4.5f, 1.2f, 0f, false);
        Spawner.spawn("green apple", "top", -3.5f, 0.0f, 0f, false);
        Spawner.spawn("green apple", "top", -4.5f, -1.2f, 0f, false);
        Spawner.spawn("green apple", "top", -5.5f, -1.2f, 0f, false);

        Spawner.spawn("golden apple", "top", 5.0f, 0f, 4f, false);
        Spawner.spawn("green apple", "top", 3.5f, 0.0f, 0f, false);
        Spawner.spawn("green apple", "top", 4.5f, 1.2f, 0f, false);
        Spawner.spawn("green apple", "top", 5.5f, 1.2f, 0f, false);
        Spawner.spawn("green apple", "top", 6.5f, 0.0f, 0f, false);
        Spawner.spawn("green apple", "top", 5.5f, -1.2f, 0f, false);
        Spawner.spawn("green apple", "top", 4.5f, -1.2f, 0f, false);
    
        //Wave 7 (Shoe Boxes & apples)

        Spawner.spawn("apple", "top", 0f, 0f, 4f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("shoe box", "top", 0f, 0f, 0f, false);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("shoe box", "top", -5f, 0f, 0f, false);
        Spawner.spawn("shoe box", "top", 5f, 0f, 0f, false);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 2f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        
        //Wave 8 Butterflies & Bats
        Spawner.spawn("butterfly", "left", 0f, 5f, 3f, false);
        Spawner.spawn("butterfly", "right", 0f, 5f, 0f, false);
        Spawner.spawn("butterfly", "left", 0f, 5f, 0.5f, false);
        Spawner.spawn("butterfly", "right", 0f, 5f, 0f, false);

        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);

        Spawner.spawn("butterfly", "left", 0f, 3f, 0.5f, false);
        Spawner.spawn("butterfly", "right", 0f, 3f, 0f, false);
        Spawner.spawn("butterfly", "left", 0f, 3f, 0.5f, false);
        Spawner.spawn("butterfly", "right", 0f, 3f, 0f, false);

        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);

        Spawner.spawn("butterfly", "left", 0f, 0.5f, 0.5f, false);
        Spawner.spawn("butterfly", "right", 0f, 0.5f, 0f, false);
        Spawner.spawn("butterfly", "left", 0f, 0.5f, 0.5f, false);
        Spawner.spawn("butterfly", "right", 0f, 0.5f, 0f, false);

        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);

        Spawner.spawn("butterfly", "left", 0f, -0.5f, 0.5f, false);
        Spawner.spawn("butterfly", "right", 0f, -0.5f, 0f, false);
        Spawner.spawn("butterfly", "left", 0f, -0.5f, 0.5f, false);
        Spawner.spawn("butterfly", "right", 0f, -0.5f, 0f, false);

        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);

        Spawner.spawn("butterfly", "left", 0f, -3f, 0.5f, false);
        Spawner.spawn("butterfly", "right", 0f, -3f, 0f, false);
        Spawner.spawn("butterfly", "left", 0f, -3f, 0.5f, false);
        Spawner.spawn("butterfly", "right", 0f, -3f, 0f, false);

        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        
        //Wave 9 golden apple
        Spawner.spawn("golden apple", "top", 0f, 0f, 0.5f, false);
        Spawner.spawn("green apple", "top", -1.5f, 0.0f, 0f, false);
        Spawner.spawn("green apple", "top", -0.5f, 1.2f, 0f, false);
        Spawner.spawn("green apple", "top", 0.5f, 1.2f, 0f, false);
        Spawner.spawn("green apple", "top", 1.5f, 0.0f, 0f, false);
        Spawner.spawn("green apple", "top", 0.5f, -1.2f, 0f, false);
        Spawner.spawn("green apple", "top", -0.5f, -1.2f, 0f, false);
        
        //Wave 10 Spikeys
        Spawner.spawn("shell left", "left", 0f, -3f, 5f, false);
        Spawner.spawn("shell right", "right", 0f, 3f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 0f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "right", 0f, 2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 0f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, -3f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 3f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 0f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 4f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 6f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, -7f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 5f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 5f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 7f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -6f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 3f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 4f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -5f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 3f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 0f, minefieldIntervalOne, false);

        //Wave 11 Spikey with 1 head
        Spawner.spawn("head", "top", -4f, 0f, 1f, false); //1 head
        Spawner.spawn("golden apple", "top", 0f, 0f, 0.0f, true); //random apple

        Spawner.spawn("shell left", "left", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, minefieldIntervalOne, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 0f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -6f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "right", 0f, 3f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 4f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, -4f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 1f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -3f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -6f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, minefieldIntervalOne, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -5f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 2f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 6f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 4f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -3f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 5f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -5f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 3f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -4f, minefieldIntervalOne, false);

        //Wave 12 Spikey with 1 head
        Spawner.spawn("head", "top", 4f, 0f, 1f, false); //1 head
        Spawner.spawn("golden apple", "top", 0f, 0f, minefieldIntervalOne, true); //random apple

        Spawner.spawn("shell left", "left", 0f, -3f, 5f, false);
        Spawner.spawn("shell right", "right", 0f, 3f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 0f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "right", 0f, 2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 0f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, -3f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 3f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 0f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 4f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 6f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, -7f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 5f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 5f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 7f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -6f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 3f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 4f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -5f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 3f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 0f, minefieldIntervalOne, false);

        //Wave 13 Spikey with 2 heads
        Spawner.spawn("head", "top", -5f, 0f, 1f, false); //2heads
        Spawner.spawn("head", "top", 5f, 0f, 0f, false);
        Spawner.spawn("golden apple", "top", 0f, 0f, minefieldIntervalOne, true); //random apple


        Spawner.spawn("shell left", "left", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, minefieldIntervalOne, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 0f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -6f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "right", 0f, 3f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 4f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, -4f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 1f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -3f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -6f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, minefieldIntervalOne, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -5f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 2f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, -2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 6f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, 4f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -3f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 5f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 2f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -5f, minefieldIntervalOne, false);
        Spawner.spawn("shell left", "left", 0f, 3f, minefieldIntervalOne, false);
        Spawner.spawn("shell right", "right", 0f, -4f, minefieldIntervalOne, false);

        //Wave 15 Apples x3 easy x3 medium
        Spawner.spawn("apple", "top", 0f, 0f, 5f, true);//set1
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 4f, true);//set2
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 4f, true);//set3
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 4f, true);//set4
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 4f, true);//set5
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);

        Spawner.spawn("apple", "top", 0f, 0f, 4f, true);//set6
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        Spawner.spawn("apple", "top", 0f, 0f, 0f, true);
        
        //Wave 16 (Batx6 wave)
        Spawner.spawn("bat", "top", 0f, 0f, 5f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);
        Spawner.spawn("bat", "top", 0f, 0f, 0f, true);

        //Wave 17 (Powerup golden apple)
        Spawner.spawn("golden apple", "top", 0f, 0f, 0.5f, false);
        Spawner.spawn("green apple", "top", -1.5f, 0.0f, 0f, false);
        Spawner.spawn("green apple", "top", -0.5f, 1.2f, 0f, false);
        Spawner.spawn("green apple", "top", 0.5f, 1.2f, 0f, false);
        Spawner.spawn("green apple", "top", 1.5f, 0.0f, 0f, false);
        Spawner.spawn("green apple", "top", 0.5f, -1.2f, 0f, false);
        Spawner.spawn("green apple", "top", -0.5f, -1.2f, 0f, false);
        
        //Wave 18 Introduction to Laser + Butterfly + Rocket

        Spawner.spawn("butterfly", "left", 0f, 6f, 1f, false);
        Spawner.spawn("butterfly", "right", 0f, 5f, 1f, false);
        Spawner.spawn("shoe", "bottom", 0f, 0f, 1f, true);
        Spawner.spawn("koala", "top", -6f, 0f, 1f, false);

        Spawner.spawn("butterfly", "left", 0f, 4f, 1f, false);
        Spawner.spawn("butterfly", "right", 0f, 3f, 1f, false);
        Spawner.spawn("shoe", "bottom", 0f, 0f, 1f, true);
        Spawner.spawn("koala", "top", 6f, 0f, 1f, false);

        Spawner.spawn("butterfly", "left", 0f, 2f, 1f, false);
        Spawner.spawn("butterfly", "right", 0f, 1f, 1f, false);
        Spawner.spawn("butterfly", "left", 0f, 0f, 1f, false);
        Spawner.spawn("shoe", "bottom", 0f, 0f, 1f, true);
        Spawner.spawn("koala", "top", -3f, 0f, 1f, false);


        Spawner.spawn("butterfly", "right", 0f, -1f, 1f, false);
        Spawner.spawn("butterfly", "left", 0f, -2f, 1f, false);
        Spawner.spawn("butterfly", "right", 0f, -3f, 1f, false);
        Spawner.spawn("shoe", "bottom", 0f, 0f, 1f, true);
        Spawner.spawn("koala", "top", 3f, 0f, 1f, false);
        Spawner.spawn("golden green apple", "top", 0, 0, 3, false);
        
   
        Spawner.spawn("stage two boss", "top", 0, 2, 3, false);
        

    

    }

    // Update is called once per frame
    void Update () {
		
	}
}
