using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BaseContainerScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TMP_Text gameOver;

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            gameOver.gameObject.SetActive(true);
        }
    }
}
