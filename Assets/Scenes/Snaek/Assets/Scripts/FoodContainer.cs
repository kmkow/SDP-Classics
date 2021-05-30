using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodContainer : MonoBehaviour
{
    public static bool spawnMoreFood = true;

    public bool GetSpawnMoreFood()
    {
        return spawnMoreFood;
    }
    void Start()
    {
        spawnMoreFood = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.childCount > 2)
        {
            spawnMoreFood = false;
        }
        else
        {
            spawnMoreFood = true;
        }
    }
}
