using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitGame() 
    {

#if UNITY_EDITOR || UNITY_EDITOR_64 || UNITY_EDITOR_WIN
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif


    }
}
