using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    [SerializeField]
    string _StageName;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad5))
        {
            SceneManager.LoadScene(_StageName);
        }
    }
}