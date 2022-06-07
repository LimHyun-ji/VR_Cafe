using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JuiceController : MonoBehaviour
{
    public GameObject lemon;
    public GameObject jamong;
    public GameObject straw;
    public GameObject mango;
    public GameObject blueberry;
    public Dropdown drop;

    void OnMouseDown()
    {
        if (drop.value == 0) {
            lemon.SetActive(true);
        } else if (drop.value == 1) {
            jamong.SetActive(true);
        } else if (drop.value == 2) {
            straw.SetActive(true);
        } else if (drop.value == 3) {
            mango.SetActive(true);
        }else if (drop.value == 4) {
            blueberry.SetActive(true);
        }
    }
}
