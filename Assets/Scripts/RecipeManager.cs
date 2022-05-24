using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RecipeManager : MonoBehaviour
{
    public string menu="";
    private string[] menuList={"americano",
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
    public List<Sprite> recipeImage;  
    public Image recipe;  
    public bool isOrder;
    void Start()
    {
        
    }

    void Update()
    {
        if(isOrder)
        {
            SetRecipe();
        }
    }
    void SetRecipe()
    {
        int menuNum=System.Array.IndexOf(menuList, menu);
        recipe.sprite=recipeImage[menuNum];
    }
    
}
