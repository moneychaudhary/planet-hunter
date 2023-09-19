using UnityEngine;

public class FallingAlphabet : MonoBehaviour
{
    public float fallSpeed = 2.0f;

    void Start()
    {
        // Set the initial position of the alphabet character at the top of the screen
        transform.position = new Vector3(Random.Range(-4f, 4f), 7f, 0f);
    }

    void Update()
    {
        // Move the alphabet character downwards due to gravity
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }
}