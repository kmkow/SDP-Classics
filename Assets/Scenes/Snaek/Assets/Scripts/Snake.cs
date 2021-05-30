using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
public class Snake : MonoBehaviour
{
    public TMP_Text GameOverText;
    Vector2 dir = Vector2.right;
    List<Transform> tail = new List<Transform>();
    bool ate = false;
    public GameObject tailPrefab; 

    // Start is called before the first frame update
    void Start()
    {
        
        GameOverText.gameObject.SetActive(false);
        Time.timeScale = 1;
        InvokeRepeating("Move", 0.15f, 0.15f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) && dir != Vector2.left)
            dir = Vector2.right;
        else if (Input.GetKey(KeyCode.DownArrow) && dir != Vector2.up)
            dir = Vector2.down;
        else if (Input.GetKey(KeyCode.LeftArrow) && dir != Vector2.right)
            dir = Vector2.left;
        else if (Input.GetKey(KeyCode.UpArrow) && dir != Vector2.down)
            dir = Vector2.up;
    }

    void Move()
    {
        Vector2 v = transform.position;

        transform.Translate(dir);

        if (ate==true)
        {
            GameObject g = (GameObject)Instantiate(tailPrefab, v, Quaternion.identity);
            tail.Insert(0, g.transform);
            ate = false;

        }

        else if (tail.Count > 0)
        {
            tail.Last().position = v;
            tail.Insert(0, tail.Last());
            tail.RemoveAt(tail.Count - 1);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.StartsWith("FoodPrefab"))
        {
            ate = true;
            Destroy(collision.gameObject);
            Score.scoreValue +=10; 
        }
        else if (collision.name.StartsWith("border"))
        {
            GameOver();
        }

        else if (collision.CompareTag("tail"))
        {
            GameOver();
        }


    }

    void GameOver()
    {
        GameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
       
    }

}
