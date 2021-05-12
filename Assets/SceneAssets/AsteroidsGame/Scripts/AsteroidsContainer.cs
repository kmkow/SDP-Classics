using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsContainer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject asteroid;
    float spawnerTime = 0;
    public int maxEnem = 6;
    public int currEnem = 0;
    public int maxPartEnem = 12;
    public int currPartEnem = 0;
    void Start()
    {
        
        Random.InitState((int)System.DateTime.Now.Ticks);
        
            var enemy = Instantiate(asteroid, new Vector3(Random.Range(-10f, -5f), Random.Range(5f, 7f), 0), Quaternion.identity);
            enemy.transform.parent = gameObject.transform;
            currEnem++;
        
       
            var enemy1 = Instantiate(asteroid, new Vector3(Random.Range(-5f, 0f), Random.Range(5f, 7f), 0), Quaternion.identity);
            enemy1.transform.parent = gameObject.transform;
            currEnem++;
        
       
            var enemy2 = Instantiate(asteroid, new Vector3(Random.Range(0f, 5f), Random.Range(5f, 7f), 0), Quaternion.identity);
            enemy2.transform.parent = gameObject.transform;
            currEnem++;
        
       
            var enemy3 = Instantiate(asteroid, new Vector3(Random.Range(0f, 10f), Random.Range(-4f, -2f), 0), Quaternion.identity);
            enemy3.transform.parent = gameObject.transform;
            currEnem++;
        
        
            var enemy4 = Instantiate(asteroid, new Vector3(Random.Range(-10f, 0f), Random.Range(-4f, -2f), 0), Quaternion.identity);
            enemy4.transform.parent = gameObject.transform;
            currEnem++;
        


        StartCoroutine(nameof(spawner));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator spawner()
    {
        while (true)
        {

            yield return new WaitForSecondsRealtime(4.1f - spawnerTime);
            if (transform.childCount < 1)
            {
                var enemy = Instantiate(asteroid, new Vector3(Random.Range(-10f, -5f), Random.Range(5f, 7f), 0), Quaternion.identity);
                enemy.transform.parent = gameObject.transform;
                currEnem++;


                var enemy1 = Instantiate(asteroid, new Vector3(Random.Range(-5f, 0f), Random.Range(5f, 7f), 0), Quaternion.identity);
                enemy1.transform.parent = gameObject.transform;
                currEnem++;


                var enemy2 = Instantiate(asteroid, new Vector3(Random.Range(0f, 5f), Random.Range(5f, 7f), 0), Quaternion.identity);
                enemy2.transform.parent = gameObject.transform;
                currEnem++;


                var enemy3 = Instantiate(asteroid, new Vector3(Random.Range(0f, 10f), Random.Range(-4f, -2f), 0), Quaternion.identity);
                enemy3.transform.parent = gameObject.transform;
                currEnem++;


                var enemy4 = Instantiate(asteroid, new Vector3(Random.Range(-10f, 0f), Random.Range(-4f, -2f), 0), Quaternion.identity);
                enemy4.transform.parent = gameObject.transform;
                currEnem++;

            }

            if (spawnerTime < 2f)
            {
                spawnerTime += 0.01f;
            }

        }

    }
}
