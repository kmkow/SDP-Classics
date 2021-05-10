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
        Random.InitState((int)System.DateTime.Now.Ticks);
        transform.position = new Vector3(-5.9f, 4f, 0f);
        var r = Random.Range(1.00f, 2.01f);
        if (r> 1.5)
        {
            move = leftmove;
        } 
        else if(r<1.5) move = rightmove;
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
       
        if (transform.childCount<1)
        {
            GameObject.Find("BaseContainer").GetComponent<BaseContainerScript>().SpawnerOff();
            Destroy(this.gameObject);
        }
       
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
     
    }
    public void LeftBord()
    {
        
        ChMoveRight();
   
    }

    void ChMoveLeft()
    {
        if (move>0)
        {
            move = leftmove;
            if (faster < 1.9f)
            {
                faster += 0.2f;
            }

            transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y - 0.5f, transform.position.z);

        }


    }
    void ChMoveRight()
    {

        if (move<0)
        {
            move = rightmove;
            if (faster <= 1.8f)
            {
                faster += 0.2f;
            }


            transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y - 0.5f, transform.position.z);

        }
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
