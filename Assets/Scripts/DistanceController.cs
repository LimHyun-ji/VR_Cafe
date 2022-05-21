using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceController : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
    public GameObject selectPop;
    private float dist;
    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.transform.position, target.transform.position);
    }

    void LateUpdate()
    {
        if (dist <= 2.5) {
            selectPop.SetActive(true);
        } else {
            selectPop.SetActive(false);
        }
    }
}
