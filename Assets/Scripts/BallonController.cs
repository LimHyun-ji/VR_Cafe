using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonController : MonoBehaviour
{
    Vector3 start = new Vector3(-18, 5.5f, 0.2f);
    Vector3 target = new Vector3(-3, 1f, 0);
    public float time;
    int num;
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
            case 69:
                {
                    transform.localEulerAngles = new Vector3(0, 270, 0);
                    transform.position = Vector3.MoveTowards(transform.position, start, 0.05f);
                    break;

                }
        }
    }
}
