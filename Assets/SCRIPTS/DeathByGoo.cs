using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathByGoo : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Destroy the enemy
            //Destroy(other.gameObject);

            GameEvent.TriggerPlayerDeath();

            // Destroy the bullet
            //Destroy(gameObject);
            Debug.Log("Player has been killed by goo!");
        }

    }
}
