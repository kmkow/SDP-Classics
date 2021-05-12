using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyAsteroidScript : MonoBehaviour
{

     void Start()
    {

        
    }
    // Update is called once per frame
    void Update()
    {
        
        if (transform.childCount<1)
        {
            GameObject.Find("AsteroidContainer").GetComponent<AsteroidsContainer>().currEnem--;
            Destroy(this.gameObject);
        }
    }
}
