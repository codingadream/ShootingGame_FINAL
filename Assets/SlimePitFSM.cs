using UnityEngine;

public class SlimePitFSM : MonoBehaviour
{
    public enum SlimePitState { Inactive, Active }
    public SlimePitState currentState = SlimePitState.Inactive;

    // Slowing factor
    public float slowDownFactor = 0.5f;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object is a player or alien
        if (other.CompareTag("Player") || other.CompareTag("Alien"))
        {
            ChangeState(SlimePitState.Active);
            // Call a method to slow down the player or alien
            SlowDown(other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Alien"))
        {
            ChangeState(SlimePitState.Inactive);
            // Call a method to restore normal movement speed
            RestoreSpeed(other);
        }
    }

    private void ChangeState(SlimePitState newState)
    {
        currentState = newState;
    }

    private void SlowDown(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // If the object is the player, get the Movement component
            var playerMovement = other.GetComponent<Movement>();
            if (playerMovement != null)
            {
                playerMovement.speed *= slowDownFactor;
            }
        }
        else if (other.CompareTag("Alien"))
        {
            // If the object is an alien, get the Enemy component
            var enemyMovement = other.GetComponent<Enemy>();
            if (enemyMovement != null)
            {
                enemyMovement.speed *= slowDownFactor;
            }
        }
    }

    private void RestoreSpeed(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Restore the player’s speed to normal
            var playerMovement = other.GetComponent<Movement>();
            if (playerMovement != null)
            {
                playerMovement.speed /= slowDownFactor;
            }
        }
        else if (other.CompareTag("Alien"))
        {
            // Restore the alien’s speed to normal
            var enemyMovement = other.GetComponent<Enemy>();
            if (enemyMovement != null)
            {
                enemyMovement.speed /= slowDownFactor;
            }
        }
    }
}