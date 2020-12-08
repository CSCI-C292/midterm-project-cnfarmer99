using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EscapeKey : MonoBehaviour
{
    Vector3 goal = new Vector3(-3.29999995f,-2.68000007f,-2f);

    float buffer = 1f;

    bool canEscape = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = gameObject.transform.position;

        if(currentPosition.x <= goal.x + buffer && currentPosition.x >= goal.x - buffer)
        {
            Debug.Log("Is in x param");
            if(currentPosition.y <= goal.y + buffer && currentPosition.y >= goal.y - buffer)
            {
                Debug.Log("Is in y param");
                canEscape = true;
            }
        }

        if(canEscape = true && Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("LevelTwo");
        }

    
    }
}
