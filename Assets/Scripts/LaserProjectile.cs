using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserProjectile : MonoBehaviour
{

    public float speed = 10;
    private float maxBound = 20;
    private float minBound = -20;

    private GameObject player = null;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        if (transform.position.x > maxBound || transform.position.x < minBound)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            if (player != null) player.GetComponent<Score>().score++;
        }
        Destroy(gameObject);
    }
}
