using UnityEngine;
using TMPro;

public class PlayTimer : MonoBehaviour
{
    float sec;
    float min;

    [SerializeField]
    TextMeshProUGUI dateTimeText;
    // Update is called once per frame
    public void Update()
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
        dateTimeText.text = min.ToString("00") + ":" + ((int)sec).ToString("00");
    }
}
