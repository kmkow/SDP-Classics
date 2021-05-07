using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Spawner : MonoBehaviour
{
    [SerializeField]
    private int _row;
    [SerializeField]
    private int _col;

    [SerializeField]
    GameObject[] enemies = new GameObject[1];

    [SerializeField]
    int rows = 5;
    List<GameObject> cols1 = new List<GameObject>();
    List<GameObject> cols2 = new List<GameObject>();
    List<GameObject> cols3 = new List<GameObject>();
    public float move = 0.5f;
    float leftmove = -0.5f;
    float rightmove = 0.5f;

    float faster = 0.1f;

    float xoldposcol;
    float yoldposrow;
   

    // Start is called before the first frame update
    void Start()
    {
        
        Level1();
        StartCoroutine("Movement");
        xoldposcol = transform.position.x;
        yoldposrow = transform.position.y;
        for (int i = 0; i < rows; i++)
        {
            xoldposcol = transform.position.x;
            for (int j = 0; j < 11; j++)
            {
                if (i == 0)
                {
                    var enemi = Instantiate(cols1[j], new Vector3(xoldposcol + 1f, yoldposrow, transform.position.z), Quaternion.identity);
                    xoldposcol = enemi.transform.position.x;
                    enemi.transform.parent = gameObject.transform;
                }
                if (i == 1)
                {
                    var enemi = Instantiate(cols1[j], new Vector3(xoldposcol + 1f, yoldposrow, transform.position.z), Quaternion.identity);
                    xoldposcol = enemi.transform.position.x;
                    enemi.transform.parent = gameObject.transform;
                }
                if (i == 2)
                {
                    var enemi = Instantiate(cols2[j], new Vector3(xoldposcol + 1f, yoldposrow, transform.position.z), Quaternion.identity);
                    xoldposcol = enemi.transform.position.x;
                    enemi.transform.parent = gameObject.transform;
                }
                if (i == 3)
                {
                    var enemi = Instantiate(cols3[j], new Vector3(xoldposcol + 1f, yoldposrow, transform.position.z), Quaternion.identity);
                    xoldposcol = enemi.transform.position.x;
                    enemi.transform.parent = gameObject.transform;
                }



            }
            yoldposrow += 0.7f;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Level1()
    {
        for (int i = 0; i < 11; i++)
        {
            cols1.Add(enemies[0]);
            cols2.Add(enemies[1]);
            cols3.Add(enemies[2]);
        }
        
    }
    public void RightBord()
    {
        
        ChMoveLeft();
        if (faster < 1.9f)
        {
            faster += 0.2f;
        }
       
        transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y - 0.5f, transform.position.z);
        
    }
    public void LeftBord()
    {
        
        ChMoveRight();
        if (faster <= 1.8f)
        {
            faster += 0.2f;
        }

        
        transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y - 0.5f, transform.position.z);
        
    }

    void ChMoveLeft()
    {

        move = leftmove;
        
    }
    void ChMoveRight()
    {
        move = rightmove;
    }

    private IEnumerator Movement()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.1f -faster );
            transform.position = new Vector3(transform.position.x + move, transform.position.y, transform.position.z);

        }

    }

}
