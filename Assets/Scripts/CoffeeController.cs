using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoffeeController : MonoBehaviour
{
    public GameObject americano;
    public GameObject mocha;
    public GameObject macchiato;
    public GameObject latte;
    public Dropdown drop;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        if (drop.value == 0) {
            americano.SetActive(true);
        } else if (drop.value == 1) {
            latte.SetActive(true);
        } else if (drop.value == 2) {
            macchiato.SetActive(true);
        } else if (drop.value == 3) {
            mocha.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
