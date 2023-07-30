using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ScoreCounter;

public class enemyCombat : MonoBehaviour
{
    [SerializeField] int enemyHp;
    public float attackRadius;
    public ScoreManager scoreManager;
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
            scoreManager.currentScore++;
            Destroy(this.gameObject); 
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
            if(other.gameObject.tag == "bullet")
            {//only works for 1 damage bullets. refactor for charge shots
                enemyHp--;
                Destroy(other.gameObject);
            }
        }

    }
