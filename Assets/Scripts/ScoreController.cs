using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    int score;  // ����
    bool isRight = false;   // �����ǿ� ��ġ ����
    int satisfaction = 1;   // ������ ����, ����, ����, ���� (1, 0, -1, -2)

    void Update()
    {
        if (satisfaction == -2)  // ������ �մ� �߻�
        {
            score -= 1000;
        }
    }

    // �޴� ������ ��
    void Provided()
    {
        // ������ ��ġ
        if (isRight)
        {
            if (satisfaction == 1)
            {
                // ���� +2000
                score += 2000;

                // ������ġ +3000
                score += 3000;
            }

            else if (satisfaction == 0)
            {
                // ���� +1500
                score += 1500;

                // ������ġ +2500
                score += 3000;
            }

            else
            {
                // ���� +1000
                score += 1000;

                // ������ġ +2000
                score += 2000;
            }
        }
    }
}
