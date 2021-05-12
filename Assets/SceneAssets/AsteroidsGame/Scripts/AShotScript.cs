using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AShotScript : MonoBehaviour
{
    bool abroad = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(0, 10f * Time.deltaTime,0);

        Borders();
       
    }
    void Borders()
    {
        if (transform.position.x < -10.54f && abroad == false)
        {
            transform.position = new Vector3(10.54f, transform.position.y, transform.position.z);
            abroad = true;
        }
        if (transform.position.x < -10.54f && abroad == true)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.x > 10.54 && abroad == false)
        {
            transform.position = new Vector3(-10.54f, transform.position.y, transform.position.z);
            abroad = true;
        }

        if (transform.position.x > 10.54 && abroad == true)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.y > 7.20 && abroad == false)
        {
            transform.position = new Vector3(transform.position.x, -5.1f, transform.position.z);
            abroad = true;
        }

        if (transform.position.y > 7.20 && abroad == true)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.y < -5.1f && abroad == false)
        {
            transform.position = new Vector3(transform.position.x, 7.20f, transform.position.z);
            abroad = true;
        }
        if (transform.position.y < -5.1f && abroad == true)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
        }
        else
        {
            GameObject.Find("Canvas").GetComponent<ScoreScript>().score += 10;
            
            Destroy(this.gameObject);
        }
        
       
    }
   
}
