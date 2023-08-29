using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMove : MonoBehaviour
{
    public float speed = 1.0f; // Adjust the speed as needed

    private void Update()
    {
        // Calculate the new Y position based on the speed and time
        float newY = transform.position.y - (speed * Time.deltaTime);

        // Create a new Vector3 with the updated Y position
        Vector3 newPosition = new Vector3(transform.position.x, newY, transform.position.z);

        // Update the object's position
        transform.position = newPosition;
    }
}
