using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipGlide : MonoBehaviour
{
    [SerializeField]
    public float rotationSpeed = 50f;    // Speed of rotation

    [SerializeField]
    public float glideSpeed = 5f;        // Speed of movement across a path

    [SerializeField]
    public float orbitRadius = 10f;      // Distance from the center of its orbit


    public Vector3 centerPoint = Vector3.zero;  // The point around which it orbits

    private float angle = 0f;

    void Update()
    {
        // Update angle over time to make it orbit the center point
        angle += glideSpeed * Time.deltaTime;

        // Calculate the new position based on circular movement
        Vector3 offset = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle)) * orbitRadius;
        transform.position = centerPoint + offset;

        // Apply rotation to make the spaceship look like it's rotating
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
