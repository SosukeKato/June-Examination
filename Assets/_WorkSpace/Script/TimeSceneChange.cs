using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeSceneChange : MonoBehaviour
{
    [SerializeField]
    string _sceneName;
    [SerializeField]
    int _SceneChangeTime = 180;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SceneChangeTimer());
    }

    IEnumerator SceneChangeTimer()
    {
        yield return new WaitForSeconds(_SceneChangeTime);
        SceneManager.LoadScene(_sceneName);
    }
}
