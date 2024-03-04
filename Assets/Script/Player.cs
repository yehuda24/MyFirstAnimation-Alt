using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator playerAnimator;
    public GameObject rawImageVideo;
    public SceneHandler sh;

    private void Start()
    {
        rawImageVideo.SetActive(false);
    }
    public void playerAttack()
    {
        playerAnimator.SetTrigger("goAttack");
    }

    public void invokeVideo()
    {
        Invoke("playVideo", 2.0f);
    }

    public void playVideo()
    {
        rawImageVideo.SetActive(true);
    }
    
    public void CallChangeSceneAfterSeconds()
    {
        StartCoroutine("WaitAndChange");
    }
    IEnumerator WaitAndChange()
    {
        Debug.Log("called");
        yield return new WaitForSeconds(3.0f);
        sh.ChangeSceneNow("Credits");
    }
}
