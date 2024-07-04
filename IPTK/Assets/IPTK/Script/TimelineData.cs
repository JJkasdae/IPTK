using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Timeline", menuName = "ImmersivePresentation/Timeline", order = 4)]
public class TimelineData : ScriptableObject
{
    [SerializeField]
    private TransitionData[] _transitionData;

    public TransitionData[] transitionData => _transitionData;
}
