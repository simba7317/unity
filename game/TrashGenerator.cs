using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashGenerator : MonoBehaviour
{
    public GameObject trashPrefab;
    float interval = 1.0f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > interval)
        {
            delta = 0;
            GameObject trash = Instantiate(trashPrefab);
            int x = Random.Range(-8, 9);
            trash.transform.position = new Vector3(x, 6, 0);
        }
    }
}
