using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public GameObject americano;
    public GameObject mocha;
    public GameObject macchiato;
    public GameObject latte;

    Vector3 americanopos;
    Vector3 mochapos;
    Vector3 macchiatopos;
    Vector3 lattepos;

    int satisfaction = 1;   // 만족도 좋음, 보통, 나쁨, 나감 (1, 0, -1, -2)
    bool isRight = false;

    void Awake()
    {
        // 처음 컵 위치 저장
        americanopos = americano.transform.position;
        mochapos = mocha.transform.position;
        macchiatopos = macchiato.transform.position;
        lattepos = latte.transform.position;
    }

    void Update()
    {
        if (satisfaction == -2)  // 나가는 손님 발생
        {
            UIManager.Instance().score -= 1000; // -1000점
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //Collider[] colls = Physics.OverlapBox(transform.position, 10.0f);
        americano.transform.position = americanopos;    //원래 자리로
        latte.transform.position = lattepos;
        macchiato.transform.position = macchiatopos;
        mocha.transform.position = mochapos;


        //제공해야 할 메뉴가 아메리카노
        if (other.gameObject.tag.Equals("americano"))
        {
            UIManager.Instance().score += 2000; // 음료 +2000
            other.gameObject.SetActive(false);  // 액체 비움
        }

        //라떼
        if (other.gameObject.tag.Equals("latte"))
        {
            UIManager.Instance().score += 2000; // 음료 +2000
            other.gameObject.SetActive(false);
        }

        //카라멜 마끼아또
        if (other.gameObject.tag.Equals("macchiato"))
        {
            UIManager.Instance().score += 2000; // 음료 +2000
            other.gameObject.SetActive(false);
        }

        //카페모카
        if (other.gameObject.tag.Equals("mocha"))
        {
            UIManager.Instance().score += 2000; // 음료 +2000
            other.gameObject.SetActive(false);
        }

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
