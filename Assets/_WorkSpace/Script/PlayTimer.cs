using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayTimer : MonoBehaviour
{
    private float sec;
    private float min;
    private float hour;

    [SerializeField]
    TextMeshProUGUI dateTimeText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //タイマースタート
        sec += Time.deltaTime;
        //秒が60秒より上いったら
        if (sec > 60)
        {
            //秒を０にする
            sec = 0;
            //分を１プラスする
            min++;
        }
        //分が60を越したら
        if (min >= 60)
        {
            //分を０にする
            min = 0;
            //時を１プラスする
            hour++;
        }

        dateTimeText.text = hour.ToString("00") + ":" + min.ToString("00") + ":" + ((int)sec).ToString("00");
    }
}
