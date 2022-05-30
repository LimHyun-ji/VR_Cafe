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
    //GameObject player;

    public float totalTime = 300; // ��ü �ð� ����(��)
    float limitTime; // ���� �ð�(��)
    int min;    // �д���
    float sec;  // �ʴ���
    int score;  // ����
    int maxScore = 30000;   // ��ǥ �ݾ�

    public Slider slTimer;  // �ð� ǥ�� Slider UI
    public Text textTimer;  // �ð� ǥ�� Text UI
    public Text scoreText;  // score ǥ�� UI
    public GameObject endButton;
    public GameObject successText;
    public GameObject failText;

    //Vector3 playerPos;

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
        //player=GameObject.FindGameObjectWithTag("Player");
        //player.gameObject.GetComponent<MeshRenderer>().enabled=false;
        //playerPos = player.transform.position;

        scoreText.text = "0";   // score �ʱ�ȭ
    }

    void Update()
    {
        // ���� �÷��̵���
        if(isGamePlaying)
        {
            limitTime -= Time.deltaTime;    // ���� �ð� ����

            // �����̴� ����
            if (slTimer.value > 0.0f)
            {
                slTimer.value -= Time.deltaTime;
            }

            // ��ü �ð��� 60�ʺ��� Ŭ ��
            if (limitTime >= 60f)
            {
                min = (int)limitTime / 60;  // 60���� ������ ����� ���� �д�����
                sec = limitTime % 60;   // 60���� ������ ����� �������� �ʴ�����

                textTimer.text = min + "�� " + (int)sec + "��";    // UI ǥ��
            }

            // ��ü �ð��� 60�� �̸��� ��
            else
            {
                textTimer.text = (int)limitTime + "��";  // �ʴ����� ������ ����
            }

            // ���� �ð��� 0���� �۾��� ��
            if (limitTime <= 0)
            {
                textTimer.text = "0��";  // UI �ؽ�Ʈ�� 0�ʷ� ����
                // ��ư, ��� �ؽ�Ʈ Ȱ��ȭ
                endButton.SetActive(true);

                if(score >= maxScore)  // ������ �ݾ׿� ����
                {
                    successText.SetActive(true);
                }
                else
                {
                    failText.SetActive(true);
                }

                // player, camera ��ġ �ʱ�ȭ
                //player.transform.position = playerPos;
                //Camera.main.transform.rotation = Quaternion.identity;

                isGamePlaying = false;
            }
        }
    }
    public void GameStart()
    {
        isGamePlaying=true;
        //player.gameObject.GetComponent<MeshRenderer>().enabled=true;
        GameStartBtn.gameObject.SetActive(false);

        limitTime = totalTime;  // ���� �ð��� ��ü �ð����� �ʱ�ȭ
        slTimer.value = totalTime;  // �ð� ǥ�� Slider �� �ʱ�ȭ
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
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );   //���� �� �ҷ�����
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
