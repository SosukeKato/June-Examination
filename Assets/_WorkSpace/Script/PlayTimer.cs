using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayTimer : MonoBehaviour
{
    private float sec;
    private float min;
    private float hour;

    [SerializeField]
    Text dateTimeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        }
        //•ª‚ª60‚ð‰z‚µ‚½‚ç
        if (min >= 60)
        {
            //•ª‚ð‚O‚É‚·‚é
            min = 0;
            //Žž‚ð‚Pƒvƒ‰ƒX‚·‚é
            hour++;
        }

        dateTimeText.text = hour.ToString("00") + ":" + min.ToString("00") + ":" + ((int)sec).ToString("00");
    }
}
