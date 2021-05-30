using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2AIScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _ball;

    public static bool SPEnabled;
    public void EnableSP()
    {
        SPEnabled = true;
    }
    public void DisableSP()
    {
        SPEnabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SPEnabled)
        {
            Vector3 ballPos = _ball.transform.position;
            Vector3 paddlePosition = this.transform.position;
            if ((paddlePosition.y > ballPos.y) && this.transform.position.y > -3.35f)
            {
                if (ballPos.x > 0f)
                {
                    paddlePosition.y -= (7f * Time.deltaTime);
                }
                
            }
            else if ((paddlePosition.y < ballPos.y) && this.transform.position.y < 5.22)
            {
                if (ballPos.x > 0f)
                {
                    paddlePosition.y += (7f * Time.deltaTime);
                }
               
            }

            transform.position = paddlePosition;
        }
      
    }
}
