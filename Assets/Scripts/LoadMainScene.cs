using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainScene : MonoBehaviour
{
    public float delay = 1.0f;
    private float _timeElapsed;

    void Start()
    {
        _timeElapsed = 0.0f;
    }
    
    void Update()
    {
        _timeElapsed += Time.deltaTime;
        if (Input.anyKey && _timeElapsed > delay)
        {
            SceneManager.LoadScene("Scenes/Main");
        }
    }
}
