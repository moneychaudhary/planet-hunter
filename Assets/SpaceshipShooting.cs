using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipShooting : MonoBehaviour
{
    public Transform firePoint; // Transform representing the point from which bullets will be fired
    public GameObject bulletPrefab; // Prefab of the bullet

    public float fireRate = 0.5f; // Rate of fire (bullets per second)
    private float nextFireTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextFireTime)
        {
            Shoot(); // Call the shooting function
            nextFireTime = Time.time + 1f / fireRate; // Update the next allowed shot time
        }   
    }

    void Shoot()
    {
        // Create a new bullet from the prefab at the fire point's position and rotation
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
