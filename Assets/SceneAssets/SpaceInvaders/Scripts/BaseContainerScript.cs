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
    GameObject EnemyContainer;



    // Update is called once per frame
    void Update()
    {
        if (transform.childCount < 1 || GameObject.Find("Player") == null)
        {
            //lose
            gameOver.gameObject.SetActive(true);
        }

        if (EnemyContainer.transform.childCount <1 && GameObject.Find("Player") != null)
        {
            //win

        }

    }
}
