using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{
    public int speedForward = 12;   //전진 속도
    public int speedSide = 6;   //옆걸음 속도

    private Transform tr;   //플레이어 트랜스폼
    private float dirX = 0;
    private float dirZ = 0;

    void Start() {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        dirX = 0;   //좌우 이동 방향(왼쪽: -1, 오른쪽: 1)
        dirZ = 0;   //전진 후진 이동 방향(후진: -1, 전진: 1)

        if(OVRInput.Get(OVRInput.Button.PrimaryThumbstick))
        {
            Vector2 coord = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

            var absX = Mathf.Abs(coord.x);
            var absY = Mathf.Abs(coord.y);

            if(absX>absY)
            {
                //Right
                if(coord.x > 0)
                    dirX = +1;
                else
                    dirX = -1;
            }
            else
            {
                // Up
                if(coord.y > 0)
                    dirZ = +1;
                // Down
                else
                    dirZ = -1;
            }

        }
        //이동 방향 설정 후 이동
        Vector3 moveDir = new Vector3(dirX * speedSide, 0, dirZ*speedForward);
        transform.Translate(moveDir*Time.smoothDeltaTime);
    }
}
