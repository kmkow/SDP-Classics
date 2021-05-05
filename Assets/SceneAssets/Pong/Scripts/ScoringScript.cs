using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringScript : MonoBehaviour
{

   
    public TMP_Text P1Sc;
    public TMP_Text P2Sc;


    public static int scorep1;
    public static int scorep2;
    // Start is called before the first frame update
    void Start()
    {
        scorep1 = 0;
        scorep2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        P1Sc.text = scorep1.ToString();
        P2Sc.text = scorep2.ToString();
    }

}