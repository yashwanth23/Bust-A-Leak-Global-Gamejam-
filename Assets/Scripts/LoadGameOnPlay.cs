using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class LoadGameOnPlay : MonoBehaviour {
    
    public string SceneName;
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneName);
    }
}
