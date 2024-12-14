using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public Transform LaunchPoint;
    public GameObject projectile;
    public float acceleration = 4f;
    public float initialVelocity = 4f;
    public float launchTime = 2f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Launch();
        }
    }

    private void Launch()
    {
   
        GameObject projectiles = Instantiate(projectile, LaunchPoint.position, LaunchPoint.rotation);

        Rigidbody rb = projectiles.GetComponent<Rigidbody>();

        if (rb != null)
        {
            // Calculate the displacement using the formula
            float Displacement = 0.5f * acceleration * launchTime * initialVelocity * launchTime;

            Vector3 launchDirection = LaunchPoint.up * Displacement;

            rb.velocity = launchDirection;

            rb.AddForce(launchDirection, ForceMode.Impulse);

        }
    }
}
