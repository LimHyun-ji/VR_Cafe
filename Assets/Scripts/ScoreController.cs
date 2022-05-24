using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    int score;  // 점수
    bool isRight = false;   // 레시피와 일치 여부
    int satisfaction = 1;   // 만족도 좋음, 보통, 나쁨, 나감 (1, 0, -1, -2)

    void Update()
    {
        if (satisfaction == -2)  // 나가는 손님 발생
        {
            score -= 1000;
        }
    }

    // 메뉴 제공된 후
    void Provided()
    {
        // 레시피 일치
        if (isRight)
        {
            if (satisfaction == 1)
            {
                // 음료 +2000
                score += 2000;

                // 샌드위치 +3000
                score += 3000;
            }

            else if (satisfaction == 0)
            {
                // 음료 +1500
                score += 1500;

                // 샌드위치 +2500
                score += 3000;
            }

            else
            {
                // 음료 +1000
                score += 1000;

                // 샌드위치 +2000
                score += 2000;
            }
        }
    }
}
