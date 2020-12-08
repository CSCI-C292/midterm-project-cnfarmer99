using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float _moveSpeed = .3f;

    void Update()
    {
        Vector3 movement = new Vector3(0, 0, 0);
        
        if(Input.GetButtonDown("up1"))
        {
            movement.y = _moveSpeed * 1f;
        }

        if(Input.GetButtonDown("down1"))
        {
            movement.y = _moveSpeed * -1f;
        }

        if(Input.GetButtonDown("left1"))
        {
            movement.x = _moveSpeed * -1f;
        }

        if(Input.GetButtonDown("right1"))
        {
            movement.x = _moveSpeed * 1f;
        }

        gameObject.transform.position = gameObject.transform.position + movement;
    }
}
