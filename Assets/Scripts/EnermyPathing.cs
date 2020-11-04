using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyPathing : MonoBehaviour
{
    [SerializeField] List<Transform> waypoints;
    [SerializeField] float moveSpeed = 2f;

    int waypointIndex = 0;
    private Vector3 targetPosition;
    private Vector3 currentPosition;
    private float stepThisFrame;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveAlongWaypointPath();
    }

    private void MoveAlongWaypointPath()
    {
        // check to see if the last waypoint has been reached
        if (waypointIndex <= waypoints.Count - 1)
        {
            // move towards target waypoint
            targetPosition = waypoints[waypointIndex].transform.position;
            stepThisFrame = moveSpeed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, stepThisFrame);
            // check to see if reached the waypoint
            if (transform.position == targetPosition)
            {   // increment waypoint
                waypointIndex++;
            }
        }
        else
        {// if you reached the last waypoint
            Destroy(gameObject);
        }
    }
}
