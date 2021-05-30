using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoardScript : MonoBehaviour
{
    // Start is called before the first frame update
    private static int bWidth = 28;
    private static int bHeight = 36;

    public GameObject[,] board = new GameObject[bWidth, bHeight];
    void Start()
    {
        Object[] objects = GameObject.FindObjectsOfType(typeof(GameObject));
        foreach (GameObject o in objects)
        {
            Vector2 pos = o.transform.position;
            if (o.name != "PacMan")
            {
                board[(int)pos.x, (int)pos.y] = o;
            }
            else
            {
                Debug.Log("PacMan at " + pos);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
