using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateController : MonoBehaviour
{
    public GameObject obj;
    public float x;
    public float y;
    public float z;

    void OnMouseDown() {
        GameObject newObj = Instantiate(obj, new Vector3(x, y, z), Quaternion.identity);
        newObj.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
