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
        //�^�C�}�[�X�^�[�g
        sec += Time.deltaTime;
        //�b��60�b���ア������
        if (sec > 60)
        {
            //�b���O�ɂ���
            sec = 0;
            //�����P�v���X����
            min++;
        }
        //����60���z������
        if (min >= 60)
        {
            //�����O�ɂ���
            min = 0;
            //�����P�v���X����
            hour++;
        }

        dateTimeText.text = hour.ToString("00") + ":" + min.ToString("00") + ":" + ((int)sec).ToString("00");
    }
}
