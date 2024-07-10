using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayData : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _nameText;

    [SerializeField]
    private TextMeshProUGUI _descriptionText;

    [SerializeField]
    private PresentationData _presentationData;

    private SessionData _sessionData;
    private string _currentSceneName;

    // Start is called before the first frame update
    void Start()
    {
        _currentSceneName = SceneManager.GetActiveScene().name;

        for (int i = 0; i < _presentationData.Timeline.transitionData.Length; i++)
        {
            if (_presentationData.Timeline.transitionData[i].lastSession.sceneName == _currentSceneName)
            {
                _sessionData = _presentationData.Timeline.transitionData[i].lastSession;
                break;
            }
        }

        if (_sessionData != null)
        {
            _nameText.text = _sessionData.Name;
            _descriptionText.text = _sessionData.Description;
        }
        else
        {
            Debug.Log("SessionData is not assigned");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
