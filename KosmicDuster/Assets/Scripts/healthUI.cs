using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Movement;

public class healthUI : MonoBehaviour
{
    public float playerHealth;
    public float maxHealth;
    public PlayerMovement playerScript;
    public float chipSpeed = 2;
    private float lerpTimer;
    public Image frontHealthBar;
    public Image backHealthBar;
     
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth =  playerScript.playerHp;
        maxHealth = playerScript.maxHealth;
        UpdateHealthUi();
    }

    public void UpdateHealthUi(){

        float fillFront = frontHealthBar.fillAmount;
        float fillBack = backHealthBar.fillAmount;
        float healthFraction = playerHealth / maxHealth;

        if (fillBack > healthFraction){
            //lerpTimer = 0f;
            frontHealthBar.fillAmount = healthFraction;
            backHealthBar.color = Color.red;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / chipSpeed;
            backHealthBar.fillAmount = Mathf.Lerp(fillBack, healthFraction, percentComplete);
        }

        if (fillFront < healthFraction){
            backHealthBar.color = Color.green;
            backHealthBar.fillAmount = healthFraction;
            lerpTimer += Time.deltaTime;
            float percentComplete = lerpTimer / chipSpeed;
            frontHealthBar.fillAmount = Mathf.Lerp(fillFront, backHealthBar.fillAmount, percentComplete);
        }

    }
}
