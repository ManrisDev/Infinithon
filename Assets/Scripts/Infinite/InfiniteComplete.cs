using UnityEngine;

//Находится в LevelComplete на Infinite сцене
public class InfiniteComplete : MonoBehaviour
{
    //Вызывается ивентом анимации InfiniteComplete
    public void NextLevel()
    {
        FindObjectOfType<Generator>().LoadNextLevelInfininte();
    }
}
