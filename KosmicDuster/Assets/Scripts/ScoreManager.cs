using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

namespace ScoreCounter
{
public class ScoreManager : MonoBehaviour
{
    public int currentScore;
    public int targetScore = 100;
    public TextMeshProUGUI score;
    public bool isBoss = false;

    string scoreKey = "Score";


    // Start is called before the first frame update
    void Awake()
    {
        currentScore = staticScore.highScore;
        
    }

    // Update is called once per frame
    void Update()
    {
        
       string scoreString = currentScore.ToString();
       score.text = scoreString;
       if(currentScore > targetScore && !isBoss)
       {
        targetScore = 99999;
        Debug.Log("score reached");
        staticScore.highScore = currentScore;
        isBoss = true;
        SceneManager.LoadScene("BossFight");
       }
    }
}
}
