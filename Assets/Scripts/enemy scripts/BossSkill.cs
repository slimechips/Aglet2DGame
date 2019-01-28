using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSkill : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject aoeProjectile;

    private float bossHealth = 1500.0f;

    [SerializeField]
    public bool vulnerable = false;

    private float timer = 65.0f;
    private int skillNum = 0;

    private float summonInterval = 1.5f;
    private float waveInterval = 0.5f;
    private float timeSinceLastSummon;
    private float timeSinceLastWave;

    public bool state=false;

    private int numObjects = 10;

    private float moveSpeed = 5.0f;
    private Vector2 target = new Vector2(0,1.68f);


    void Start()
    {
        this.GetComponent<EnemyProperties>().health = bossHealth;
        timeSinceLastSummon = Time.time;
        timeSinceLastWave = Time.time;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 65.0f && timer > 45.0f)
        {
            skillNum = 1;
        }
        else if (timer <= 45.0f && timer > 25.0f)
        {
            skillNum = 2;
        }
        else if (timer <= 25.0f && timer > 20.0f)
        {
            skillNum = 3;
        }
        else if (timer < 20.0f)
        {
            skillNum = 4;
        }

        else if (timer < 0.0f)
        {
            timer = 65.0f;
        }

        bossSkill(skillNum);
        movementBoss(skillNum);
    }
    private void OnDestroy()
    {
        if (this.GetComponent<EnemyProperties>().health <= 0) {
            GlobalSceneManager.current.ChangeScene("Win");
        }
    }

    private void bossSkill(int num)
    {
        if (num == 1)
        {
            vulnerable = false;
            summonSkill(Time.time);
            state = false;
            //summoning part done, just need to change the spawn position details probably
        }
        if (num == 2)
        {
            vulnerable = true;
            state = false;
            //vulnerable state of the boss for aglet to deal damage
        }
        if (num == 3)
        {
            vulnerable = false;
            aoeSkill(Time.time);
            state = false;
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 72, 0);
            // ok so what im thinking is use for to spawn radially a NEW kind of projectile that dies after certain time [time to be adjusted later]
        }
        if (num == 4)
        {
            vulnerable = false;
            state = true;
            summonSkill(Time.time);
            //image fade in and out
        }
    }

    private void movementBoss(int num)
    {
        if(num == 1 || num == 2)
        {
            if(GameObject.Find("Boss").transform.position.x > 6.7f)
            {
                moveSpeed = -5.0f;
            }
            if (GameObject.Find("Boss").transform.position.x < -6.63f)
            {
                moveSpeed = 5.0f;
            }
            transform.Translate(1 * moveSpeed * Time.deltaTime, 0, 0);
        }
        if(num == 3)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), target, 2 * Time.deltaTime);
        }
        if (num == 4)
        {
            if (GameObject.Find("Boss").transform.position.x > 6.7f)
            {
                moveSpeed = -2.0f;
            }
            if (GameObject.Find("Boss").transform.position.x < -6.63f)
            {
                moveSpeed = 2.0f;
            }
            transform.Translate(1 * moveSpeed * Time.deltaTime, 0, 0);
        }
    }

    private void summonSkill(float time)
    {
        if (time - timeSinceLastSummon > summonInterval)
        {
            timeSinceLastSummon = Time.time; 
            Instantiate(enemies[Random.Range(0,5)], this.transform.position, this.transform.rotation);
        }
    }

    private void aoeSkill(float time)
    {
        if (time - timeSinceLastWave > waveInterval)
        {
            Vector3 center = transform.position;
            for (int i = 0; i < numObjects; i++)
            {
                Vector3 pos = Random.insideUnitCircle * 2;
                Quaternion rot = Quaternion.FromToRotation(Vector3.up, center - pos);
                Instantiate(aoeProjectile, pos, rot);
            }
            timeSinceLastWave = Time.time;
        }
    }
}
