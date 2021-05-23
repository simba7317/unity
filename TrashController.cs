using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrashController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
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
