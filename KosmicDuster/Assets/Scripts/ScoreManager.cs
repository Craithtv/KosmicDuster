using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace ScoreCounter
{
public class ScoreManager : MonoBehaviour
{
    public int currentScore = 0;
    public TextMeshProUGUI score;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       string scoreString = currentScore.ToString();
       score.text = scoreString;
    }
}
}
