using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreCounter;

public class enemyCombat : MonoBehaviour
{
    public int enemyHp;
    public float attackRadius;
    public ScoreManager scoreManager;
    public GameObject explosionVFX;
    public Transform currentPOS;

    public GameObject soundManager;
    public AudioClip death;
   
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        DeathCheck();

    }

    private void DeathCheck()
    {
        if (enemyHp <= 0)
        {   scoreManager = FindObjectOfType<ScoreManager>();
            AudioSource.PlayClipAtPoint (death, transform.position);
            scoreManager.currentScore++;
            Instantiate(explosionVFX, currentPOS.position, Quaternion.identity);
            Destroy(this.gameObject); 
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "bullet")
            {//only works for 1 damage bullets. refactor for charge shots
                enemyHp--;
                Destroy(other.gameObject);
            }
             if(other.gameObject.tag == "laser")
            {//only works for 1 damage bullets. refactor for charge shots
                enemyHp--;
            }
        
    }

    }
