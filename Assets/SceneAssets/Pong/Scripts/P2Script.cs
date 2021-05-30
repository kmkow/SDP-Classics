using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Script : MonoBehaviour
{
    // Start is called before the first frame update
    public bool MPEnabled;
    public void MPEnable()
    {
        MPEnabled = true;
    }
    public void MPDisable()
    {
        MPEnabled = false;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MPEnabled)
        {
            if (Input.GetKey("up") && transform.position.y < 5.22f)
            {
                transform.Translate(0, 10 * Time.deltaTime, 0);
            }
            if (Input.GetKey("down") && transform.position.y > -3.35f)
            {
                transform.Translate(0, -10 * Time.deltaTime, 0);
            }
        }
      
    }
}
