using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    [SerializeField]
    private float tumble;
    public float breakForce;


    public GameObject frac;
    GameObject frac2;

    void Start()
    {
      
        Random.InitState((int)System.DateTime.Now.Ticks);
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;

        GetComponent<Rigidbody>().velocity = Random.insideUnitSphere * 2f;
    }
     void Update()
    {
        Borders();
        
    }
   
    void BreaktheThing()
    {

        
            GameObject frac2 = Instantiate(frac, transform.position, transform.rotation);
      
        foreach (Rigidbody rb in frac2.GetComponentsInChildren<Rigidbody>())
        {
           
                Vector3 force = (rb.transform.position - transform.position + new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0)).normalized * breakForce;
                rb.AddForce(force);
                GameObject.Find("AsteroidContainer").GetComponent<AsteroidsContainer>().currPartEnem += 2;
            
           
        }
        GameObject.Find("AsteroidContainer").GetComponent<AsteroidsContainer>().currEnem += 2;
        Destroy(this.gameObject);

    }
    void Borders()
    {
        if (transform.position.x < -10.54f)
        {
            transform.position = new Vector3(10.54f, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 10.54)
        {
            transform.position = new Vector3(-10.54f, transform.position.y, transform.position.z);
        }
        if (transform.position.y > 7.20)
        {
            transform.position = new Vector3(transform.position.x, -5.1f, transform.position.z);
        }
        if (transform.position.y < -5.1f)
        {
            transform.position = new Vector3(transform.position.x, 7.20f, transform.position.z);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("laser"))
        {
            BreaktheThing();
        }
    }
}