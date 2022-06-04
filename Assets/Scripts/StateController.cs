using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    public GameObject Button;
    public GameObject GoodE;
    public GameObject NormalE;
    public GameObject BadE;
    public float time;
    int num;

    // Start is called before the first frame update
    void Start()
    {
        GoodE.SetActive(false);
        NormalE.SetActive(false);
        BadE.SetActive(false);
        Button.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        num = (int)time;
        if (num >= 70)
        {
            BadE.SetActive(false);
        }
        else if (num >= 50)
        {
            NormalE.SetActive(false);
            BadE.SetActive(true);
        }
        else if (num >= 30)
        {
            GoodE.SetActive(false);
            NormalE.SetActive(true);
        }
        else if (num >= 10)
        {
            GoodE.SetActive(true);
           
        }
        
       

    }
    
    public void finish()
    {
        
        
        Debug.Log("버튼 클릭");
        Debug.Log(time);
        Button.SetActive(false);
        GoodE.SetActive(false);
        NormalE.SetActive(false);
        BadE.SetActive(false);

    }
}
