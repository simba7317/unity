using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JellyController : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }
    }

    void OnCollisionEnter2D(Collision2D Col)
    {
        if (Col.gameObject.tag == "SHARK")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }

}
