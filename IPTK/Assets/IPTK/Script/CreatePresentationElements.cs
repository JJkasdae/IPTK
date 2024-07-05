#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using System;
using System.IO;

public class CreatePresentationElements
{
    [MenuItem("PresentationData/Create sessions, transitions and scenes")]
    public static void CreateAllObjects()
    {
        Scene newScene = EditorSceneManager.NewScene(NewSceneSetup.DefaultGameObjects, NewSceneMode.Single);
        newScene.name = "NameScene";
        EditorSceneManager.SaveScene(newScene, "Assets/Presentation/NewScene.unity");
        AssetDatabase.SaveAssets();

        SessionData newSession = ScriptableObject.CreateInstance<SessionData>();
        AssetDatabase.CreateAsset(newSession, AssetDatabase.GenerateUniqueAssetPath("Assets/IPTK/Scriptable Objects/Sessions/Session_.asset"));
        AssetDatabase.SaveAssets();

        TransitionData newTransition = ScriptableObject.CreateInstance<TransitionData>();
        AssetDatabase.CreateAsset(newTransition, AssetDatabase.GenerateUniqueAssetPath("Assets/IPTK/Scriptable Objects/Transitions/Transition_.asset"));
        newTransition.initialize(newSession);
        EditorUtility.SetDirty(newTransition);
        AssetDatabase.SaveAssets();

        AssetDatabase.Refresh();        
    }
}

public class CreatePresentations
{
    private const string folderPath = "Assets/Data/PresentationObject";

    [MenuItem("PresentationData/Create a presentation")]
    public static void CreatePresentation()
    {
        // Check the folder is existed or not. Existed -> save the file to the folder. Not existed -> create a folder and save the file.
        CheckFolderExists(folderPath);

        // Create a presentation scriptable object
        PresentationData newPresentation = ScriptableObject.CreateInstance<PresentationData>();
        AssetDatabase.CreateAsset(newPresentation, AssetDatabase.GenerateUniqueAssetPath(Path.Combine(folderPath, "Presentation.asset")));
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    private static void CheckFolderExists(string folderPath)
    {
        if (string.IsNullOrEmpty(folderPath) || AssetDatabase.IsValidFolder(folderPath))
        {
            return;
        }

        // Get the parent folder path
        string parentFolder = Path.GetDirectoryName(folderPath);

        // If parent folder is not created, recursive in the parent folder and create a new folder.
        CheckFolderExists(parentFolder);

        // Create the required folder
        string newFoldername = Path.GetFileName(folderPath);
        AssetDatabase.CreateFolder(parentFolder, newFoldername);
    }
}

#endif
