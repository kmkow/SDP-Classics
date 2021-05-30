using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringScript : MonoBehaviour
{

   
    public TMP_Text P1Sc;
    public TMP_Text P2Sc;

    public TMP_Text P1WinText;
    public TMP_Text P2WinText;

    bool theAI = false;

    public static int scorep1;
    public static int scorep2;
    // Start is called before the first frame update
    void Start()
    {
        Random.InitState((int)System.DateTime.Now.Ticks);
        P1WinText.gameObject.SetActive(false);
        P2WinText.gameObject.SetActive(false);
        Time.timeScale = 1;
        scorep1 = 0;
        scorep2 = 0;
        if (GameObject.Find("AI"))
        {
            theAI = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (theAI && scorep1 == 10)
        {
            AchievementManager.instance.Unlock("WAIPong");
        }
        if (scorep1 == 10)
        {
            P1WinText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        if (scorep2 == 10)
        {
            P2WinText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        P1Sc.text = scorep1.ToString();
        P2Sc.text = scorep2.ToString();
    }

}