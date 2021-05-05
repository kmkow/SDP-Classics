using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotScript : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 4f * Time.deltaTime);
        if (transform.position.y<-4f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.name=="Player") { Destroy(other.gameObject); }
        if (other.transform.CompareTag("baseUnit")) { Destroy(other.gameObject); }
       
        Destroy(this.gameObject);
    }
}
