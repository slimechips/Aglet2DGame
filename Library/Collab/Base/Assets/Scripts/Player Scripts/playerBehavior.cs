using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerBehavior : MonoBehaviour
{

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


    //Awake Function
    private void Awake()
    {
        playerBehavior.current = this;
        this.playerBuffTime = Time.time;
        this.playerSpeed = this.playerSpeedDefault;
        this.playerBuffType = "none";
        this.currentLife = this.startingLife;

    }

    //Use this for initialization
    void Start()
    {
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

        //WASD Movement
        if (Input.GetKey(KeyCode.D) == true) {direction.x += 1;}    //If D is pressed
        if (Input.GetKey(KeyCode.A) == true) {direction.x -= 1;}    //If A is prssed
        if (Input.GetKey(KeyCode.W)==true) {direction.y += 1;}  //If W is pressed
        if (Input.GetKey(KeyCode.S) == true) {direction.y -= 1;}    //If S is pressed
        if(this.gameObject.transform.position.y < GameObject.Find("Bounding Box").GetComponent<boundingBox>().ylowerlimit) { direction.y += 2; }
        if(this. gameObject.transform.position.y > GameObject.Find("Bounding Box").GetComponent<boundingBox>().yupperlimit) { direction.y -= 2; }
        if(this.gameObject.transform.position.x < GameObject.Find("Bounding Box").GetComponent<boundingBox>().xlowerlimit) { direction.x += 2; }
        if (this.gameObject.transform.position.x > GameObject.Find("Bounding Box").GetComponent<boundingBox>().xupperlimit) { direction.x -= 2; }
            direction = direction.normalized;   //Convert to unit vector
            this.transform.position += speed * direction;   //New position
 

    }

    //Increasing speed function
    public void IncreaseSpeed()
    {
        this.playerSpeed = 14f;
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
        //Insert code
    }
    //Health control function
    public void Health(int healthchange)
    {
        if (shield > 0)
        {
            shield--;
        }
        else
        {
            this.currentLife += healthchange;   //Updates health accordingly
            UIHealthBar.current.UpdateHealthBar(healthchange);  //Updates health bar UI
        }
        if (currentLife==0)
        {
            GoToGame();
        }
    }

    public void GoToGame()
    {
        SceneManager.LoadScene("Game Over");
    }
}
