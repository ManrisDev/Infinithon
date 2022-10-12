using UnityEngine;
using UnityEngine.SceneManagement;

//Генерация уровней в режиме Infinite mode
public class Generator : MonoBehaviour
{
    public Transform Ground; //Платформа
    public Transform END;    //Конец уровня
    public Transform CHECKPOINT_1; //Чекпоинты
    public Transform CHECKPOINT_2;
    private float firstCheckpointCoordinate = 0f;
    private float lastCheckpointCoordinate = 0f;

    private void Start()
    {
        //Сколько стен генерировать
        FindObjectOfType<Spawner>().obstaclesCount = GlobalVar.GetObstaclesCount();
        //Устанавливаем длину платформы
        Ground.transform.localScale = new Vector3(15f, 1f, GlobalVar.GetGroundLength());
        //Устанавливаем корректное расположение платформы
        Ground.transform.position = new Vector3(-0.5f, 0f, (GlobalVar.GetGroundLength() / 2) - 5);
        //Устанавливаем корректное расположение конца уровня
        END.transform.position = new Vector3(-0.5f, 3f, GlobalVar.GetGroundLength() - 45);
        //Устанавливает корректное расположение чекпоинтов на уровне
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
        //Уровень++
        int Level = GlobalVar.GetLevel();
        GlobalVar.SetLevel(Level + 1); 

        //Насколько увеличиваем уровень по длине
        int Increase = GlobalVar.GetFibonacci(Level + 7); 
        GlobalVar.SetGroundLength(GlobalVar.GetGroundLength() + Increase);

        //Увеличение количества препятствий
        float leftLimit = 20f;
        float rightLimit = GlobalVar.GetGroundLength() - 50f;
        int ObstCount = (int)((rightLimit - leftLimit) / 2.7f);
        GlobalVar.SetObstaclesCount(ObstCount);

        GlobalVar.SetStartCoordinates(new Vector3(0f, 0f, 0f));

        //Restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //После всех изменений рестарт сцены
    }

    

    // Update is called once per frame
    private void Update()
    {
        //При выходе в меню сброс всех настроек уровня
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            GlobalVar.SetLevel(1);
            GlobalVar.SetGroundLength(100f);
            GlobalVar.SetObstaclesCount(10);
        }
    }
}
