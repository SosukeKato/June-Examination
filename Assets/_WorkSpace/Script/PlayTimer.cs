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
            //•ª‚ð‚Pƒvƒ‰ƒX‚·‚é
            min++;

            //•ª‚ª60‚ð‰z‚µ‚½‚ç
            if (min >= 60)
            {
                //•ª‚ð‚O‚É‚·‚é
                min = 0;
            }
        }
        dateTimeText.text = min.ToString("00") + ":" + ((int)sec).ToString("00");
    }
}
