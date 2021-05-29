using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    //variables

    public float speed = 5;
    public float EndPosition;
    public float ResetPosition;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if (transform.localPosition.x < EndPosition)
        {
            transform.localPosition = new Vector3(ResetPosition, transform.localPosition.y, transform.localPosition.z);
            //transform.position = startPos;
        }
    }
}
