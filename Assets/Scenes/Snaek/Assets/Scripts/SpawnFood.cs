using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject foodPrefab;
    public GameObject FoodContainer;

    public Transform borderTop;
    public Transform borderBottom;
    public Transform borderLeft;
    public Transform borderRight;

    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 3, 4);
    }

    void Spawn()
    {
        int x = (int)Random.Range(borderLeft.position.x, borderRight.position.x);
        int y = (int)Random.Range(borderBottom.position.y, borderTop.position.y);
        if (FoodContainer.GetComponent<FoodContainer>().GetSpawnMoreFood())
        {
            var foodChild = Instantiate(foodPrefab, new Vector2(x, y), Quaternion.identity);
            foodChild.transform.parent = FoodContainer.transform;
        }
        
        
    }


}
