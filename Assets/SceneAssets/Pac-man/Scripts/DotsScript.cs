using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotsScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Node[] neighbors;
    public Vector2[] validDir;
    
    void Start()
    {
        for (int i = 0; i < neighbors.Length; i++)
        {
            Node neighbor = neighbors[i];
            Vector2 tempVector = neighbor.transform.localPosition - transform.localPosition;
        }
    }

  
}
