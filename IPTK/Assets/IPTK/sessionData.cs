using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Session_", menuName = "ImmersivePresentation/Session", order = 2)]
public class sessionData : ScriptableObject
{
    [SerializeField]
    private string _name;

    [SerializeField]
    [TextArea()]
    private string _description;

    [SerializeField]
    private string _sceneName;
}
