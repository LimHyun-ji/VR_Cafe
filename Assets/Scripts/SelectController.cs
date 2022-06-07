using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectController : MonoBehaviour
{
    public GameObject obj;
    void OnMouseDown()
    {
        obj.SetActive(true);
    }
}
