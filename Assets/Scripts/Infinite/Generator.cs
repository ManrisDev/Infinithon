using UnityEngine;
using UnityEngine.SceneManagement;

//��������� ������� � ������ Infinite mode
public class Generator : MonoBehaviour
{
    public Transform Ground; //���������
    public Transform END;    //����� ������
    public Transform CHECKPOINT_1; //���������
    public Transform CHECKPOINT_2;
    private float firstCheckpointCoordinate = 0f;
    private float lastCheckpointCoordinate = 0f;

    private void Start()
    {
        //������� ���� ������������
        FindObjectOfType<Spawner>().obstaclesCount = GlobalVar.GetObstaclesCount();
        //������������� ����� ���������
        Ground.transform.localScale = new Vector3(15f, 1f, GlobalVar.GetGroundLength());
        //������������� ���������� ������������ ���������
        Ground.transform.position = new Vector3(-0.5f, 0f, (GlobalVar.GetGroundLength() / 2) - 5);
        //������������� ���������� ������������ ����� ������
        END.transform.position = new Vector3(-0.5f, 3f, GlobalVar.GetGroundLength() - 45);
        //������������� ���������� ������������ ���������� �� ������
        if (GlobalVar.GetLevel() > 9)
        {
            firstCheckpointCoordinate = 20 + (GlobalVar.GetGroundLength() - 70) / 3f;
            lastCheckpointCoordinate = 2f * firstCheckpointCoordinate - 20; 
            
            CHECKPOINT_1.transform.position = new Vector3(-0.5f, 3f, firstCheckpointCoordinate);
            CHECKPOINT_2.transform.position = new Vector3(-0.5f, 3f, lastCheckpointCoordinate);
        }
    }
    
    public void LoadNextLevelInfininte()
    {
        //�������++
        int Level = GlobalVar.GetLevel();
        GlobalVar.SetLevel(Level + 1); 

        //��������� ����������� ������� �� �����
        int Increase = GlobalVar.GetFibonacci(Level + 7); 
        GlobalVar.SetGroundLength(GlobalVar.GetGroundLength() + Increase);

        //���������� ���������� �����������
        float leftLimit = 20f;
        float rightLimit = GlobalVar.GetGroundLength() - 50f;
        int ObstCount = (int)((rightLimit - leftLimit) / 2.7f);
        GlobalVar.SetObstaclesCount(ObstCount);

        GlobalVar.SetStartCoordinates(new Vector3(0f, 0f, 0f));

        //Restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //����� ���� ��������� ������� �����
    }

    

    // Update is called once per frame
    private void Update()
    {
        //��� ������ � ���� ����� ���� �������� ������
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            GlobalVar.SetLevel(1);
            GlobalVar.SetGroundLength(100f);
            GlobalVar.SetObstaclesCount(10);
        }
    }
}
