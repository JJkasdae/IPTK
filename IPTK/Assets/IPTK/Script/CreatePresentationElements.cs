using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class CreatePresentationElements
{
    [MenuItem("ScriptableObject/Create Session and Transition")]
    public static void CreateAllObjects()
    {
        SessionData newSession = ScriptableObject.CreateInstance<SessionData>();
        AssetDatabase.CreateAsset(newSession, AssetDatabase.GenerateUniqueAssetPath("Assets/IPTK/Scriptable Objects/Sessions/Session_.asset"));
        AssetDatabase.SaveAssets();

        TransitionData newTransition = ScriptableObject.CreateInstance<TransitionData>();
        AssetDatabase.CreateAsset(newTransition, AssetDatabase.GenerateUniqueAssetPath("Assets/IPTK/Scriptable Objects/Transitions/Transition_.asset"));
        newTransition.initialize(newSession);
        EditorUtility.SetDirty(newTransition);
        AssetDatabase.SaveAssets();

        Scene newScene = EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);
        newScene.name = "NameScene";
        EditorSceneManager.SaveScene(newScene, "Assets//IPTK/Scenes/NewScene.unity");
        AssetDatabase.SaveAssets();

        AssetDatabase.Refresh();        
    }
}
