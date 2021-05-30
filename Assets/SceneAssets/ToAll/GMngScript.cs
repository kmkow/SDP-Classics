using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GMngScript : MonoBehaviour
{
    // Start is called before the first frame update
 
    void Start()
    {
      

        QualitySettings.vSyncCount = 1;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
        }

    }

}
