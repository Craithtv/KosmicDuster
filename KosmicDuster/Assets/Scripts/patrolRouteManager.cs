using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class patrolRouteManager : MonoBehaviour
{
    public Transform waypoint1;
    public Transform waypoint2;
    public Transform waypoint3;
    public Transform waypoint4;
    public Transform waypoint5;
    public Transform waypoint6;

     public Transform[][] patrolRoutes;

    void Start()
{
        patrolRoutes = new Transform[][] {
        new Transform[] { waypoint1, waypoint2, waypoint3 }, // Flight path 1
        new Transform[] { waypoint4, waypoint5, waypoint6 }, // Flight path 2
        // Add more flight paths as needed...
    };
}

}
