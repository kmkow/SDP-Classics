using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteScript : MonoBehaviour
{
    [SerializeField]
    Sprite sp1;
    [SerializeField]
    Sprite sp2;
   
    public SpriteRenderer sr;

    bool sc=true;
    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        sr.sprite = sp1;
    }

    // Update is called once per frame
    void Update()
    {

        
       if (transform.hasChanged)
        {
            if (sr.sprite == sp1)
            {
                sr.sprite = sp2;
            }
            else sr.sprite = sp1;
            
            transform.hasChanged = false;
        }
       
    }

   


}
