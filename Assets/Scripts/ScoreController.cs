using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    int satisfaction = 1;   // ������ ����, ����, ����, ���� (1, 0, -1, -2)

    void Update()
    {
        if (satisfaction == -2)  // ������ �մ� �߻�
        {
            UIManager.Instance().score -= 1000;
        }

    }

    //ī���Ϳ� �޴��� ������ ��
    void OnTriggerEnter(Collider other)
    {
        //�����ؾ� �� �޴��� �Ƹ޸�ī��
        if (other.gameObject.tag.Equals("coffee"))
        {
            // ���� +2000
            UIManager.Instance().score += 2000;
        }

        //��

        //ī��� �����ƶ�

        //ī���ī

        //�ڸ����̵�

        //�����̵�

        //���⿡�̵�

        //�����̵�

        //��纣�����̵�

        //���� ���� ������ġ

        //�� ������ġ

        //�佺Ʈ

        //�������� ������ġ
    }
}
