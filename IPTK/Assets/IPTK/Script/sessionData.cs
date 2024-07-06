using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Session_", menuName = "ImmersivePresentation/Session", order = 2)]
public class SessionData : ScriptableObject
{
    [SerializeField]
    private string _name;

    [SerializeField]
    [TextArea()]
    private string _description;

    [SerializeField]
    private string _sceneName;

    public string sceneName => _sceneName;

    public void initialize(string sceneName)
    {
        _sceneName = sceneName;
    }
}
