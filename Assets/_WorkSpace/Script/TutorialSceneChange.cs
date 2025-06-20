using UnityEngine;
using UnityEngine.SceneManagement;
public class TutorialSceneChange : MonoBehaviour
{
    [SerializeField]
    string _StageName;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(_StageName);
        }
    }
}