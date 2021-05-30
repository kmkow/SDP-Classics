using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2SMplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Paddle2;
    void Start()
    {
        if (PongPreGameScreen.SinglePlayer == true)
        {
            Paddle2.GetComponent<P2AIScript>().EnableSP();
            Paddle2.GetComponent<P2Script>().MPDisable();
        }
        else
        {
            Paddle2.GetComponent<P2AIScript>().DisableSP();
            Paddle2.GetComponent<P2Script>().MPEnable();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
