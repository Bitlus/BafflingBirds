
using UnityEngine;
using UnityEngine.UI;

public class TextTest : MonoBehaviour
{
    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "Hello, world!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
