using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    float _moveSpeed = .3f;

    void Update()
    {
        Vector3 movement = new Vector3(0, 0, 0);
        //movement
        if(Input.GetButtonDown("up2"))
        {
            movement.y = _moveSpeed * 1f;
        }

        if(Input.GetButtonDown("down2"))
        {
            movement.y = _moveSpeed * -1f;
        }

        if(Input.GetButtonDown("left2"))
        {
            movement.x = _moveSpeed * -1f;
        }

        if(Input.GetButtonDown("right2"))
        {
            movement.x = _moveSpeed * 1f;
        }

        gameObject.transform.position = gameObject.transform.position + movement;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("collided");
    }
}
