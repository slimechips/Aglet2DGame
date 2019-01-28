using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {
        //Format: Spawner.spawn("enemy type", "spawner position", x offset position, y offset position", time interval, randomise position?);
        
        //wave1
        Spawner.spawn("golden red apple", "top", 0f, 0f, 0.5f, true);
        Spawner.spawn("golden red apple", "top", 0f, 0f, 3f, true);
        Spawner.spawn("golden red apple", "top", 0f, 0f, 3f, true);
        Spawner.spawn("golden red apple", "top", 0f, 0f, 3f, true);
        
        Spawner.spawn("hairball", "bottom", 0f, 0f, 2f, true);
        
        //wave2


        Spawner.spawn("shoe", "top", -2f, 0f, 1f, true);
        Spawner.spawn("shoe", "top", 2f, 0f, 0f, true);
        Spawner.spawn("shoe", "top", 6f, 0f, 0.1f, true);
        Spawner.spawn("shoe", "top", 4f, 0f, 0f, true);

        Spawner.spawn("butterfly", "left", 0f, -6f, 1f, false);
        Spawner.spawn("butterfly", "left", 0f, 4f, 0f, false);
        Spawner.spawn("butterfly", "left", 0f, 2f, 0.1f, false);
        Spawner.spawn("butterfly", "left", 0f, 0f, 0f, false);

        Spawner.spawn("butterfly", "right", 0f, -6f, 1f, false);
        Spawner.spawn("butterfly", "right", 0f, 4f, 0f, false);
        Spawner.spawn("butterfly", "right", 0f, 2f, 0.1f, false);
        Spawner.spawn("butterfly", "right", 0f, 0f, 0f, false);

        Spawner.spawn("shoe", "top", -6f, 0f, 0.1f, true);
        Spawner.spawn("shoe", "top", -4f, 0f, 0f, true);
        Spawner.spawn("shoe", "top", 2f, 0f, 0.1f, true);
        Spawner.spawn("shoe", "top", 0f, 0f, 0f, true);

        Spawner.spawn("shoe", "bottom", -6f, 0f, 0.1f, true);
        Spawner.spawn("shoe", "bottom", -4f, 0f, 0f, true);
        Spawner.spawn("shoe", "bottom", 2f, 0f, 0.1f, true);
        Spawner.spawn("shoe", "bottom", 0f, 0f, 0f, true);
        Spawner.spawn("shoe", "bottom", 4f, 0f, 0.1f, true);
        Spawner.spawn("shoe", "bottom", 6f, 0f, 0f, true);

        Spawner.spawn("butterfly", "left", 0f, 4f, 0.1f, false);
        Spawner.spawn("butterfly", "left", 0f, -2f, 0f, false);
        Spawner.spawn("butterfly", "left", 0f, -6f, 0.1f, false);
        Spawner.spawn("butterfly", "left", 0f, 6f, 0f, false);

        Spawner.spawn("butterfly", "left", 0f, 0f, 0f, false);
        Spawner.spawn("butterfly", "left", 0f, 0f, 0f, false);
        Spawner.spawn("butterfly", "right", 0f, 0f, 0f, false);
        Spawner.spawn("butterfly", "right", 0f, 0f, 0f, false);

        Spawner.spawn("hairball", "bottom", -4f, 0f, 2f, true);
        
        Spawner.spawn("shoe", "top", 0f, 0f, 0f, true);
        Spawner.spawn("shoe", "top", 0f, 0f, 0.1f, true);
        Spawner.spawn("shoe", "top", 0f, 0f, 0.1f, true);
        Spawner.spawn("shoe", "top", 0f, 0f, 0.1f, true);
        
        
        //wave 3
        float interval2 = 0.4f;
        Spawner.spawn("speed power up", "top", -4f, 0f, 5f, false);
        Spawner.spawn("2 bats", "top", -4f, 0f, 2f, false);
        Spawner.spawn("2 bats", "top", -2f, 0f, 0f, false);
        Spawner.spawn("2 bats", "top", 0f, 0f, 0f, false);

        Spawner.spawn("2 bats", "top", 0f, 0f, interval2, false);
        Spawner.spawn("2 bats", "top", 2f, 0f, 0f, false);
        Spawner.spawn("2 bats", "top", 4f, 0f, 0f, false);

        Spawner.spawn("2 bats", "top", -9f, 0f, interval2, false);
        Spawner.spawn("2 bats", "top", -6f, 0f, 0f, false);
        Spawner.spawn("2 bats", "top", -4f, 0f, 0f, false);

        Spawner.spawn("2 bats", "top", -2f, 0f, interval2, false);
        Spawner.spawn("2 bats", "top", 0f, 0f, 0f, false);
        Spawner.spawn("2 bats", "top", 2f, 0f, 0f, false);

        Spawner.spawn("2 bats", "top", -9f, 0f, interval2, false);
        Spawner.spawn("2 bats", "top", -6f, 0f, 0f, false);
        Spawner.spawn("2 bats", "top", -4f, 0f, 0f, false);

        Spawner.spawn("2 bats", "top", 0f, 0f, interval2, false);
        Spawner.spawn("2 bats", "top", 2f, 0f, 0f, false);
        Spawner.spawn("2 bats", "top", 4f, 0f, 0f, false);
        
        Spawner.spawn("2 bats", "top", 4f, 0f, interval2, false);
        Spawner.spawn("2 bats", "top", 6f, 0f, 0f, false);
        Spawner.spawn("2 bats", "top", 8f, 0f, 0f, false);

        Spawner.spawn("2 bats", "top", -2f, 0f, interval2, false);
        Spawner.spawn("2 bats", "top", 0f, 0f, 0f, false);
        Spawner.spawn("2 bats", "top", 2f, 0f, 0f, false);

        Spawner.spawn("2 bats", "top", -9f, 0f, interval2, false);
        Spawner.spawn("2 bats", "top", -6f, 0f, 0f, false);
        Spawner.spawn("2 bats", "top", -4f, 0f, 0f, false);

        float interval = 0.1f;
        Spawner.spawn("2 bats", "top", -4f, 0f, 2f, false);
        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 4f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 2f, 0f, interval, false);
        

        Spawner.spawn("2 bats", "top", -4f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -9f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 8f, 0f, 0, false);
        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -9f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -6f, 0f, interval, false);

        Spawner.spawn("2 bats", "top", 2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 4f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 6f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);

        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -4f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -9f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -6f, 0f, interval, false);

        Spawner.spawn("2 bats", "top", 4f, 0f, 2f, false);
        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -4f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -2f, 0f, interval, false);

        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 6f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -9f, 0f, 0, false);
        Spawner.spawn("2 bats", "top", 8f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 4f, 0f, interval, false);

        Spawner.spawn("2 bats", "top", -2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 4f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 8f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 6f, 0f, interval, false);

        Spawner.spawn("2 bats", "top", -4f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -9f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -9f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -6f, 0f, interval, false);

        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 6f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -9f, 0f, 0, false);
        Spawner.spawn("2 bats", "top", 8f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 4f, 0f, interval, false);

        Spawner.spawn("2 bats", "top", 2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 4f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 8f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 6f, 0f, interval, false);

        
        Spawner.spawn("2 bats", "top", -4f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -9f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 8f, 0f, 0, false);
        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -9f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -6f, 0f, interval, false);

        Spawner.spawn("2 bats", "top", 0f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 6f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 2f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 8f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", -4f, 0f, interval, false);
        Spawner.spawn("2 bats", "top", 4f, 0f, interval, false);

        //wave 4
        float interval1 = 4f;
        Spawner.spawn("shell left", "left", 2f, 8f, interval1, false);
        Spawner.spawn("shell left", "left", 0f, 2f, 0, false);
        Spawner.spawn("shell right", "right", -3f, 6f, 0, false);

        Spawner.spawn("shell left", "left", 0f, 0f, 0, false);
        Spawner.spawn("shell right", "right", 0f, 3f, 0, false);
        Spawner.spawn("shell right", "right", -2f, 0f, 0, false);

        Spawner.spawn("shell left", "left", 2f, -5f, interval1, false);
        Spawner.spawn("shell left", "left", 0f, 4f, 0, false);
        Spawner.spawn("shell right", "right", -2f, 5f, 0, false);

        Spawner.spawn("shell left", "left", 0f, 0f, interval1, false);
        Spawner.spawn("shell right", "right", 0f, 3f, 0, false);
        Spawner.spawn("shell right", "right", -2f, -5f, 0, false);

        Spawner.spawn("shoe box", "top", -4f, 0f, 0, false);
        Spawner.spawn("shoe box", "top", 4f, 0f, 0, false);

        Spawner.spawn("shell left", "left", 2f, -5f, interval1, false);
        Spawner.spawn("shell left", "left", 0f, 4f, 0, false);
        Spawner.spawn("shell right", "right", -2f, 5f, 0, false);

        Spawner.spawn("shell left", "left", 0f, 0f, interval1, false);
        Spawner.spawn("shell right", "right", 0f, 3f, 0, false);
        Spawner.spawn("shell right", "right", -2f, -5f, 0, false);

        Spawner.spawn("shell left", "left", 2f, -5f, interval1, false);
        Spawner.spawn("shell left", "left", 0f, 4f, 0, false);
        Spawner.spawn("shell right", "right", -2f, 5f, 0, false);

        Spawner.spawn("koala", "top", -2f, 0f, 0, true);

        Spawner.spawn("shell left", "left", 0f, 0f, interval1, false);
        Spawner.spawn("shell right", "right", 0f, 3f, 0, false);
        Spawner.spawn("shell right", "right", -2f, -5f, 0, false);

        Spawner.spawn("shell left", "left", 2f, -5f, interval1, false);
        Spawner.spawn("shell left", "left", 0f, 4f, 0, false);
        Spawner.spawn("shell right", "right", -2f, 5f, 0, false);

        Spawner.spawn("koala", "top", 0f, 0f, 0, true);

        Spawner.spawn("shell left", "left", 0f, 0f, interval1, false);
        Spawner.spawn("shell right", "right", 0f, 3f, 0, false);
        Spawner.spawn("shell right", "right", -2f, -5f, 0, false);

        Spawner.spawn("shell left", "left", 2f, -5f, interval1, false);
        Spawner.spawn("shell left", "left", 0f, 4f, 0, false);
        Spawner.spawn("shell right", "right", -2f, 5f, 0, false);

        Spawner.spawn("koala", "top", 2f, 0f, 0, true);

        Spawner.spawn("shell left", "left", 0f, 0f, interval1, false);
        Spawner.spawn("shell right", "right", 0f, 3f, 0, false);
        Spawner.spawn("shell right", "right", -2f, -5f, 0, false);
        
        Spawner.spawn("shell left", "left", 2f, -5f, interval1, false);
        Spawner.spawn("shell left", "left", 0f, 4f, 0, false);
        Spawner.spawn("shell right", "right", -2f, 5f, 0, false);

        Spawner.spawn("koala", "top", -2f, 0f, 0, true);

        Spawner.spawn("shell left", "left", 0f, 0f, interval1, false);
        Spawner.spawn("shell right", "right", 0f, 3f, 0, false);
        Spawner.spawn("shell right", "right", -2f, -5f, 0, false);
        
        Spawner.spawn("shell left", "left", 2f, -5f, interval1, false);
        Spawner.spawn("shell left", "left", 0f, 4f, 0, false);
        Spawner.spawn("shell right", "right", -2f, 5f, 0, false);
        
        float interval3 = 8f;

        Spawner.spawn("turtle", "top", -3f, 0f, 0,false);

        Spawner.spawn("shell left", "left", 0f, 0f, interval3, false);
        Spawner.spawn("shell right", "right", 0f, 3f, 0, false);
        Spawner.spawn("shell right", "right", -2f, -5f, 0, false);

        Spawner.spawn("shell left", "left", 2f, -5f, interval3, false);
        Spawner.spawn("shell left", "left", 0f, 4f, 0, false);
        Spawner.spawn("shell right", "right", -2f, 5f, 0, false);

        Spawner.spawn("turtle", "top", 2f, 0f, 0, false);

        Spawner.spawn("shell left", "left", 0f, 0f, interval3, false);
        Spawner.spawn("shell right", "right", 0f, 3f, 0, false);
        Spawner.spawn("shell right", "right", -2f, -5f, 0, false);


        Spawner.spawn("shell left", "left", 2f, -5f, interval3, false);
        Spawner.spawn("shell left", "left", 0f, 4f, 0, false);
        Spawner.spawn("shell right", "right", -2f, 5f, 0, false);

        Spawner.spawn("shell left", "left", 0f, 0f, interval3, false);
        Spawner.spawn("shell right", "right", 0f, 3f, 0, false);
        Spawner.spawn("shell right", "right", -2f, -5f, 0, false);

        Spawner.spawn("shell left", "left", 2f, -5f, interval3, false);
        Spawner.spawn("shell left", "left", 0f, 4f, 0, false);
        Spawner.spawn("shell right", "right", -2f, 5f, 0, false);

        for (float i = -2; i < 3; i++)
        {
            Spawner.spawn("shoe", "top", 3*i, 0f, 0f, false);
            Spawner.spawn("shoe", "right", 0f, 3*i, 0f, false);
            Spawner.spawn("shoe", "left", 0f, 3*i, 0f, false);
            Spawner.spawn("shoe", "bottom", 3*i, 0f, 0f, false);

        }

        Spawner.spawn("shoe", "top", 0, 0f, 3f, false);
        for (float i = -2; i < 3; i++)
        {
            Spawner.spawn("shoe", "top", 3 * i, 0f, 0f, false);
            Spawner.spawn("shoe", "right", 0f, 3 * i, 0f, false);
            Spawner.spawn("shoe", "left", 0f, 3 * i, 0f, false);
            Spawner.spawn("shoe", "bottom", 3 * i, 0f, 0f, false);

        }
        Spawner.spawn("stage three boss", "top", 0f, 0f, 0f, false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
