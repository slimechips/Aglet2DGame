using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShootingBehavior : MonoBehaviour
{

    public static playerShootingBehavior current;
    AudioSource music;
    public AudioClip shootEffect;
    public AudioClip laserEffect;
    private GameObject currentProjectile;

    public GameObject playerProjectile;
    private float timeSinceLastShot;
    public float shootInterval = 0.5f;

    [SerializeField]
    public float maxProjectileBuffTimer = 20f;
    public string projectileBuffType;
    public float projectileBuffTime = 0f;
    public GameObject laserProjectile;

    public bool keydown = false;


    private void Awake()
    {
        playerBehavior player = playerBehavior.current;
        playerShootingBehavior.current = this;
        this.projectileBuffType = "none";
        currentProjectile = playerProjectile;
    }

    void Start()
    {
        timeSinceLastShot = Time.time;
        music = GetComponent<AudioSource>();
        music.clip = shootEffect;
    }

    void Update()
    {
        if (projectileBuffType == "none")
        {
            if (Time.time - timeSinceLastShot > shootInterval)
            {
                if (Input.GetKey(KeyCode.Mouse0) == true)
                {
                    Instantiate(currentProjectile, this.transform.position, this.transform.rotation);
                    timeSinceLastShot = Time.time;
                    music.clip = shootEffect;
                    music.Play();
                }
            }
        }
        else if (projectileBuffType == "laser")
        {
            if (Input.GetKeyDown(KeyCode.Mouse0) == true || keydown == true)
            {
                Instantiate(currentProjectile, this.transform.position, this.transform.rotation);
                music.clip = laserEffect;
                music.Play();
            }
            if(Input.GetKeyUp(KeyCode.Mouse0) == true)
            {
                music.Stop();
            }
        }
        else if (projectileBuffType == "wshot")
        {
            if (Time.time - timeSinceLastShot > shootInterval)
            {
                if (Input.GetKey(KeyCode.Mouse0) == true)
                {
                    Instantiate(currentProjectile, this.transform.position, this.transform.rotation);
                    Instantiate(currentProjectile, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, -45));
                    Instantiate(currentProjectile, this.transform.position, this.transform.rotation * Quaternion.Euler(0, 0, 45));
                    timeSinceLastShot = Time.time;
                    music.clip = shootEffect;
                    music.Play();
                }
            }
        }
        keydown = false;
    }
    public void UpgradeProjectile(string bufftype, float bufftime)
    {
        projectileBuffType = bufftype;
        projectileBuffTime = bufftime;
        if (projectileBuffType == "laser")
        {
            currentProjectile = laserProjectile;
        }
        else if (projectileBuffType == "wshot")
        {
            currentProjectile = playerProjectile;
        }
    }
    public void NoProjectileBuff()
    {
        currentProjectile = playerProjectile;
    }
}
