using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    int satisfaction = 1;   // 만족도 좋음, 보통, 나쁨, 나감 (1, 0, -1, -2)

    void Update()
    {
        if (satisfaction == -2)  // 나가는 손님 발생
        {
            UIManager.Instance().score -= 1000;
        }

    }

    //카운터에 메뉴가 제공된 후
    void OnTriggerEnter(Collider other)
    {
        //제공해야 할 메뉴가 아메리카노
        if (other.gameObject.tag.Equals("coffee"))
        {
            // 음료 +2000
            UIManager.Instance().score += 2000;
        }

        //라떼

        //카라멜 마끼아또

        //카페모카

        //자몽에이드

        //망고에이드

        //딸기에이드

        //레몬에이드

        //블루베리에이드

        //훈제 연어 샌드위치

        //햄 샌드위치

        //토스트

        //포테이토 샌드위치
    }
}
