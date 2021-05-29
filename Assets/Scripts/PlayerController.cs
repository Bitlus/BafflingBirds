using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Score score;

    void Start()
    {
        score = GetComponent<Score>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collided with {collision.collider.name}");
        KiwifruitCollectible collectable = collision.collider.GetComponent<KiwifruitCollectible>();
        if (collectable != null)
        {
            score.score++;
            // Add Points
            GameObject.Destroy(collectable.gameObject);
        }
    }
}
