using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float normalSpeed;
    private bool isInSlimePit = false;
    // Start is called before the first frame update
    void Start()
    {
        normalSpeed = speed;
    }

    // Update is called once per frame

    public float speed;
    public float rotationSpeed;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, mouseX * rotationSpeed, 0);

        // Handle movement input
        HandleMovement();
    }

    private void HandleMovement()
    {
        float moveSpeed = isInSlimePit ? normalSpeed * 0.5f : normalSpeed; // Adjust speed if in slime pit

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) { transform.Translate(0, 0, moveSpeed); }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) { transform.Translate(0, 0, -moveSpeed); }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { transform.Translate(-moveSpeed, 0, 0); }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) { transform.Translate(moveSpeed, 0, 0); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SlimePit")) // Check if the player enters a slime pit
        {
            isInSlimePit = true; // Set the flag to true
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SlimePit")) // Check if the player exits a slime pit
        {
            isInSlimePit = false; // Set the flag to false
        }
    }
}
