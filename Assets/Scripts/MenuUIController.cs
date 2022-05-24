using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIController : MonoBehaviour
{
    Text text;
    public string menu = "";
    public string[] menuList ={"americano",
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
                            "toast" };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeText()
    {
        int randomNum = UnityEngine.Random.Range(0, menuList.Length());

        // 수정예정
       
    }
}
