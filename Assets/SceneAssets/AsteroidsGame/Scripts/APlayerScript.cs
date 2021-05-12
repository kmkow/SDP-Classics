using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class APlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float thrust = 10f;
    public float maxSpeed = 180f;

    [SerializeField]
    private GameObject Score;

    [SerializeField]
    GameObject shot;
    void Start()
    {
       
         rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Borders();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shot, transform.position, transform.rotation);
        }
       
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1 * Time.deltaTime * 200f), Space.Self);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, -1 * Time.deltaTime * 200f), Space.Self);
        }
        
        rb.AddRelativeForce(Vector3.up*Input.GetAxis("Vertical") * thrust, ForceMode.Force);
        
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
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
        if (other.gameObject.CompareTag("laser"))
        {

        }
        else
        {

            if (Score.GetComponent<ScoreScript>().lives >= 1)
            {
                Score.GetComponent<ScoreScript>().lives--;
                Score.GetComponent<ScoreScript>().score += 10;
                Destroy(other.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
                Time.timeScale = 0;
            }
        }
       
        
    }
}
