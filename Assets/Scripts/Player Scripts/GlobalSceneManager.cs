using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalSceneManager : MonoBehaviour
{
    //
    public static GlobalSceneManager current;

    [SerializeField]
    private string[] scenelist;
    private int currentscene;

    private bool applicationquit = false;
    private bool translateup = false;

    //save data
    public static bool save;
    public int savedScore;
    public int savedHealth;

    private void Awake()
    {
        if (GlobalSceneManager.current != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            GlobalSceneManager.current = this;
        }
        currentscene = Array.IndexOf(scenelist, SceneManager.GetActiveScene().name);
    }

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {
        if(translateup == true)
        {
            if (playerBehavior.current.transform.position.y < Spawner.current.topenemyspawnzone)
            {
                boundingBox.current.yupperlimit = Spawner.current.topenemyspawnzone + 2f;
                playerBehavior.current.transform.Translate(0, playerBehavior.current.playerSpeed * Time.deltaTime, 0);
                playerBehavior.current.dmgtime = Time.time;
            }
            else if (applicationquit == false)
            {
                translateup = false;
                currentscene++;
                SceneManager.LoadScene(scenelist[currentscene]);
            }
        }
    }

    public void ChangeScene(string newSceneName)
    {
        if (applicationquit == false)
        {
            currentscene = Array.IndexOf(scenelist, newSceneName);
            SceneManager.LoadScene(newSceneName);
        }
    }

    public void PlayerChangeScene()
    {
        this.savedScore = PlayerScore.current.score;
        this.savedHealth = playerBehavior.current.currentLife;
        save = true;
        playerBehavior.current.invulnerable = true;
        translateup = true;
    }


    public void GotoGame()
    {

    }
    private void OnApplicationQuit()
    {
        applicationquit = true;
    }
}
