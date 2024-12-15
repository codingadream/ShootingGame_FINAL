using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    
    public static ScoreManager sManager;
    public int playerScore = 0;
    void Start()
    {
        sManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore(int Increase) { 
        playerScore += Increase;
    
    }

   
}
