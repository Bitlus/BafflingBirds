using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 10.0f;
    
    void Update()
    {
        transform.position += Vector3.left * (speed * Time.deltaTime); 
    }
}
