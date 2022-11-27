using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Car : MonoBehaviour
{
  [Range(10.0f, 100.0f)]
  [SerializeField] protected float MoveSpeed = 50f;
  
  [Range(10.0f, 30.0f)]
  [SerializeField] protected float MaxSpeed = 15f;
  
  [Range(0.0f, 2.0f)]
  [SerializeField] protected float Drag = .98f;

  [Range(10.0f, 30.0f)]
  [SerializeField] protected float SteerAngle = 20f;
}
