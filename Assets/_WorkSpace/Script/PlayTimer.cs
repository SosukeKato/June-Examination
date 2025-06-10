using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //秒
    private float sec;
    //分
    private float min;
    //時
    private float hour;
    //タイマーテキスト
    [SerializeField] Text dateTimeText;

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

        //タイマーをテキストに反映
        dateTimeText.text = hour.ToString("00") + ":" + min.ToString("00") + ":" + ((int)sec).ToString("00");
    }
}