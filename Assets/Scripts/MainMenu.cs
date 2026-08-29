using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject adjustPanel;

    void Start()
    {
        AudioManager.instance.PlayBGM(0);
    }


    void Update()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene("Loading");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ShowHideAdjustPanel(bool flag)
    {
        adjustPanel.SetActive(flag);

    }
    public void SetVolume(float volume)
    {
        AudioManager.instance.AdjustMasterVolume(volume);
    }
}
