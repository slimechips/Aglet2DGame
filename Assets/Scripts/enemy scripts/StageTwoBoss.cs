using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTwoBoss : MonoBehaviour {

    private float horizontalSpeed = 5.0f;
    private float verticalSpeed = -3.0f;
    private float timeSinceLastSpawn;
    private float spawnInterval = 2.0f;
    private bool rage = false;
    private float bossHealth = 1000.0f;

    [SerializeField]
    private float rageHp = 600.0f;

    private int counter = 1;

    public GameObject enemy;
    public GameObject suicidalEnemy;

    [SerializeField]
    private GameObject stageTwoBossHealthBar;

    private void Awake()
    {
        this.GetComponent<EnemyProperties>().health = bossHealth;
        Instantiate(stageTwoBossHealthBar, new Vector2(0, 7f), new Quaternion(0, 0, 0, 0));
    }

    void Start()
    {
        timeSinceLastSpawn = Time.time;
    }

    void Update()
    {
        //GameObject[] gameObjects;
        //gameObjects = GameObject.FindGameObjectsWithTag("enemy");
        //if (gameObjects.Length == 0)
        //{
            transform.Translate(1 * horizontalSpeed * Time.deltaTime, Time.deltaTime * verticalSpeed, 0);
        //}
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
        if (this.GetComponent<EnemyProperties>().health <= rageHp) //for rage mode, faster shooting rate
        {
            rage = true;
            this.GetComponent<StageTwoBossShootingBehaviour>().shootInterval = 1.5f;
            this.GetComponent<StageTwoBossShootingBehaviour>().wideShot = true;
            if(rage == true && counter == 1)
            {
                horizontalSpeed = 7.0f;
                counter--;
            }
        }
        spawnEnemy(Time.time, rage);
    }

    private void spawnEnemy(float time, bool state)
    {
        if(time - timeSinceLastSpawn > spawnInterval && rage == false)
        {
            Instantiate(enemy, this.transform.position, this.transform.rotation);
            timeSinceLastSpawn = Time.time;
        }
        if(time - timeSinceLastSpawn > spawnInterval && rage == true)
        {
            Instantiate(enemy, this.transform.position, this.transform.rotation);
            Instantiate(suicidalEnemy, this.transform.position, this.transform.rotation);
            timeSinceLastSpawn = Time.time;
        }
    }
    private void OnDestroy()
    {
        if (this.GetComponent<EnemyProperties>().health <= 0)
        {
            playerBehavior.current.Health(4, this.transform.position);
            GlobalSceneManager.current.PlayerChangeScene();
        }
    }
}
