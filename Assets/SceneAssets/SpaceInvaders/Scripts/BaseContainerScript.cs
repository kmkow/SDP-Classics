using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BaseContainerScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TMP_Text gameOver;

    [SerializeField]
    private TMP_Text scoreText;
    [SerializeField]
    private TMP_Text livesText;
    [SerializeField]
    GameObject EnemyContainer;
    [SerializeField]
    GameObject Player;
    [SerializeField]
    private TMP_Text levelText;

    public bool isPlayerCreated = true;
    public bool isSpawnerCreated = true;

    public void PlayerOff()
    {
        isPlayerCreated = false;
    }
    //score/lives
    public static int score;
    public static int lives;
    public static int level;
    //gamestates
    public static int state;
    public const int PressStart = 1;
    public const int StartingPlay = 2;
    public const int GamePlay = 3;
    public const int Dying = 4;
    public const int GameOver = 5;
    public const int NextLevel = 6;

    public void SpawnerOff()
    {
        isSpawnerCreated = false;
        level++;
    }
    void GameInitialize()
    {
        score = 0;
        lives = 3;
        level = 0;
        state = PressStart;
        ResumeGame();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    void Start()
    {

        GameInitialize();
        AchievementManager.instance.Unlock("LSpaceInv");


    }
    // Update is called once per frame
    void Update()
    {
        if (transform.childCount < 1 || lives < 1)
        {
            //lose
            PauseGame();
            gameOver.gameObject.SetActive(true);

        }
        if (!isSpawnerCreated)
        {
            StartCoroutine(nameof(nextLevel));
        }


        if (!isPlayerCreated)
        {
            PauseGame();
            StartCoroutine(nameof(PlayerDown));
        }


        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
        levelText.text = "Level: " + level;

        if (score >2999)
        {
            AchievementManager.instance.Unlock("ScoreSI3000");
        }
    }
    IEnumerator PlayerDown()
    {
        yield return new WaitForSecondsRealtime(2f);

        if (lives > 0 && !isPlayerCreated)
        {
            Instantiate(Player, new Vector3(0, 0, 0), Quaternion.identity);
            isPlayerCreated = true;
            ResumeGame();
        }
    }
    IEnumerator nextLevel()
    {
        yield return new WaitForSecondsRealtime(2f);
        if (!isSpawnerCreated)
        {
            Instantiate(EnemyContainer, new Vector3(0, 0, 0), Quaternion.identity);

            isSpawnerCreated = true;
            ResumeGame();
        }

    }
}
