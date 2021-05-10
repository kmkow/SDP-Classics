using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemA1Script : MonoBehaviour
{
  


    [SerializeField]
    private GameObject _enemLaser;

    [SerializeField]
    public int EnemScore;

    GameObject parent;
  

    float nextFire = 3f;
    

    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.FindGameObjectWithTag("containerEnem");
        nextFire = Time.time + Random.Range(5f, 20f); 


    }

    // Update is called once per frame
    void Update()
    {
       
        if (Physics.Raycast(transform.position,Vector3.down, out RaycastHit hit))
        {
            if (!GameObject.FindGameObjectWithTag("enemy").transform.CompareTag(hit.transform.tag))
            {
                if (Time.time > nextFire)
                {
                    nextFire = Time.time + Random.Range(3f,10f);
                    Instantiate(
                    _enemLaser,
                    new Vector3(transform.position.x - 0.1f, transform.
                    position.y - 0.7f, 0f),
                    Quaternion.identity
                    );
                }

            }
           

        }
        if (Input.GetKey(KeyCode.Z))
        {
            Destroy(this.gameObject);
        }
       
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
            if (other.CompareTag("leftwall"))
            {
                parent.GetComponent<Enemy1Spawner>().LeftBord();
            }
            if (other.CompareTag("rightwall"))
            {
                parent.GetComponent<Enemy1Spawner>().RightBord();
            }
            
        
    }

}
