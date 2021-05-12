using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustRotateScript : MonoBehaviour
{
    [SerializeField]
    private float tumble;
    public GameObject Container;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Random.InitState((int)System.DateTime.Now.Ticks);
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
        GetComponent<Rigidbody>().velocity = Random.insideUnitSphere * 2f;

    }

    // Update is called once per frame
    void Update()
    {
        Borders();
    
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
    private void OnDestroy()
    {
        Container.GetComponent<AsteroidsContainer>().currPartEnem--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("laser"))
        {
            Destroy(this.gameObject);
        }
    }
}
