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

    int satisfaction = 1;   // ������ ����, ����, ����, ���� (1, 0, -1, -2)
    bool isRight = false;

    void Awake()
    {
        // ó�� �� ��ġ ����
        americanopos = americano.transform.position;
        mochapos = mocha.transform.position;
        macchiatopos = macchiato.transform.position;
        lattepos = latte.transform.position;
    }

    void Update()
    {
        if (satisfaction == -2)  // ������ �մ� �߻�
        {
            UIManager.Instance().score -= 1000; // -1000��
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //Collider[] colls = Physics.OverlapBox(transform.position, 10.0f);
        americano.transform.position = americanopos;    //���� �ڸ���
        latte.transform.position = lattepos;
        macchiato.transform.position = macchiatopos;
        mocha.transform.position = mochapos;


        //�����ؾ� �� �޴��� �Ƹ޸�ī��
        if (other.gameObject.tag.Equals("americano"))
        {
            UIManager.Instance().score += 2000; // ���� +2000
            other.gameObject.SetActive(false);  // ��ü ���
        }

        //��
        if (other.gameObject.tag.Equals("latte"))
        {
            UIManager.Instance().score += 2000; // ���� +2000
            other.gameObject.SetActive(false);
        }

        //ī��� �����ƶ�
        if (other.gameObject.tag.Equals("macchiato"))
        {
            UIManager.Instance().score += 2000; // ���� +2000
            other.gameObject.SetActive(false);
        }

        //ī���ī
        if (other.gameObject.tag.Equals("mocha"))
        {
            UIManager.Instance().score += 2000; // ���� +2000
            other.gameObject.SetActive(false);
        }

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
