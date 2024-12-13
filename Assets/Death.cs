using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("DeathBlob"))
        {
            // Trigger the player death event
            GameEvent.TriggerPlayerDeath();
        }
    }
}
