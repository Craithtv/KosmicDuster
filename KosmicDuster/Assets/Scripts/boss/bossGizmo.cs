using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossGizmo : MonoBehaviour
{

    public Rigidbody2D rb;
    public float attackRange = 3;
    public GameObject[] bossGuns;
    public GameObject [] bossRageGuns;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject[] GetBossGuns()
    {
        return bossGuns;
    }

       private void OnDrawGizmos()
{
    Gizmos.color = Color.yellow;
    Gizmos.DrawWireSphere(rb.transform.position, radius: attackRange);
}
}
