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
    public GameObject player;

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

    }
    public void GameStart()
    {
        isGamePlaying=true;
        player.gameObject.GetComponent<MeshRenderer>().enabled=true;
        GameStartBtn.gameObject.SetActive(false);
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
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
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
