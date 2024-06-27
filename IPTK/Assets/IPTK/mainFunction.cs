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

    private sessionData _currentSession;
    private int _currentSessionIndex;

    void Start()
    {
        _currentSessionIndex = 0;
        _currentSession = _presentationData.Sessions[0];
        Debug.Log(_currentSession.sceneName);
        //SceneManager.LoadScene(_currentSession.sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && Array.IndexOf(_presentationData.Sessions, _currentSession) < _presentationData.Sessions.Length - 1)
        {
            _currentSessionIndex++;
            _currentSession = _presentationData.Sessions[_currentSessionIndex];
            Debug.Log(_currentSession.sceneName);
            SceneManager.LoadScene(_currentSession.sceneName);
        }

    }
}
