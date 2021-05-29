using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Collider c;
    
    // Start is called before the first frame update
    void Start()
    {
        c = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collided!!!!");
    }
}
