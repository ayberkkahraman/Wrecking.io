using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public delegate void OnGameEnd(bool state);
    public static OnGameEnd OnGameEndHandler;

    public enum State
    {
        Running,
        Finished
    }

    public State GameState;


    #region Init / DeInit
    public void Init()
    {
        GameState = State.Running;
    }

    public void DeInit()
    {
    }
    #endregion

    #region Unity Functions
    private void OnEnable()
    {
        Init();
    }

    private void OnDisable()
    {
       DeInit();
    }

    private void Update()
    {

    }
    #endregion

}
