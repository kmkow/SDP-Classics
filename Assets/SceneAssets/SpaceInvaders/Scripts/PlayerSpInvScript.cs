using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpInvScript : MonoBehaviour
{
    // Start is called before the first frame update
    float sboundary = 8;
    [SerializeField]
    private GameObject _shot;
    void Start()
    {
        this.transform.position = new Vector3(0f, -3.7f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.Translate(-4f * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(4f * Time.deltaTime, 0, 0);
        }
        if (transform.position.x < -sboundary)
        {
            transform.position = new Vector3(-sboundary, transform.position.y, transform.position.z);
        }
        if(transform.position.x > sboundary)
        {
            transform.position = new Vector3(sboundary, transform.position.y, transform.position.z);
        }
        //transform.Translate(Input.GetAxis("Horizontal") * 5f * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown("space"))
        {
            Instantiate(
           _shot,
           new Vector3(
           transform.position.x,
           transform.position.y+0.7f,
           -0.01f),
           Quaternion.identity
           );
        }

    }
}
