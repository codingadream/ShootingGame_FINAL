using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update

    //public static ScoreManager instance;

    public int playerKillCount = 0;
    public int requiredKillsToWin = 20;
    public string loseSceneName = "LoseScreen"; 
    public string winSceneName = "WinScreen";

    private void OnEnable()
    {
        GameEvent.OnPlayerDeath += HandlePlayerDeath;
        GameEvent.OnPlayerWin += HandlePlayerWin;
    }

    private void OnDisable()
    {
        GameEvent.OnPlayerDeath -= HandlePlayerDeath;
        GameEvent.OnPlayerWin -= HandlePlayerWin;
    }

    public void AddKill()
    {
        playerKillCount++;
        if (playerKillCount >= requiredKillsToWin)
        {
            GameEvent.TriggerPlayerWin();
        }
    }

    private void HandlePlayerDeath()
    {
        SceneManager.LoadScene(loseSceneName);  // Load the lose scene
    }

    private void HandlePlayerWin()
    {
        SceneManager.LoadScene(winSceneName);  // Load the win scene
    }

    //public int amount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
