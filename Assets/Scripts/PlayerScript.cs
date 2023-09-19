using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    public float xPadding = 0.4f;
    public float yPadding = 0.8f;
    float minX;
    float maxX;
    float minY;
    float maxY;

    void Start()
    {
        FindBoundaries();
    }

    void FindBoundaries(){
        Camera camera = Camera.main;
        minX = camera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + xPadding;
        maxX = camera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - xPadding;
        minY = camera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + yPadding;
        maxY = camera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - yPadding;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float deltaY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        float newX = Mathf.Clamp(transform.position.x + deltaX, minX, maxX);
        float newY = Mathf.Clamp(transform.position.y + deltaY, minY, maxY);

        transform.position = new Vector2(newX, newY);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.tag == "Alphabet")
      {
        Destroy(gameObject);
      }
    }
}
