using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserProjectile : MonoBehaviour
{

    public float speed = 10;
    private float maxBound = 10;
    private float minBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
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
}