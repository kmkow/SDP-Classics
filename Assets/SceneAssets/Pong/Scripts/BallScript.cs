using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidb = GetComponent<Rigidbody>();
        if (rigidb)
        {
            rigidb.freezeRotation = true;
        }
        StartCoroutine("Waitforit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Waitforit()
    {
        Rigidbody rigidb = GetComponent<Rigidbody>();
        yield return new WaitForSeconds(3);
        if (rigidb) 
        {
            rigidb.AddForce(Random.Range(5, 7), Random.Range(-4, -3), 0);
        }
    }
}
