using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    public GameObject obstacle;
    ScoreManager score_manager;

    float cooldown = 3;

    // Start is called before the first frame update
    void Start()
    {
        score_manager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnCooldown();
    }

    void SpawnObstacle()
    {
        Instantiate(obstacle, new Vector3(5, Random.Range(-3, 3), 0), Quaternion.identity);
    }

    void SpawnCooldown()
    {
        
        if (cooldown <= 0)
        {
            //Aqui faremos o spawn e restauramos nosso cooldown;
            cooldown = (8 - (score_manager.score_ / 10));
            SpawnObstacle();
        }
        else
        {
            cooldown -= Time.deltaTime;
        }
    }
}
