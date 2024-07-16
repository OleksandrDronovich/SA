using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState 
{
    
    Playing,
        Pause
}

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    private GameState _state;

    public GameState State { get { return _state; } }

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        _state = GameState.Playing;    
    }

    public void OnPauseFunc() 
    {
        if (_state == GameState.Pause)
        {
            _state = GameState.Playing;
        }
        else
        {
            _state = GameState.Pause;
        }
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) 
        {
            OnPauseFunc();
        }    
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (_state == GameState.Playing)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        { 
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
