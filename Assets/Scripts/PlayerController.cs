using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public int Score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collided with {collision.collider.name}");
        KiwifruitCollectible collectable = collision.collider.GetComponent<KiwifruitCollectible>();
        if (collectable != null)
        {
            Score++;
            // Add Points
            GameObject.Destroy(collectable.gameObject);
        }
    }
}
