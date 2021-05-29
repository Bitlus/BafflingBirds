using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOffScreen : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -20 || transform.position.x > 30)
        {
            Destroy(gameObject);
        }
    }
}
