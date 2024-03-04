using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void ChangeSceneNow(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    
}
