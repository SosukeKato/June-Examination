using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeSceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SceneChangeTimer");
    }

    IEnumerator SceneChangeTimer()
    {
        yield return new WaitForSeconds(180);
        SceneManager.LoadScene("ClearScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
