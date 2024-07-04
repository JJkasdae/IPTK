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
public class TransitionData : ScriptableObject
{
    private int _transitionID;

    [Header("Transition General Stats")]
    [SerializeField]
    private SessionData _lastSession;

    [SerializeField]
    private SessionData _nextSession;

    [SerializeField]
    private transitionEffectType _effect;

    [SerializeField]
    private bool _Effect;

    [SerializeField]
    private string _importEffectAnimation;

    public void initialize(SessionData sessionData)
    {
        _lastSession = sessionData;
        Debug.Log(_lastSession);
    }
    //public sessionData lastSession => _lastSession;
    //public sessionData nextSession => _nextSession;
    //public transitionEffectType effect => _effect;

}
