using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector3 initialPosition; // To store the initial position of the projectile

    void Awake()
    {
        initialPosition = transform.position;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Calculate the distance from the initial position to the collision point
        float travelDistance = Vector3.Distance(initialPosition, transform.position);

        // Log the distance
        Debug.Log($"The Projectile traveled a distance of: {travelDistance} units.");

        Destroy(gameObject);
    }
}