using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    [SerializeField]
    string _StageName;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Keypad5))
        {
            SceneManager.LoadScene(_StageName);
        }
    }
}