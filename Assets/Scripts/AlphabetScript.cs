using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphabetScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 50f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
