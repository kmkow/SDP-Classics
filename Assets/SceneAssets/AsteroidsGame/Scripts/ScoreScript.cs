using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int lives;
    public int score;
    [SerializeField]
    TMP_Text GameOverText;
    [SerializeField]
    TMP_Text livesText;
    [SerializeField]
    TMP_Text scoreText;
    void Start()
    {
        GameOverText.gameObject.SetActive(false);
        lives = 3;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives:" +lives.ToString();
        scoreText.text = "Score: "+score.ToString();
        if (GameObject.FindWithTag("Player") == null)
        {
            GameOverText.gameObject.SetActive(true);
        }
    }
}
