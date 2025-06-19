using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    [SerializeField]
    string _StageName;

    void Update()
    {
        if(Input.anyKeyDown)
        {
            SceneManager.LoadScene(_StageName);
        }
    }
}