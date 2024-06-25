using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(presentationData))]
public class presentationDataEditor : Editor
{
    private SerializedProperty _name;
    private SerializedProperty _description;
    private SerializedProperty _timeline;

    private void OnEnable()
    {
        _name = serializedObject.FindProperty("_name");
        _description = serializedObject.FindProperty("_description");
        _timeline = serializedObject.FindProperty("_timeline");
    }

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        //EditorGUILayout.LabelField(_name.stringValue.ToUpper(), EditorStyles.boldLabel);
        //EditorGUILayout.Space(5);

        EditorGUILayout.LabelField("Presentation General Stats", EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(_name, new GUIContent("Name"));
        EditorGUILayout.PropertyField(_description, new GUIContent("Description"));
        EditorGUILayout.PropertyField(_timeline, new GUIContent("Timeline"));
    }
}
