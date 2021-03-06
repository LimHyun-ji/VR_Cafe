using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmogiController : MonoBehaviour
{
    public GameObject emogi;
    public Sprite GoodE;
    public Sprite NormalE;
    public Sprite BadE;
    public float time;
    int num;

    void Update()
    {
        time += Time.deltaTime;

        num = (int)time;
        if (num >= 28)
        {
            emogi.GetComponent<Image>().sprite = GoodE;
        }
        else if (num >= 48)
        {
            emogi.GetComponent<Image>().sprite = NormalE;

        }
        else if (num >= 68)
        {
            emogi.GetComponent<Image>().sprite = BadE;

        }
    }
}
