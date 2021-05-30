using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f;
    public Vector2 dir = Vector2.zero;
    private DotsScript currentdot;
    
    // Start is called before the first frame update
    void Start()
    {
        DotsScript node = GetdotAtPosition(transform.localPosition);
        if (node != null)
        {
            currentdot = node;
        }
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        //Move();
        
    }
    void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dir = Vector2.left;
            MoveToNode(dir);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            dir = Vector2.right;
            MoveToNode(dir);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            dir = Vector2.up;
            MoveToNode(dir);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            dir = Vector2.down;
            MoveToNode(dir);
        }
    }
    void Move()
    {
        transform.localPosition += (Vector3)(dir * speed) * Time.deltaTime;
    }
    void MoveToNode(Vector2 dir)
    {
        Node moveToNode = CanMove(dir);
        if (moveToNode != null)
        {
            transform.localPosition = moveToNode.transform.position;
        }
        
    }
    Node CanMove(Vector2 d)
    {
        Node moveToNode = null;
        for (int i = 0; i < currentdot.neighbors.Length; i++)
        {
            if (currentdot.validDir [i] == d)
            {
                moveToNode = currentdot.neighbors[i];
                break;
            }
           
        }
        return moveToNode;
    }

   DotsScript GetdotAtPosition(Vector2 pos)
    {
        GameObject dot = GameObject.Find("GameBoard").GetComponent<GameBoardScript>().board[(int)pos.x, (int)pos.y];
        if (dot != null)
        {
            return dot.GetComponent<DotsScript>();
        }
        return null;
    }
    
}
