using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph;
using UnityEngine;

public class bossRage : MonoBehaviour
{
    public int currentHp;
    public int rageThresh = 50;
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        currentHp = GetComponent<enemyCombat>().enemyHp;

        if (currentHp <= rageThresh)
        {
            GetComponent<Animator>().SetBool("isRaged", true);
            Debug.Log("Color change");
            sprite.color = Color.Lerp(Color.white, Color.red, 1);
        }

    }
}
