using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private float bulletSpeed;

    public Transform firePoint;
    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        // Create bullet at the firePoint position and rotation
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Apply velocity to the bullet (assuming it has a Rigidbody2D)
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = firePoint.right * bulletSpeed;
    }

    
}
