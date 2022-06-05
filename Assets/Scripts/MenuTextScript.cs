using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class MenuTextScript : MonoBehaviour
{
    public Text MenuText;
    public float time;
    int num;
    Vector3 target = new Vector3(-3, 1f, 0);
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

    private string[] emogiList ={"Bad", "Normal", "Good" };
    public List<Sprite> emogiImage;
    public Image emogi;
    public string state;

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


    // Start is called before the first frame update
    void Start()
    {
        Menu1.SetActive(false);
        Menu2.SetActive(false);
        Menu3.SetActive(false);
        Menu4.SetActive(false);
        Menu5.SetActive(false);
        Menu6.SetActive(false);
        Menu7.SetActive(false);
        Menu8.SetActive(false);
        Menu9.SetActive(false);
        Menu10.SetActive(false);
        Menu11.SetActive(false);
        Menu12.SetActive(false);
        Menu13.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        num = (int)time;
        string menu="";
        switch (num)
        {
            case 6:
                {
                    transform.position = Vector3.MoveTowards(transform.position, target, 0.05f);
                    //transform.Translate(Vector)
                    
                    break;
               
                }
            case 8:
                {
                    int index = Random.Range(0, 13);
                    menu = menuList[index];
                    MenuText.text = menu;
                    /*if (menu == "아메리카노")
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
                        Menu13.SetActive(true);*/
                    break;
                }

            case 12:
                {
                    MenuText.text = "";
                    Menu1.SetActive(false);
                    Menu2.SetActive(false);
                    Menu3.SetActive(false);
                    Menu4.SetActive(false);
                    Menu5.SetActive(false);
                    Menu6.SetActive(false);
                    Menu7.SetActive(false);
                    Menu8.SetActive(false);
                    Menu9.SetActive(false);
                    Menu10.SetActive(false);
                    Menu11.SetActive(false);
                    Menu12.SetActive(false);
                    Menu13.SetActive(false);
                    break;
                }
            
        }
        
    }

    /*void changeEmogi(string state)
    {
        int emogiNum = System.Array.IndexOf(emogiList, state);
        emogi.sprite = emogiImage[emogiNum];
    }*/
}
