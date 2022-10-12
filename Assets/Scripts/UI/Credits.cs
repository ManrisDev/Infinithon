using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    //Вызывается с помощью ивента в анимации Credits
    //Сцена Credits в свою очередь, вызывается путем вызова следующей сцены в настройказ сборки
    //(Build settings) и показывает титры
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
