using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    
    public static ScoreManager sManager;
    public int playerScore = 0;
    public Text m_Text;
    public string display = "{0} Score";
    
    public Text timerText;

    [SerializeField] float RemainingTime;
    void Start()
    {
        sManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        m_Text.text = string.Format(display, playerScore.ToString());
        RemainingTime -= Time.deltaTime;
        timerText.text = RemainingTime.ToString();

        int minutes = Mathf.FloorToInt(RemainingTime / 60);
        int seconds = Mathf.FloorToInt(RemainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void IncreaseScore(int Increase) { 
        playerScore += Increase;
    
    }

   
}
