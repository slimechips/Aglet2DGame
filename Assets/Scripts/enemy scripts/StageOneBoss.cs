using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageOneBoss : MonoBehaviour {

    private float timeSinceLastBullet;
    private float shootInterval = 2.0f;
    private float timeSinceLastSpawn;
    private float spawnInterval = 3.0f;
    public GameObject currentProjectile;
    public GameObject basicEnemy;

    private float horizontalSpeed = 6.0f;
    private float verticalSpeed = -3.0f;
    private int bossHealth = 600;
    [SerializeField]
    private GameObject stageOneBossHealthBar;
    public float rageHp = 300.0f;

    void Awake ()
    {
        this.GetComponent<EnemyProperties>().health = bossHealth;
        Instantiate(stageOneBossHealthBar, new Vector2(0, 7f), new Quaternion(0, 0 ,0, 0));
        timeSinceLastBullet = Time.time;
        timeSinceLastSpawn = Time.time;
    }

    void Update ()
    {
        //GameObject[] gameObjects;
        //gameObjects = GameObject.FindGameObjectsWithTag("enemy");
        /*if(gameObjects.Length == 0)
        {*/
        transform.Translate(1 * horizontalSpeed * Time.deltaTime, Time.deltaTime * verticalSpeed, 0);
        //}
        if(this.transform.position.y <3.0f)
        {
            verticalSpeed = 0.0f;
        }
        if (GameObject.Find("StageOneBoss(Clone)").transform.position.x > 8f)
        {
            horizontalSpeed = -6.0f;
        }
        if (GameObject.Find("StageOneBoss(Clone)").transform.position.x < -8f)
        {
            horizontalSpeed = 6.0f;
        }
        if(this.GetComponent<EnemyProperties>().health <= 300) //for rage mode, faster shooting rate
        {
            this.GetComponent<EnemyShootBullet>().timeBetweenBullets = 2.0f;
            spawnEnemy(Time.time);
            if(Time.time - timeSinceLastBullet > shootInterval)
            {
                GameObject TempBullet;
                TempBullet = Instantiate(currentProjectile, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, -45)) as GameObject;
                GameObject TempBullet1;
                TempBullet1 = Instantiate(currentProjectile, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, 45)) as GameObject;

                Rigidbody2D TempRigidbody;
                TempRigidbody = TempBullet.GetComponent<Rigidbody2D>();
                Rigidbody2D TempRigidbody1;
                TempRigidbody1 = TempBullet1.GetComponent<Rigidbody2D>();

                TempRigidbody.AddForce(-TempRigidbody.transform.up * 230f);
                TempRigidbody1.AddForce(-TempRigidbody1.transform.up * 230f);
                timeSinceLastBullet = Time.time;
            }
            
        }
    }
    private void OnDestroy()
    {
        if (this.GetComponent<EnemyProperties>().health <= 0)
        {
            playerBehavior.current.Health(3, this.transform.position);
            GlobalSceneManager.current.PlayerChangeScene();
        }
    }
    private void spawnEnemy(float time)
    {
        if(time - timeSinceLastSpawn > spawnInterval)
        {
            Instantiate(basicEnemy, this.transform.position, this.transform.rotation);
            timeSinceLastSpawn = Time.time;
        }
    }
}
