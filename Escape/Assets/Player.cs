using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float _moveSpeed = 3f;

    void Movement()
    {
        Vector3 sidewaysMovementVector =  transform.right * Input.GetAxis("up1");
        Vector3 forwardAndBackwardMovementVector = transform.forward * Input.GetAxis("down1");
        Vector3 movementVector = sidewaysMovementVector + forwardAndBackwardMovementVector;
        
        GetComponent<CharacterController>().Move(movementVector * _moveSpeed * Time.deltaTime);
    }
}
