using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeManager : MonoBehaviour
{
    public string menu="";
    public List<GameObject> prefabFoods;
    public List<GameObject> recipeFoods;
    
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
        recipeFoods.Clear();
        if(menu=="americano")
        {
            recipeFoods.Add(prefabFoods[5]);
            recipeFoods.Add(prefabFoods[9]);
        }
        if(menu =="latte")
        {
            recipeFoods.Add(prefabFoods[5]);
            recipeFoods.Add(prefabFoods[20]);
        }
        if(menu =="caramel")
        {
            recipeFoods.Add(prefabFoods[5]);
            recipeFoods.Add(prefabFoods[20]);
            recipeFoods.Add(prefabFoods[2]);
        }
        if(menu =="mocha")
        {
            recipeFoods.Add(prefabFoods[5]);
            recipeFoods.Add(prefabFoods[20]);
            recipeFoods.Add(prefabFoods[4]);
        }
        if(menu =="latte")
        {
            recipeFoods.Add(prefabFoods[5]);
            recipeFoods.Add(prefabFoods[20]);
        }
        if(menu =="latte")
        {
            recipeFoods.Add(prefabFoods[5]);
            recipeFoods.Add(prefabFoods[20]);
        }
        if(menu =="latte")
        {
            recipeFoods.Add(prefabFoods[5]);
            recipeFoods.Add(prefabFoods[20]);
        }
        if(menu =="latte")
        {
            recipeFoods.Add(prefabFoods[5]);
            recipeFoods.Add(prefabFoods[20]);
        }

        ShowRecipe();

        isOrder=false;
    }
    void ShowRecipe()
    {
        int layoutX=0;
        for(int i=0; i<recipeFoods.Count;i++)
        {   
            Transform foodTransform= this.gameObject.transform;
            //oodTransform.position = new Vector3(layoutX, 0,0);

            var food= Instantiate(recipeFoods[i], foodTransform);
            food.transform.localPosition = new Vector3(layoutX, 0,0);
            layoutX += 30;
        }
    }
}
