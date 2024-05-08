// Roan Silver      Created: ~September        Last Edits: December 19, 2023
// Major Collaborator: Alexander Zotov on YouTube
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePath : MonoBehaviour
{
    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;
    
    public int waypointIndex = 0;

    public bool moveAllowed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = waypoints[0].transform.position;
        if (SceneController.counter == 1)
        {
            transform.position = waypoints[12].transform.position;
            waypointIndex = 12;
        } else if (SceneController.counter == 2)
        {
            transform.position = waypoints[23].transform.position;
            waypointIndex = 23;
        } else if (SceneController.counter == 3)
        {
            transform.position = waypoints[34].transform.position;
            waypointIndex = 34;
        } else if (SceneController.counter == 4)
        {
            transform.position = waypoints[45].transform.position;
            waypointIndex = 45;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (moveAllowed)
        {
            Move();
        }
    }
    
    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position,
                waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }

    public int getWaypointIndex() //NEW
    { //NEW
        return waypointIndex; //NEW
    } //NEW
}
