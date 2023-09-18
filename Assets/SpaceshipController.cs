using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public Rigidbody2D rb;
    public Bullet bullet; 

    // Vector2 moveDirection;
    // Vector2 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal input (left or right arrow keys)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, 0.0f, 0.0f) * movementSpeed * Time.deltaTime;

        // Move the spaceship
        transform.Translate(movement);

        // if(Input.GetMouseButtonDown(0)){
        //     bullet.Fire();
        // }
    }
}
