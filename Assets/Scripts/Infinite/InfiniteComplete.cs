using UnityEngine;

//��������� � LevelComplete �� Infinite �����
public class InfiniteComplete : MonoBehaviour
{
    //���������� ������� �������� InfiniteComplete
    public void NextLevel()
    {
        FindObjectOfType<Generator>().LoadNextLevelInfininte();
    }
}
