using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false; // Disable gravity
        rb.isKinematic = false; // Ensure the bullet is affected by physics
        rb.velocity = transform.forward * 10f; // Set the initial forward speed (adjust as needed)
    }

    void Update()
    {
        // Optional: Add a small upward force to simulate floating
        rb.AddForce(Vector3.up * 0.1f); // Adjust the value for the desired floating effect
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //Start dissolve effect
            EnemyDissolve enemyDissolve = other.GetComponent<EnemyDissolve>();
            enemyDissolve.StartDissolve();

            // Destroy the enemy
            //Destroy(other.gameObject);

            // Destroy the bullet
            Destroy(gameObject);
           
        }

    }
}
