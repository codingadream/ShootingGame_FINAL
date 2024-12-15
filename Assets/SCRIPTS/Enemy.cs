using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    public Transform player; // The target player the enemy will follow
    public float speed = 3f; // Speed at which the enemy moves

    void Start()
    {
        
        // Find the player by tag (assuming your player has the tag "Player")
        player = GameObject.FindGameObjectWithTag("Player").transform;

        
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
       
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            ScoreManager.sManager.IncreaseScore(1);
        }
    }
}