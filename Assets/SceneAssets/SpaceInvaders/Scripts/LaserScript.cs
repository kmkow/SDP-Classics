using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LaserScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private ParticleSystem _emit;
    [SerializeField]
   private GameObject _enem;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 8f*Time.deltaTime, 0);
        if (transform.position.y > 6.3f)
        {
            Destroy(this.gameObject);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other)
        {
           
            if (other.CompareTag("enemy"))
                { BaseContainerScript.score += other.GetComponent<EnemA1Script>().EnemScore; }

            
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}
