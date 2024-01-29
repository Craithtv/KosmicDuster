using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class bossRage : MonoBehaviour
{
    public int currentHp;
    public int rageThresh = 50;
    SpriteRenderer sprite;
    public boss_move boss_move;
    public enemyShooting enemyShooting;
    public GameObject boss;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        boss_move = boss.GetComponent<boss_move>();
        enemyShooting = boss.GetComponent<enemyShooting>();
    }

    // Update is called once per frame
    void Update()
    {
        currentHp = GetComponent<enemyCombat>().enemyHp;

        if (currentHp <= rageThresh)
        {
            //enemyShooting.nextFire = .33f;
            boss_move.moveSpeed = 6f;
            Debug.Log("Color change");
            sprite.color = Color.Lerp(Color.white, Color.red, 1);
        }

    }
}
