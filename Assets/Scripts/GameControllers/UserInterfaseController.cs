using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInterfaseController : MonoBehaviour
{
    [SerializeField] GameObject _pauseUI;

    [SerializeField] GameObject _playingUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        _pauseUI.SetActive(GameController.Instance.State == GameState.Pause);
        _playingUI.SetActive(GameController.Instance.State == GameState.Playing);
    }
}
