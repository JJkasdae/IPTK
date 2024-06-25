using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//[CustomEditor(typeof(transitionData))]
public class transitionDataEditor : Editor
{
    private SerializedProperty _lastScene;
    private SerializedProperty _nextScene;
    private SerializedProperty _effect;

    private void OnEnable()
    {
        _lastScene = serializedObject.FindProperty("_lastScene");
        _nextScene = serializedObject.FindProperty("_nextScene");
        _effect = serializedObject.FindProperty("_effect");
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Transition General Stats", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(_lastScene, new GUIContent("Last Scene"));
        EditorGUILayout.PropertyField(_nextScene, new GUIContent("Next Scene"));
        EditorGUILayout.PropertyField(_effect, new GUIContent("Effect"));
    }
}
