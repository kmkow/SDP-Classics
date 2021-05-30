using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text score;  

    // Start is called before the first frame update
    void Start()
    {
        
        scoreValue = 0;
        score = GetComponent<Text>();
        AchievementManager.instance.Unlock("LSnake");
    }

    // Update is called once per frame
    void Update()
    {
        
        score.text = "Score: " + scoreValue;
        if (scoreValue > 1999)
        {
            AchievementManager.instance.Unlock("SSnake2000");
        }
    }
}
