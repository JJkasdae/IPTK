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
    private int _transitionID;

    [Header("Transition General Stats")]
    [SerializeField]
    private sessionData _lastSession;

    [SerializeField]
    private sessionData _nextSession;

    [SerializeField]
    private transitionEffectType _effect;

    [SerializeField]
    private bool _Effect;

    [SerializeField]
    private string _importEffectAnimation;
    //public sessionData lastSession => _lastSession;
    //public sessionData nextSession => _nextSession;
    //public transitionEffectType effect => _effect;

}
