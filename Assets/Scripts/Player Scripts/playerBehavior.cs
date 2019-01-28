using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerBehavior : MonoBehaviour
{

    AudioSource music;
    public AudioClip effect;

    //CURRENT
    public static playerBehavior current;

    //Player speed
    [SerializeField]
    private float playerSpeedDefault = 8f;
    public float playerSpeed;

    //Player buff
    [SerializeField]
    public float maxPlayerBuffTimer = 20f;
    public string playerBuffType;
    public float playerBuffTime;

    //PlayerShield
    public int shield = 0;

    //Life
    [SerializeField]
    private int startingLife = 3;
    public int currentLife;
    public bool invulnerable = false;


    //Awake Function
    private void Awake()
    {
        playerBehavior.current = this;
        this.playerBuffTime = Time.time;
        this.playerSpeed = this.playerSpeedDefault;
        this.playerBuffType = "none";
        if (GlobalSceneManager.save != true)
        {
            this.currentLife = this.startingLife;
        }
        else
        {
            this.currentLife = GlobalSceneManager.current.savedHealth;
        }

    }

    //Use this for initialization
    void Start()
    {
        music = GameObject.Find("PlayerHitSoundPlayer").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //Controls movement
        PlayerMove(this.playerSpeed * Time.deltaTime);  //Smooth Movement
    }

    private void PlayerMove(float speed)
    {
        Vector3 direction = new Vector3(0, 0, 0);   //Direction vector
        
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        if (this.gameObject.transform.position.y < GameObject.Find("Bounding Box").GetComponent<boundingBox>().ylowerlimit) { direction.y += 2; }
        if (this.gameObject.transform.position.y > GameObject.Find("Bounding Box").GetComponent<boundingBox>().yupperlimit) { direction.y -= 2; }
        if (this.gameObject.transform.position.x < GameObject.Find("Bounding Box").GetComponent<boundingBox>().xlowerlimit) { direction.x += 2; }
        if (this.gameObject.transform.position.x > GameObject.Find("Bounding Box").GetComponent<boundingBox>().xupperlimit) { direction.x -= 2; }


        //direction = direction.normalized;
        this.transform.position += speed * direction;
  
    }

    //Increasing speed function
    public void IncreaseSpeed()
    {
        this.playerSpeed = 12f;
    }
    //Return speed function
    public void ReturnSpeed()
    {
        this.playerSpeed = playerSpeedDefault;
    }
    //Apply Shield function
    public void ShieldUp()
    {
        this.shield = 3;
    }
    //Remove Shield function
    public void ShieldDown()
    {
        this.shield = 0;
    }
    //Health control function

    public float dmgcooldown = 1.0f;
    public float dmgtime;

    public void Health(int healthchange)
    {
        if (healthchange < 0 && invulnerable == false)
        {
            music.clip = effect;
            music.Play();
            if (shield > 0)
            {
                if (Time.time - this.dmgtime >= dmgcooldown)
                {
                    shield--;
                    this.dmgtime = Time.time;
                }

            }
            else if (Time.time - this.dmgtime >= dmgcooldown)
            {
                this.currentLife += healthchange;   //Updates health accordingly
                this.dmgtime = Time.time;
                UIHealthBar.current.UpdateHealthBar(healthchange);  //Updates health bar UI
                ComboTracker.current.Combo("reset");
            }
            if (currentLife <= 0)
            {
                GoToGame();
            }
        } else if (healthchange > 0)
        {

            this.currentLife += healthchange;
            UIHealthBar.current.UpdateHealthBar(healthchange);
        }
    }

    public void Health(int healthchange, Vector3 healthOrigin)
    {
        if (healthchange > 0)
        {
            this.currentLife += healthchange;
            UIHealthBar.current.UpdateHealthBar(healthchange, healthOrigin);
        }
    }
    public void GoToGame()
    {
        Destroy(PlayerScore.current.gameObject);
        GlobalSceneManager.current.ChangeScene("Game Over");
        GlobalSceneManager.save = false;
    }
    
}
