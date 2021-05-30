using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        AchievementManager.instance.Unlock("LPong");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w") && transform.position.y < 5.21f)
        {
            transform.Translate(0, 10 * Time.deltaTime, 0);
        }
        if (Input.GetKey("s") && transform.position.y > -3.35f)
        {
            transform.Translate(0, -10 * Time.deltaTime, 0);
        }
    }
}
