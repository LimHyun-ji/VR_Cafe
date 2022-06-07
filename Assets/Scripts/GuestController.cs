using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GuestController : MonoBehaviour
{
    Vector3 start = new Vector3(-18, 1, 0);
    Vector3 target = new Vector3(-10, 1f, 0);
    string isGuest="NO";
    GameObject Guest1;
    string[] guestList ={"Guest1", "Guest2", "Guest3", "Guest4", "Guest5" };
    private GameObject[] GameObjectList;
    int index = 0;
    public float second_time = 0f;

    public int satisfaction;    // ����(1), ����(0), ����(-1)

    //�޴�
    //public GameObject Menu;
    public Text MenuText;
    int num;
    Vector3 menutarget = new Vector3(-3, 1f, 0);
    string[] menuList ={"�Ƹ޸�ī��",
                            "��",
                            "ī��� �����߶�",
                            "ī���ī",
                            "�����̵�",
                            "�ڸ����̵�",
                            "���� ������",
                            "���� ������",
                            "��纣�� ������",
                            "�� ������ġ",
                            "�佺Ʈ",
                            "�������� ������ġ",
                            "���� ���� ������ġ" }; //13��
    public GameObject Menu1;
    public GameObject Menu2;
    public GameObject Menu3;
    public GameObject Menu4;
    public GameObject Menu5;
    public GameObject Menu6;
    public GameObject Menu7;
    public GameObject Menu8;
    public GameObject Menu9;
    public GameObject Menu10;
    public GameObject Menu11;
    public GameObject Menu12;
    public GameObject Menu13;

    public string menu = "";


    //�̸���
    public GameObject Button;
    public GameObject GoodE;
    public GameObject NormalE;
    public GameObject BadE;

    void Awake()
    {
        satisfaction = 1;
    }

    void Update()

    {
        if (UIManager.Instance().isGamePlaying)
        {
            if (isGuest == "NO")
            {
                //GameObject newObj = Instantiate(GameObjectList[index], start, Quaternion.identity);
                Guest1 = transform.Find(guestList[index]).gameObject;
                Guest1.transform.localEulerAngles = new Vector3(0, 90, 0);
                Guest1.SetActive(true);

                second_time = Time.deltaTime;
                index = (index + 1) % 5;
                isGuest = "YES";
            }
            else if (isGuest == "YES")
            {
                second_time += Time.deltaTime;
                if (second_time > 40)
                {
                    Guest1.SetActive(false);
                    isGuest = "NO";
                    satisfaction = -2;
                }
                else if (second_time > 38)
                {
                    Guest1.transform.localEulerAngles = new Vector3(0, 270, 0);
                    Guest1.transform.position = Vector3.MoveTowards(Guest1.transform.position, start, 0.05f);
                    BadE.SetActive(false);
                }
                else if (second_time > 28)
                {
                    NormalE.SetActive(false);
                    BadE.SetActive(true);
                    satisfaction = -1;
                }
                else if (second_time > 18)
                {
                    GoodE.SetActive(false);
                    NormalE.SetActive(true);
                    satisfaction = 0;
                }
                else if (second_time > 8)
                {
                    satisfaction = 1;
                    GoodE.SetActive(true);
                    if (menu == "�Ƹ޸�ī��")
                        Menu1.SetActive(false);
                    else if (menu == "��")
                        Menu2.SetActive(false);
                    else if (menu == "ī��� �����߶�")
                        Menu3.SetActive(false);
                    else if (menu == "ī���ī")
                        Menu4.SetActive(false);
                    else if (menu == "�����̵�")
                        Menu5.SetActive(false);
                    else if (menu == "�ڸ����̵�")
                        Menu6.SetActive(false);
                    else if (menu == "���� ������")
                        Menu7.SetActive(false);
                    else if (menu == "���� ������")
                        Menu8.SetActive(false);
                    else if (menu == "��纣�� ������")
                        Menu9.SetActive(false);
                    else if (menu == "�� ������ġ")
                        Menu10.SetActive(false);
                    else if (menu == "�佺Ʈ")
                        Menu11.SetActive(false);
                    else if (menu == "�������� ������ġ")
                        Menu12.SetActive(false);
                    else if (menu == "���� ���� ������ġ")
                        Menu13.SetActive(false);
                }
                else if ((int)second_time == 6)
                {
                    MenuText.text = "";
                    if (menu == "�Ƹ޸�ī��")
                        Menu1.SetActive(true);
                    else if (menu == "��")
                        Menu2.SetActive(true);
                    else if (menu == "ī��� �����߶�")
                        Menu3.SetActive(true);
                    else if (menu == "ī���ī")
                        Menu4.SetActive(true);
                    else if (menu == "�����̵�")
                        Menu5.SetActive(true);
                    else if (menu == "�ڸ����̵�")
                        Menu6.SetActive(true);
                    else if (menu == "���� ������")
                        Menu7.SetActive(true);
                    else if (menu == "���� ������")
                        Menu8.SetActive(true);
                    else if (menu == "��纣�� ������")
                        Menu9.SetActive(true);
                    else if (menu == "�� ������ġ")
                        Menu10.SetActive(true);
                    else if (menu == "�佺Ʈ")
                        Menu11.SetActive(true);
                    else if (menu == "�������� ������ġ")
                        Menu12.SetActive(true);
                    else if (menu == "���� ���� ������ġ")
                        Menu13.SetActive(true);
                }
                else if ((int)second_time == 4)
                {
                    int i = Random.Range(0, 13);
                    menu = menuList[i];
                    MenuText.text = menu;

                }

                else if (second_time > 2)
                {
                    Guest1.transform.position = Vector3.MoveTowards(Guest1.transform.position, target, 0.05f);
                }
            }
            else if (isGuest == "PRE_OUT")
            {
                second_time = Time.deltaTime;
                Guest1.transform.localEulerAngles = new Vector3(0, 270, 0);
                isGuest = "OUT";
            }
            else
            {
                Guest1.transform.position = Vector3.MoveTowards(Guest1.transform.position, start, 0.05f);
                second_time += Time.deltaTime;
                if (second_time > 2)
                {
                    isGuest = "NO";
                    Guest1.SetActive(false);
                }
            }



            /*time += Time.deltaTime;

            num = (int)time;
            switch (num)
            {
                case 7:
                    {
                        transform.position = Vector3.MoveTowards(transform.position, target, 0.05f);
                        //transform.Translate(Vector)
                        break;
                    }
                case 69:
                    {
                        transform.localEulerAngles = new Vector3(0, 270, 0);
                        transform.position = Vector3.MoveTowards(transform.position, start, 0.05f);
                        break;

                    }
            }
            */

        }

    }
    public void finish()
    {
        Debug.Log("��ư Ŭ��");
        Debug.Log(second_time);
        GoodE.SetActive(false);
        NormalE.SetActive(false);
        BadE.SetActive(false);
        isGuest = "PRE_OUT";
        satisfaction = 1;
    }
}
