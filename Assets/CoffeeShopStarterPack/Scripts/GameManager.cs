using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float limitTime; // ��ü �ð� ����(��)

    int min;    // �д���
    float sec;  // �ʴ���

    public Slider slTimer;  // �ð� ǥ�� Slider UI
    public Text textTimer;  // �ð� ǥ�� Text UI
    public GameObject Timer;
    public GameObject endButton;
    public GameObject successText;
    public GameObject failText;

    void Update()
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
            // Scene�� ���� ������ UI�� ��������
            // Ÿ�̸� UI ��Ȱ��ȭ
            Timer.SetActive(false);
            // ��ư, ��� �ؽ�Ʈ Ȱ��ȭ
            endButton.SetActive(true);
            successText.SetActive(true);
        }
    }

    // �ٽ��ϱ� ��ư ���� ��
    public void OnClickRestart()
    {
        SceneManager.LoadScene("QuitGame");
    }

    // ���� ���� ��ư ���� ��
    public void OnClickQuit()
    {
        SceneManager.LoadScene("QuitGame");
    }
}