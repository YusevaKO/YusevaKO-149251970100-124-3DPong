using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene : MonoBehaviour
{
    public GameObject DisplayHowToPlay;
    public GameObject menu;
    public GameObject DisplayCredit;
    public void Pindahscene(string namaScene)
    {
        SceneManager.LoadScene(namaScene);
    }
    public void ExitButtom()
    {
        Application.Quit();
        Debug.Log("Closed");
    }

    public void MenuHowToPlay()
    {
        menu.SetActive(false);
        DisplayHowToPlay.SetActive(true);
    }
    public void backmenu1()
    {
        DisplayHowToPlay.SetActive(false);
        menu.SetActive(true);
    }
    public void Credit()
    {
        menu.SetActive(false);
        DisplayCredit.SetActive(true);
    }
    public void backmenu2()
    {
        DisplayCredit.SetActive(false);
        menu.SetActive(true);
    }
}
