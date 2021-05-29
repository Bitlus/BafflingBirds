using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    //variables

    public Vector3 startPos;
    public float widthRepeat;
    private float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        widthRepeat = GetComponent<BoxCollider>().size.x * 10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.position.x < startPos.x - widthRepeat)
        {
            transform.position = startPos;
        }
    }
}
