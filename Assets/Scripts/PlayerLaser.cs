using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaser : MonoBehaviour
{
    public GameObject laserPrefab;
    public float cooldown = 0.5f;
    public float _timeSinceLastShot;
    public AudioSource pewPew;

    // Start is called before the first frame update
    void Start()
    {
 
        _timeSinceLastShot = cooldown;
        //AudioSource 
    }
    
    // Update is called once per frame
    void Update()
    {
        _timeSinceLastShot += Time.deltaTime;
        
        if (_timeSinceLastShot > cooldown && Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(laserPrefab, transform.position, laserPrefab.transform.rotation);
            _timeSinceLastShot = 0.0f;
            pewPew.Play();

        }
    }
}
