using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainFunction : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField]
    private presentationData _presentationData;

    private int _currentSessionIndex = 0;
    private string _currentSceneName;

    void Start()
    {
        _currentSceneName = SceneManager.GetActiveScene().name; // Get the name of the current scene.

        for (int i = 0; i < _presentationData.Sessions.Length; i++) // Find the index of the current session through the current scene.
        {
            if (_presentationData.Sessions[i].sceneName == _currentSceneName)
            {
                _currentSessionIndex = i;
                break;
            }
        }

        Debug.Log(_presentationData.Sessions[_currentSessionIndex].sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        switchScene();
    }

    void switchScene()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && _currentSessionIndex < _presentationData.Sessions.Length - 1)
        {
            SceneManager.LoadScene(_presentationData.Sessions[_currentSessionIndex + 1].sceneName);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && _currentSessionIndex > 0)
        {
            SceneManager.LoadScene(_presentationData.Sessions[_currentSessionIndex - 1].sceneName);
        }
    }
}
