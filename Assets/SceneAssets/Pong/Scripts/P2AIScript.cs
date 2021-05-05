using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2AIScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ballPos = _ball.transform.position;
        Vector3 paddlePosition = this.transform.position;
        if ((paddlePosition.y > ballPos.y) && this.transform.position.y > -3.35f)
        {
            paddlePosition.y -= 0.25f;
        }
        else if ((paddlePosition.y <ballPos.y) && this.transform.position.y < 5.22)
        {
            paddlePosition.y += 0.025f;
        }

        transform.position = paddlePosition;
    }
}
