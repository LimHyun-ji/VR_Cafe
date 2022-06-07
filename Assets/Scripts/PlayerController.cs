using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed=5;

    AudioSource audioSource;
    public AudioClip scoreAudio;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if(UIManager.Instance().isGamePlaying)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
    
            // 2. 앞뒤 좌우로 방향을 만든다.
            Vector3 dir = Vector3.right * h + Vector3.forward * v;
            dir = Camera.main.transform.TransformDirection(dir);
            //대각선 이동으로 하면서 루트2로 길이가 늘어나기에 1로 만들어준다. (정규화:Normalize)
            dir.Normalize();
    
            // 3. 그 방향으로 이동한다.
            // P = P0 + vt
            transform.position += dir * speed * Time.deltaTime;
        }  
    }

    public void PlaySound()
    {
        audioSource.clip = scoreAudio;
        audioSource.Play();
    }
}
