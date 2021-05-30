using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PongPreGameScreen : MonoBehaviour
{
    [SerializeField]
    public static bool SinglePlayer = true;
    public Toggle toggle;
    public void SP()
    {

        if (toggle.isOn)
        {
            Debug.LogError("OFF");
            SinglePlayer = false;
        }
        if(toggle.isOn)
        {
            Debug.LogError("ON");
            SinglePlayer = true;

        }
    }
   

}
