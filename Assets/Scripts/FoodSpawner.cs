using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] private float countdownObstacle;

    private float timer;
    private PoolScript obstaclePool;

    void Start()
    {
        timer = 0;
        obstaclePool = GetComponent<PoolScript>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= countdownObstacle)
        {
            GameObject obj = obstaclePool.RequestObject();

            float randX = Random.Range(-17.3f, 17.3f);
            float randZ = Random.Range(-9.3f, 9.3f);
            obj.transform.position = new Vector3(randX, 0.5f, randZ);
            timer = 0;
        }
    }
}
