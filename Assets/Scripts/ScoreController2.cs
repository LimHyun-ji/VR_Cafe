using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController2 : MonoBehaviour
{
    public GameObject potato;
    public GameObject salmon;
    public GameObject cheese;
    public GameObject ham;
    public GameObject leaf;
    public GameObject egg;

    public PlayerController playerController;
    public GuestController guestController;

    void Update()
    {
        /*
        Collider[] colls = Physics.OverlapBox(
            GetComponent<BoxCollider>().center + transform.parent.position,
            GetComponent<BoxCollider>().size / 2,
            Quaternion.identity);

        for (int i = 0; i < colls.Length; i++)
        {

            if (guestController.menu == "훈제 연어 샌드위치" && colls[i].gameObject.tag.Equals("seasame_bread"))
            {
                for (int j = 0; j < colls.Length; j++)
                {
                    if (colls[j].gameObject.tag.Equals("salmon"))
                    {
                        for (int k = 0; k < colls.Length; k++)
                        {
                            if (colls[k].gameObject.tag.Equals("egg"))
                            {
                                for (int l = 0; l < colls.Length; l++)
                                {
                                    if (colls[k].gameObject.tag.Equals("cheese"))
                                    {
                                        for (int h = 0; h < colls.Length; h++)
                                        {
                                            if (colls[h].gameObject.tag.Equals("leaf"))
                                            {     
                                                CountFood();
                                                        //Reposition();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            else if (guestController.menu == "햄 샌드위치" && colls[i].gameObject.tag.Equals("bread"))
            {
                for (int j = 0; j < colls.Length; j++)
                {
                    if (colls[j].gameObject.tag.Equals("bread2"))
                    {
                        for (int k = 0; k < colls.Length; k++)
                        {
                            if (colls[k].gameObject.tag.Equals("ham"))
                            {
                                for (int l = 0; l < colls.Length; l++)
                                {
                                    if (colls[k].gameObject.tag.Equals("cheese"))
                                    {
                                        for (int h = 0; h < colls.Length; h++)
                                        {
                                            if (colls[h].gameObject.tag.Equals("leaf"))
                                            {   
                                                CountFood();
                                                //Reposition();

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            else if (guestController.menu == "토스트" && colls[i].gameObject.tag.Equals("bread"))
            {
                for (int j = 0; j < colls.Length; j++)
                {
                    if (colls[j].gameObject.tag.Equals("ham"))
                    {
                        for (int k = 0; k < colls.Length; k++)
                        {
                            if (colls[k].gameObject.tag.Equals("egg"))
                            {
                                CountFood();
                                //Reposition();
                            }
                        }
                    }
                }
            }

            else if (guestController.menu == "포테이토 샌드위치" && colls[i].gameObject.tag.Equals("seasame_bread"))
            {
                for (int j = 0; j < colls.Length; j++)
                {
                    if (colls[j].gameObject.tag.Equals("leaf"))
                    {
                        for (int k = 0; k < colls.Length; k++)
                        {
                            if (colls[k].gameObject.tag.Equals("egg"))
                            {
                                for (int l = 0; l < colls.Length; l++)
                                {
                                    if (colls[k].gameObject.tag.Equals("potato"))
                                    {
                                        for (int h = 0; h < colls.Length; h++)
                                        {
                                            CountFood();
                                            //Reposition();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        */
    }

    void Reposition()
    {
        Destroy(potato);
        Destroy(salmon);
        Destroy(cheese);
        Destroy(ham);
        Destroy(leaf);
        Destroy(egg);
    }

    void OnTriggerEnter(Collider other)
    {
        if (guestController.menu == "훈제 연어 샌드위치" && other.gameObject.tag.Equals("salmon"))
        {
            CountFood();
            //Reposition();
        }
        else if (guestController.menu == "햄 샌드위치" && other.gameObject.tag.Equals("ham"))
        {
            CountFood();
            //Reposition();
        }
        else if(guestController.menu == "토스트" && other.gameObject.tag.Equals("egg"))
        {
            CountFood();
            //Reposition();
        }
        else if (guestController.menu == "포테이토 샌드위치" && other.gameObject.tag.Equals("potato"))
        {
            CountFood();
            //Reposition();
        }
    }

    void CountFood()
    {
        if (guestController.satisfaction == 1)   // 만족도 좋음
            UIManager.Instance().score += 3000; // +3000
        else if (guestController.satisfaction == 0)  // 만족도 보통
            UIManager.Instance().score += 2500; // +2500
        else if (guestController.satisfaction == -1) // 만족도 나쁨
            UIManager.Instance().score += 2000; // +2000

        playerController.PlaySound();   // 점수 효과음
    }
}
