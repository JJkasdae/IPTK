using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum transitionEffectType
{
    none,
    animation,
    fade
}
[CreateAssetMenu(fileName = "Transition_", menuName = "ImmersivePresentation/Transition", order = 3)]
public class transitionData : ScriptableObject
{
    [Header("Transition General Stats")]
    [SerializeField]
    private sessionData _lastSession;

    [SerializeField]
    private sessionData _nextSession;

    [SerializeField]
    private transitionEffectType _effect;

    //public sessionData lastSession => _lastSession;
    //public sessionData nextSession => _nextSession;
    //public transitionEffectType effect => _effect;

}
