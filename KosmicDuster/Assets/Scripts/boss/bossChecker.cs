using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossChecker : MonoBehaviour
{

    public GameObject boss;
    public GameObject leaderboard;
   
    void Update()
    {
        if (boss == null)
        {
            leaderboard.SetActive(true);
        }
    }
}
