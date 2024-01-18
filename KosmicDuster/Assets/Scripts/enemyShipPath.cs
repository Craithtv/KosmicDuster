using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShipPath : MonoBehaviour
{
    public List<Transform> patrolPoints = new List<Transform>();
    public Transform endPoint;
    int currentPoint = 0;
    public float moveSpeed = 3;
    public float rotationSpeed = 5; // Adjust this value to control how fast the object rotates
    public float pointRadius = 1;
    public timeManager timeManager;
    public float pauseDuration;
    
    void Start()
{
    timeManager = FindObjectOfType<timeManager>();

}

    // Update is called once per frame
    void Update()
    {
        
        if (patrolPoints.Count == 0)
        {
            return; // Make sure there are patrol points before proceeding
        }

         if (!timeManager.isSlow)
         {

        Vector2 targetPosition = patrolPoints[currentPoint].position;
        Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);

        // Calculate the direction of movement (velocity) towards the next patrol point
        Vector2 direction = (currentPosition - targetPosition).normalized;

        // Move towards the target patrol point
        transform.position = Vector2.MoveTowards(currentPosition, targetPosition, moveSpeed * Time.deltaTime);

        // Apply rotation towards the direction of movement
        if (direction != Vector2.zero)
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion targetRotation = Quaternion.Euler(0, 0, angle - 90f); // Adjust -90f to handle sprite facing
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
        }

        // Check if the object has reached the target patrol point position
        if (Vector2.Distance(currentPosition, targetPosition) <= pointRadius)
        {
            // Object reached the current patrol point, move to the next one
            currentPoint++;

            if (currentPoint == patrolPoints.Count)
            {
                // Loop back to the first patrol point if the last one is reached
                //return;
                StartCoroutine(shipPauses());

            }
        }
         }
         
    IEnumerator shipPauses()
    {
        
        transform.rotation = Quaternion.Euler(0, 0, 0);
        yield return new WaitForSeconds(pauseDuration);

        // Add endPoint to the patrolPoints array
    
        patrolPoints.Add(endPoint);

        // Optionally, you can add more patrol points here

        // Move off screen
        Vector3 offScreenPosition = new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, offScreenPosition, moveSpeed * Time.deltaTime);
    }
    }
    
}
