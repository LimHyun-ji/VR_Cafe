using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public bool isGamePlaying;
    public Button GameStartBtn;
    public Button SettingsBtn;
    public GameObject SettingsPanel;
    GameObject player;

    public float totalTime = 300; // 전체 시간 제한(초)
    float limitTime; // 남은 시간(초)
    int min;    // 분단위
    float sec;  // 초단위
    public int score;  // 점수
    int maxScore = 30000;   // 목표 금액

    public Slider slTimer;  // 시간 표시 Slider UI
    public Text textTimer;  // 시간 표시 Text UI
    public Text scoreText;  // score 표시 UI
    public GameObject endButton;
    public GameObject successText;
    public GameObject failText;

    Vector3 playerPos;

    // Start is called before the first frame update
    private static UIManager instance;

    public static UIManager Instance()
    {
        return instance;
    }
    void Awake() 
    {
        Init();
    }
    void Init() 
    {
        instance=this;
        player=GameObject.FindGameObjectWithTag("Player");
        player.gameObject.GetComponent<MeshRenderer>().enabled=false;
        playerPos = player.transform.position;

        scoreText.text = "0";   // score 초기화
    }

    void Update()
    {        
        scoreText.text = "" + score;    //score 증가 표시

        if (isGamePlaying)  // 게임 플레이동안
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
                // 버튼, 결과 텍스트 활성화
                endButton.SetActive(true);

                if(score >= maxScore)  // 정해진 금액에 도달
                {
                    successText.SetActive(true);
                }
                else
                {
                    failText.SetActive(true);
                }

                // player, camera 위치 초기화
                player.transform.position = playerPos;
                Camera.main.transform.rotation = Quaternion.identity;

                isGamePlaying = false;
            }
        }
    }
    public void GameStart()
    {
        isGamePlaying=true;
        player.gameObject.GetComponent<MeshRenderer>().enabled=true;
        GameStartBtn.gameObject.SetActive(false);

        limitTime = totalTime;  // 남은 시간을 전체 시간으로 초기화
        slTimer.value = totalTime;  // 시간 표시 Slider 값 초기화
    }
    public void Pause()
    {
        isGamePlaying=false;
        CloseSettingPanel();
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );   //현재 씬 불러오기
        Init();
    }
    public void OpenSettingPanel()
    {
        SettingsPanel.SetActive(true);
    }
    public void CloseSettingPanel()
    {
        SettingsPanel.SetActive(false);
    }
}
