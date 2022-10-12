using UnityEngine;

//Находится в Ground, используется для рандомной генерациии препятствий на сцене
public class Spawner : MonoBehaviour
{
    public GameObject ObstaclePrefab; //Префаб препятствия
    public bool spawnObstacles = true; //Вкл./выкл.генерацию
    public int obstaclesCount; //Число препятствий на сцене

    // Update is called once per frame
    void Start()
    {
        if (spawnObstacles)
        {
            float leftLimit, rightLimit;
            leftLimit = 20f;
            rightLimit = GlobalVar.GetGroundLength() - 50f;
            for (int i = 0; i < obstaclesCount; i++)
            {
                Vector3 randomSpawnPosition, check1, check2, check3, check4, check5, check6;
                randomSpawnPosition = new Vector3(Random.Range(-7, 7), 1, Random.Range(leftLimit, rightLimit));
                check1 = new Vector3(randomSpawnPosition.x, randomSpawnPosition.y, randomSpawnPosition.z + 1f);
                check2 = new Vector3(randomSpawnPosition.x, randomSpawnPosition.y, randomSpawnPosition.z - 1f);
                check3 = new Vector3(randomSpawnPosition.x + 1f, randomSpawnPosition.y, randomSpawnPosition.z + 1f);
                check4 = new Vector3(randomSpawnPosition.x - 1f, randomSpawnPosition.y, randomSpawnPosition.z + 1f);
                check5 = new Vector3(randomSpawnPosition.x + 1f, randomSpawnPosition.y, randomSpawnPosition.z - 1f);
                check6 = new Vector3(randomSpawnPosition.x - 1f, randomSpawnPosition.y, randomSpawnPosition.z - 1f);
                if (!Physics.CheckSphere(randomSpawnPosition, 0.1f) && !Physics.CheckSphere(check1, 0.1f) && !Physics.CheckSphere(check2, 0.1f) &&
                    !Physics.CheckSphere(check3, 0.1f) && !Physics.CheckSphere(check4, 0.1f) && !Physics.CheckSphere(check5, 0.1f) && !Physics.CheckSphere(check6, 0.1f))
                {
                    Instantiate(ObstaclePrefab, randomSpawnPosition, Quaternion.identity);
                }
                else
                {
                    i--; //Объект не сгенерирован, пробуем снова
                }
            }
        }
    }
}
