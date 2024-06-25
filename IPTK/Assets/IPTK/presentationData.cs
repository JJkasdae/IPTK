using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Presentation", menuName = "ImmersivePresentation/Presentation", order = 1)]
public class presentationData : ScriptableObject
{
    [SerializeField]
    private string _name = "Presentation Data";

    [SerializeField]
    [TextArea()]
    private string _description;

    [SerializeField]
    private string[] _timeline;

}
