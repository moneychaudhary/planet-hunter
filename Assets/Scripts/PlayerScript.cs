using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
	float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

	float newX = transform.position.x + deltaX;
        float newY = transform.position.y + deltaY;
  
	transform.position = new Vector2(newX, newY);  
    }
}
