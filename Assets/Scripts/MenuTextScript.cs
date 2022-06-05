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
    string[] menuList ={"americano",
                            "latte",
                            "caramel",
                            "choco",
                            "lemon",
                            "orange",
                            "strawberry",
                            "mango",
                            "blueberry",
                            "ham",
                            "salmon",
                            "potato",
                            "toast" }; //13°³

    private string[] emogiList ={"Bad", "Normal", "Good" };
    public List<Sprite> emogiImage;
    public Image emogi;
    public string state;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        num = (int)time;
        
        switch (num)
        {
            case 7:
                {
                    transform.position = Vector3.MoveTowards(transform.position, target, 0.05f);
                    //transform.Translate(Vector)
                    
                    break;
               
                }
            case 8:
                {
                    int index = Random.Range(0, 13);
                    string menu1 = menuList[index];
                    MenuText.text = menu1;
                    break;
                }
            case 10:
                {
                    MenuText.text = "";
                    break;
                }
            
        }
        
    }

    void changeEmogi(string state)
    {
        int emogiNum = System.Array.IndexOf(emogiList, state);
        emogi.sprite = emogiImage[emogiNum];
    }
}
