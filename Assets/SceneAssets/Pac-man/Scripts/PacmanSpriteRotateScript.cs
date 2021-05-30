using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanSpriteRotateScript : MonoBehaviour
{
    [SerializeField]
    private Vector2 Dir;
    [SerializeField]
    GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        Dir = parent.GetComponent<PacMove>().dir;
    }

    // Update is called once per frame
    void Update()
    {
        
        Orient();
    }

    void Orient()
    {
        if (Dir == Vector2.left)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Dir == Vector2.right)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Dir == Vector2.up)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        if (Dir == Vector2.down)
        {
            transform.localScale = new Vector3(1, 1, 1);
            transform.localRotation = Quaternion.Euler(0, 0, 270);
        }
    }
}
