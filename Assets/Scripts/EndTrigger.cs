using UnityEngine;

//����������� ��� ������� ������� END (Is Trigger true)
public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    
    void OnTriggerEnter()
    {
        gameManager.LevelComplete();
    }
}
