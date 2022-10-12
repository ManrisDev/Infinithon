using UnityEngine;
using UnityEngine.SceneManagement;

//��������� ������ �� ������ Menu
public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void InfiniteMode()
    {
        SceneManager.LoadScene("Infinite");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
