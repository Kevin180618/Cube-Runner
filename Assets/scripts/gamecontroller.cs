using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    public GameObject gameoverpannel;
    public GameObject winp;
    public GameObject tts;
    public GameObject scoret;
    public GameObject stp;
    public GameObject sup;
    public GameObject sip;
    public GameObject inputf1;
    public GameObject inputf2;
    public GameObject inputf3;
    public GameObject inputf4;
    public playerscript pk;
    public GameObject lvl1;
    public GameObject lvl2;

    public void Start()
    {
        
        pausegame();
        pk.enabled = false;
        scoret.SetActive(false);
        tts.SetActive(true);
        pausegame();
        gameoverpannel.SetActive(false);
        winp.SetActive(false);
        pk.enabled = true;


    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)||Input.GetKeyDown(KeyCode.Space))
        {
            startgame();
        }
    }
    

    public void gameover()
    {
        scoret.SetActive(false);
        gameoverpannel.SetActive(true);
    }
    public void win()
    {
        scoret.SetActive(false);
        winp.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene("lvl 1");
    }
    public void quitgame()
    {
        Application.Quit();
    }
    public void pausegame()
    {
        Time.timeScale = 0f;

    }
    public void startgame()
    {
        scoret.SetActive(true);
        tts.SetActive(false);
        Time.timeScale = 1f;
    }
    public void next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }
}
