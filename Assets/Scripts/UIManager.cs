using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    bool isGamePlaying;
    public Button GameStartBtn;
    public Button SettingsBtn;
    public GameObject SettingsPanel;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameStart()
    {
        isGamePlaying=true;
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
