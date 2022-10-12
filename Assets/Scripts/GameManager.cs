using UnityEngine;
using UnityEngine.SceneManagement;

//���������� ������� (��������)
public class GameManager : MonoBehaviour
{
    public PlayerMovement movement; //���������� ��������� ������
    public GameObject score; //����
    public GameObject levelComplete; //������ ����������� ������
    public GameObject gameOver; //������ ���������
    public GameObject level;
    public GameObject congratulations;
    public float restartDelay = 1f; //�������� �����������
    bool gameHasEnded = false; //��� ������������ �������� ���� ���

    public void LevelComplete()
    {
        levelComplete.SetActive(true);
        movement.enabled = false;
        
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            gameOver.SetActive(true);
            score.SetActive(false);
            movement.enabled = false;
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        if (GlobalVar.GetStartCoordinates().z == 0f)
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            gameHasEnded = false;
            gameOver.SetActive(false);
            score.SetActive(true);
            movement.enabled = true;
            movement.player.position = GlobalVar.GetStartCoordinates();
            level.SetActive(false);
            level.SetActive(true);
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GlobalVar.SetStartCoordinates(new Vector3(0f, 0f, 0f));
            Restart();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
            FindObjectOfType<Music>().play.Stop();
        }
    }
    private void Start()
    {
        GlobalVar.SetStartCoordinates(new Vector3(0f, 0f, 0f));
        if (GlobalVar.GetLevel() == 10)
        {
            congratulations.SetActive(true);
        }
    }
}

