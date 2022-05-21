using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float limitTime; // 전체 시간 제한(초)

    int min;    // 분단위
    float sec;  // 초단위

    public Slider slTimer;  // 시간 표시 Slider UI
    public Text textTimer;  // 시간 표시 Text UI
    public GameObject Timer;
    public GameObject endButton;
    public GameObject successText;
    public GameObject failText;

    void Update()
    {
        limitTime -= Time.deltaTime;    // 남은 시간 감소

        // 슬라이더 감소
        if (slTimer.value > 0.0f)
        {
            slTimer.value -= Time.deltaTime;
        }

        // 전체 시간이 60초보다 클 때
        if (limitTime >= 60f)
        {
            min = (int)limitTime / 60;  // 60으로 나눠서 생기는 몫을 분단위로
            sec = limitTime % 60;   // 60으로 나눠서 생기는 나머지를 초단위로

            textTimer.text = min + "분 " + (int)sec + "초";    // UI 표시
        }

        // 전체 시간이 60초 미만일 때
        else
        {
            textTimer.text = (int)limitTime + "초";  // 초단위만 남도록 설정
        }

        // 남은 시간이 0보다 작아질 때
        if (limitTime <= 0)
        {
            textTimer.text = "0초";  // UI 텍스트를 0초로 고정
            // Scene을 새로 만들지 UI로 보여줄지
            // 타이머 UI 비활성화
            Timer.SetActive(false);
            // 버튼, 결과 텍스트 활성화
            endButton.SetActive(true);
            successText.SetActive(true);
        }
    }

    // 다시하기 버튼 누를 시
    public void OnClickRestart()
    {
        SceneManager.LoadScene("QuitGame");
    }

    // 영업 종료 버튼 누를 시
    public void OnClickQuit()
    {
        SceneManager.LoadScene("QuitGame");
    }
}