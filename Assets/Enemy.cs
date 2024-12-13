using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //public ScoreManager scoreManager;
    [SerializeField] private ScoreManager scoreManager;

    public Transform player; // The target player the enemy will follow
    public float speed = 3f; // Speed at which the enemy moves

    void Start()
    {
        
        // Find the player by tag (assuming your player has the tag "Player")
        player = GameObject.FindGameObjectWithTag("Player").transform;

        
        if (scoreManager == null)
        {
            Debug.LogError("ScoreManager not found in the scene!");
        }
    }

    void Update()
    {
        if (player != null)
        {
            // Move towards the player
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    public void KillEnemy()
    {
        if (scoreManager != null)
        {
            scoreManager.AddKill(); // This should increment the kill count
            Debug.Log("Enemy killed. Kill count increased to: " + scoreManager.playerKillCount);
        }
        else
        {
            Debug.LogError("ScoreManager reference is missing in Enemy!");
        }

        // Destroy or deactivate enemy object
        Destroy(gameObject);
    }

}