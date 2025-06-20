using UnityEngine;
using TMPro;

public class PlayTimer : MonoBehaviour
{
    float sec;
    float min;

    [SerializeField]
    TextMeshProUGUI dateTimeText;
    // Update is called once per frame
   void Update()
    {
        //ƒ^ƒCƒ}[ƒXƒ^[ƒg
        sec += Time.deltaTime;
        //•b‚ª60•b‚æ‚èã‚¢‚Á‚½‚ç
        if (sec > 60)
        {
            //•b‚ð‚O‚É‚·‚é
            sec = 0;
            GetComponent<AudioSource>().Play();
            //•ª‚ð‚Pƒvƒ‰ƒX‚·‚é
            min++;
        }
        dateTimeText.text = min.ToString("00") + ":" + ((int)sec).ToString("00");
    }
}
