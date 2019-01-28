using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageThreeBoss : MonoBehaviour {

    private float bossHealthOne = 900f;
    private float bossHealthTwo = 1200f;
    private int counter = 1;
    private int rageSpeedCounter = 1;

    public bool rage = false;
    [SerializeField]
    private float rageHp = 500.0f;

    private float horizontalSpeed = 5.0f;
    private float verticalSpeed = -3.0f;

    private float timeSinceLastSpawn;
    private float timeSinceLastShoot;
    private float shootInterval = 2.0f;
    private float spawnInterval = 3.0f;

    private float shootSkillTimer = 60.0f;

    public Sprite innerBoss;
       
    //bullets
    public GameObject normalBullet;
    public GameObject rageBullet;
    public GameObject aoeBullet;
    public GameObject laser; //hopefully can spawn the prefab

    //enemies that the boss spawns
    public GameObject[] enemies; //basic enemy, intermediate enemy, suicidal enemy

    [SerializeField]
    private GameObject stageThreeBossHealthBar;

    private void Awake()
    {
        Instantiate(stageThreeBossHealthBar, new Vector2(0, 7f), new Quaternion(0, 0, 0, 0));
        this.GetComponent<EnemyProperties>().health = bossHealthOne;
    }

    void Start ()
    {
        timeSinceLastSpawn = Time.time;
        timeSinceLastShoot = Time.time;
    }
	
	void Update ()
    {
        if(this.GetComponent<EnemyProperties>().health <=0f)
        {
            Destroy(this.gameObject);
        }
		if(this.GetComponent<EnemyProperties>().health <= 100f && counter == 1) // break the shell
        {
            this.GetComponent<EnemyProperties>().health = bossHealthTwo;
            counter--;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = innerBoss;
        }
        
        transform.Translate(1 * horizontalSpeed * Time.deltaTime, Time.deltaTime * verticalSpeed, 0); //movement part of the script
        if (this.transform.position.y < 3.0f)
        {
            verticalSpeed = 0.0f;
        }
        if (this.gameObject.transform.position.x > 8f)
        {
            horizontalSpeed = -1 * horizontalSpeed;
        }
        if (this.gameObject.transform.position.x < -8f)
        {
            horizontalSpeed = -1 * horizontalSpeed;
        }

        if (this.GetComponent<EnemyProperties>().health <= rageHp && counter == 0) //rage mode changes
        {
            rage = true;
            if(rage == true && rageSpeedCounter == 1)
            {
                horizontalSpeed = 7.0f;
                rageSpeedCounter--;
            }
        }
        shootingSkill(shootSkillTimer, Time.time);
        bossSpawningSkill(rage); //spawning skill
        shootSkillTimer -= Time.deltaTime;
    }

    private void shootingSkill(float timer, float time) //enters current timer and time
    {
        if(rage == false)
        {
            if(time - timeSinceLastShoot > shootInterval)
            {
                Instantiate(normalBullet, this.transform.position, this.transform.rotation);
                timeSinceLastShoot = Time.time;
            }
        }
        if(rage == true)
        {
            //rage shooting --> normal shoot, laser, aoe
            if(timer >=40.0f)
            {
                if(time - timeSinceLastShoot > shootInterval)
                {
                    Instantiate(rageBullet, this.transform.position, this.transform.rotation);
                    timeSinceLastShoot = Time.time;
                    laser.SetActive(false);
                }
            }
            if (timer < 40.0f && timer  >= 20.0f)
            {
                if (time - timeSinceLastShoot > shootInterval)
                {
                    Instantiate(aoeBullet, this.transform.position, this.transform.rotation);
                    Instantiate(aoeBullet, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, 30));
                    Instantiate(aoeBullet, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, 60));
                    Instantiate(aoeBullet, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, -30));
                    Instantiate(aoeBullet, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, -60));
                    timeSinceLastShoot = Time.time;
                }
            }
            if(timer <20.0f && timer >=0.0f)
            {
                laser.SetActive(true);
            }
            if(timer < 0.0f)
            {
                shootSkillTimer = 60.0f;
            }
        }
    }

    private void bossSpawningSkill(bool state)
    {
        if(state == false)
        {
            basicSkill(Time.time);
        }
        if(state == true)
        {
            rageSkill(Time.time);
        }
    }
    
    private void basicSkill(float time) //spawn basic enemy + intermediate enemy
    {
        if(time - timeSinceLastSpawn > spawnInterval)
        {
            Instantiate(enemies[Random.Range(0, 2)], this.transform.position, this.transform.rotation);
            timeSinceLastSpawn = Time.time;
        }
    }

    private void rageSkill(float time)
    {
        if(time - timeSinceLastSpawn > spawnInterval)
        {
            Instantiate(enemies[Random.Range(0, 3)], this.transform.position, this.transform.rotation);
            timeSinceLastSpawn = Time.time;
        }
    }

    private void OnDestroy()
    {
        if (this.GetComponent<EnemyProperties>().health <= 0)
        {
            playerBehavior.current.Health(5, this.transform.position);
            GlobalSceneManager.current.PlayerChangeScene();
        }
    }
}
