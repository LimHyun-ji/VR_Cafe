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
                    /*if (menu == "�Ƹ޸�ī��")
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
