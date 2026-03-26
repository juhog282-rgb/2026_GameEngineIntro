using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManger : MonoBehaviour
{
    public GameObject helpPanel;

    public void GameStart()
    {

        SceneManager.LoadScene("playScene_Door1");

    }





    public void GameTitle()
    {

        SceneManager.LoadScene("TitleScene");
    }

    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }


    public void CloseHelp()
    {
        helpPanel.SetActive(false);

    }
}
