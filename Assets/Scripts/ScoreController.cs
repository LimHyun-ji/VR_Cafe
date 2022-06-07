using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public GameObject americano;
    public GameObject mocha;
    public GameObject macchiato;
    public GameObject latte;
    public GameObject orangejuice;
    public GameObject lemonjuice;
    public GameObject strawberryjuice;
    public GameObject blueberryjuice;
    public GameObject mangojuice;

    Vector3 americanopos;
    Vector3 mochapos;
    Vector3 macchiatopos;
    Vector3 lattepos;
    Vector3 orangepos;
    Vector3 lemonpos;
    Vector3 strawberrypos;
    Vector3 blueberrypos;
    Vector3 mangopos;

    public FoodController f1;
    public FoodController f2;
    public FoodController f3;
    public FoodController f4;
    public FoodController f5;
    public FoodController f6;
    public FoodController f7;
    public FoodController f8;
    public FoodController f9;
    public PlayerController playerController;
    public GuestController guestController;

    void Awake()
    {
        // ó�� �� ��ġ ����
        americanopos = americano.transform.position;
        mochapos = mocha.transform.position;
        macchiatopos = macchiato.transform.position;
        lattepos = latte.transform.position;
        orangepos = orangejuice.transform.position;
        lemonpos = lemonjuice.transform.position;
        strawberrypos = strawberryjuice.transform.position;
        blueberrypos = blueberryjuice.transform.position;
        mangopos = mangojuice.transform.position;
    }

    void Update()
    {
        if (guestController.satisfaction == -2)
        {
            guestController.satisfaction = 1;
            UIManager.Instance().score -= 1000;    // ������ �մ� �߻�. -1000
            playerController.PlaySound();   // ���� ȿ����
        }

        /*
        Collider[] colls = Physics.OverlapBox(
            GetComponent<BoxCollider>().center + transform.parent.position,
            GetComponent<BoxCollider>().size / 2,
            Quaternion.identity);

        for (int i = 0; i < colls.Length; i++)
        {
            //�����ؾ� �� �޴��� �Ƹ޸�ī��
            if (guestController.menu == "�Ƹ޸�ī��" && colls[i].gameObject.tag.Equals("americano"))
            {
                CountDrink();
                Reposition();
                colls[i].gameObject.SetActive(false);
            }

            else if (guestController.menu == "��" && colls[i].gameObject.tag.Equals("latte"))
            {
                CountDrink();
                Reposition();
                colls[i].gameObject.SetActive(false);
            }

            else if (guestController.menu == "ī��� �����߶�" && colls[i].gameObject.tag.Equals("macchiato"))
            {
                for (int j = 0; j < colls.Length; j++)
                {
                    if (colls[j].gameObject.tag.Equals("caramel"))
                    {
                        CountDrink();
                        Reposition();
                        colls[i].gameObject.SetActive(false);
                        colls[j].gameObject.SetActive(false);
                    }
                }
            }

            else if (guestController.menu == "ī���ī" && colls[i].gameObject.tag.Equals("mocha"))
            {
                for (int j = 0; j < colls.Length; j++)
                {
                    if (colls[j].gameObject.tag.Equals("choco"))
                    {
                        CountDrink();
                        Reposition();
                        colls[i].gameObject.SetActive(false);
                        colls[j].gameObject.SetActive(false);
                    }
                }
            }

            else if (guestController.menu == "�ڸ����̵�" && colls[i].gameObject.tag.Equals("orangejuice"))
            {
                for (int j = 0; j < colls.Length; j++)
                {
                    if (colls[j].gameObject.tag.Equals("orange"))
                    {
                        CountDrink();
                        Reposition();
                        colls[i].gameObject.SetActive(false);
                        colls[j].gameObject.SetActive(false);
                    }
                }
            }

            else if (guestController.menu == "���� ������" && colls[i].gameObject.tag.Equals("mangojuice"))
            {
                for (int j = 0; j < colls.Length; j++)
                {
                    if (colls[j].gameObject.tag.Equals("mango"))
                    {
                        CountDrink();
                        Reposition();
                        colls[i].gameObject.SetActive(false);
                        colls[j].gameObject.SetActive(false);
                    }
                }
            }

            else if (guestController.menu == "���� ������" && colls[i].gameObject.tag.Equals("strawberryjuice"))
            {
                for (int j = 0; j < colls.Length; j++)
                {
                    if (colls[j].gameObject.tag.Equals("strawberry"))
                    {
                        CountDrink();
                        Reposition();
                        colls[i].gameObject.SetActive(false);
                        colls[j].gameObject.SetActive(false);
                    }
                }
            }

            else if (guestController.menu == "�����̵�" && colls[i].gameObject.tag.Equals("lemonjuice"))
            {
                for (int j = 0; j < colls.Length; j++)
                {
                    if (colls[j].gameObject.tag.Equals("lemon"))
                    {
                        CountDrink();
                        Reposition();
                        colls[i].gameObject.SetActive(false);
                        colls[j].gameObject.SetActive(false);
                    }
                }
            }

            else if (guestController.menu == "��纣�� ������" && colls[i].gameObject.tag.Equals("blueberryjuice"))
            {
                for (int j = 0; j < colls.Length; j++)
                {
                    if (colls[j].gameObject.tag.Equals("blueberry"))
                    {
                        CountDrink();
                        Reposition();
                        colls[i].gameObject.SetActive(false);
                        colls[j].gameObject.SetActive(false);
                    }
                }
            }
        }
        */
    }

    void OnTriggerEnter(Collider other)
    {
        if (guestController.menu == "�Ƹ޸�ī��" && other.gameObject.tag.Equals("americano"))
        {
            CountDrink();
            Reposition();
            other.gameObject.SetActive(false);
        }

        else if (guestController.menu == "��" && other.gameObject.tag.Equals("latte"))
        {
            CountDrink();
            Reposition();
            other.gameObject.SetActive(false);
        }

        else if (guestController.menu == "ī��� �����߶�" && other.gameObject.tag.Equals("macchiato"))
        {
            CountDrink();
            Reposition();
            other.gameObject.SetActive(false);
        }

        else if (guestController.menu == "ī���ī" && other.gameObject.tag.Equals("mocha"))
        {
            CountDrink();
            Reposition();
            other.gameObject.SetActive(false);
        }

        else if (guestController.menu == "�ڸ����̵�" && other.gameObject.tag.Equals("orangejuice"))
        {
            CountDrink();
            Reposition();
            other.gameObject.SetActive(false);
        }

        else if (guestController.menu == "���� ������" && other.gameObject.tag.Equals("mangojuice"))
        {
            CountDrink();
            Reposition();
            other.gameObject.SetActive(false);
        }

        else if (guestController.menu == "���� ������" && other.gameObject.tag.Equals("strawberryjuice"))
        {
            CountDrink();
            Reposition();
            other.gameObject.SetActive(false);
        }

        else if (guestController.menu == "�����̵�" && other.gameObject.tag.Equals("lemonjuice"))
        {
            CountDrink();
            Reposition();
            other.gameObject.SetActive(false);
        }

        else if (guestController.menu == "��纣�� ������" && other.gameObject.tag.Equals("blueberryjuice"))
        {
            CountDrink();
            Reposition();
            other.gameObject.SetActive(false);
        }
}
    void Reposition()
    {
        f1.isSelected = false;
        f2.isSelected = false;
        f3.isSelected = false;
        f4.isSelected = false;
        f5.isSelected = false;
        f6.isSelected = false;
        f7.isSelected = false;
        f8.isSelected = false;
        f9.isSelected = false;
        americano.transform.position = americanopos;
        latte.transform.position = lattepos;
        macchiato.transform.position = macchiatopos;
        mocha.transform.position = mochapos;
        orangejuice.transform.position = orangepos;
        lemonjuice.transform.position = lemonpos;
        strawberryjuice.transform.position = strawberrypos;
        blueberryjuice.transform.position = blueberrypos;
        mangojuice.transform.position = mangopos;
    }

    void CountDrink()
    {
        if (guestController.satisfaction == 1)   // ������ ����
            UIManager.Instance().score += 2000; // +2000
        else if (guestController.satisfaction == 0)  // ������ ����
            UIManager.Instance().score += 1500; // +1500
        else if (guestController.satisfaction == -1) // ������ ����
            UIManager.Instance().score += 1000; // +1000

        playerController.PlaySound();   // ���� ȿ����
    }
    
}
