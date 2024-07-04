using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Presentation", menuName = "ImmersivePresentation/Presentation", order = 1)]
public class PresentationData : ScriptableObject
{
    [SerializeField]
    private string _name = "Presentation Data";

    [SerializeField]
    [TextArea()]
    private string _description;

    //[SerializeField]
    //private SessionData[] _sessions;

    //[SerializeField]
    //private TransitionData[] _transitions;

    [SerializeField]
    private TimelineData _timeline;

    //public SessionData[] Sessions => _sessions;
    //public TransitionData[] Transitions => _transitions;
    public TimelineData Timeline => _timeline;
}
