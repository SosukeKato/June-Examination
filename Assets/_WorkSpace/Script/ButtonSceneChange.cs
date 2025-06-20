using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonSceneChange : MonoBehaviour
{
    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}