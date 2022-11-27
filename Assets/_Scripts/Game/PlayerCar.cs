using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCar : Car
{
     private Vector3 _moveForce;
     #region Fields

     private float _lastFingerPositionX;
     private float _moveFactorX;
     private float _defaultMovementSpeed;
     

     private float _velocity;

    #endregion

     #region Unity Functions
    private void Update()
    {
         InputConfiguration();
         
         Move();
    }
    #endregion

  private void Move()
  {
    //Move
    _moveForce += transform.forward * (MoveSpeed * Time.deltaTime);
    transform.position += _moveForce * Time.deltaTime;
      
    //Steer
    var steerInput = _moveFactorX;
    transform.Rotate(Vector3.up * (steerInput * _moveForce.magnitude * SteerAngle * Time.deltaTime));

    _moveForce *= Drag;
    _moveForce = Vector3.ClampMagnitude(_moveForce, MaxSpeed);
  }
  
  private void InputConfiguration()
  {
    //Checks If the player is touching the screen or not
    if (Input.touchCount <= 0)return;
        
        
    switch ( Input.touches[0] )
    {
      case { phase: TouchPhase.Began }:
        _lastFingerPositionX = Input.touches[0].position.x;
        break;
      case { phase: TouchPhase.Moved }:
        _moveFactorX = (Vector3.right * (Input.touches[0].position.x - _lastFingerPositionX) / 1000).x;
        break;
      case { phase: TouchPhase.Ended }:
        _moveFactorX = 0f;
        break;
      case { phase: TouchPhase.Canceled }:
        _moveFactorX = 0f;
        break;
      case { phase: TouchPhase.Stationary }:
        break;
      default:
        return;
    }
  }

}
