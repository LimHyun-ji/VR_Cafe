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

    public int satisfaction;    // 좋음(1), 보통(0), 나쁨(-1)

    //메뉴
    //public GameObject Menu;
    public Text MenuText;
    int num;
    Vector3 menutarget = new Vector3(-3, 1f, 0);
    string[] menuList ={"아메리카노",
                            "라떼",
                            "카라멜 마끼야또",
                            "카페모카",
                            "레몬에이드",
                            "자몽에이드",
                            "딸기 스무디",
                            "망고 스무디",
                            "블루베리 스무디",
                            "햄 샌드위치",
                            "토스트",
                            "포테이토 샌드위치",
                            "훈제 연어 샌드위치" }; //13개
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


    //이모지
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
                    if (menu == "아메리카노")
                        Menu1.SetActive(false);
                    else if (menu == "라떼")
                        Menu2.SetActive(false);
                    else if (menu == "카라멜 마끼야또")
                        Menu3.SetActive(false);
                    else if (menu == "카페모카")
                        Menu4.SetActive(false);
                    else if (menu == "레몬에이드")
                        Menu5.SetActive(false);
                    else if (menu == "자몽에이드")
                        Menu6.SetActive(false);
                    else if (menu == "딸기 스무디")
                        Menu7.SetActive(false);
                    else if (menu == "망고 스무디")
                        Menu8.SetActive(false);
                    else if (menu == "블루베리 스무디")
                        Menu9.SetActive(false);
                    else if (menu == "햄 샌드위치")
                        Menu10.SetActive(false);
                    else if (menu == "토스트")
                        Menu11.SetActive(false);
                    else if (menu == "포테이토 샌드위치")
                        Menu12.SetActive(false);
                    else if (menu == "훈제 연어 샌드위치")
                        Menu13.SetActive(false);
                }
                else if ((int)second_time == 6)
                {
                    MenuText.text = "";
                    if (menu == "아메리카노")
                        Menu1.SetActive(true);
                    else if (menu == "라떼")
                        Menu2.SetActive(true);
                    else if (menu == "카라멜 마끼야또")
                        Menu3.SetActive(true);
                    else if (menu == "카페모카")
                        Menu4.SetActive(true);
                    else if (menu == "레몬에이드")
                        Menu5.SetActive(true);
                    else if (menu == "자몽에이드")
                        Menu6.SetActive(true);
                    else if (menu == "딸기 스무디")
                        Menu7.SetActive(true);
                    else if (menu == "망고 스무디")
                        Menu8.SetActive(true);
                    else if (menu == "블루베리 스무디")
                        Menu9.SetActive(true);
                    else if (menu == "햄 샌드위치")
                        Menu10.SetActive(true);
                    else if (menu == "토스트")
                        Menu11.SetActive(true);
                    else if (menu == "포테이토 샌드위치")
                        Menu12.SetActive(true);
                    else if (menu == "훈제 연어 샌드위치")
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
        Debug.Log("버튼 클릭");
        Debug.Log(second_time);
        GoodE.SetActive(false);
        NormalE.SetActive(false);
        BadE.SetActive(false);
        isGuest = "PRE_OUT";
        satisfaction = 1;
    }
}
