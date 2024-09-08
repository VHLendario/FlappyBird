using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject parede;
    float cool_down = 2.8f;
    float cooldown_; 
    bool can_spawn = true;
    ScoreManager score_manager;
    
    // Start is called before the first frame update
    void Start()
    {
        score_manager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnObstacle ();
    }

    void Cooldown ()
    {
        if (cooldown_ > cool_down && can_spawn == false) {
            can_spawn = true;
        }
        else {
            cooldown_ += Time.deltaTime;
        }
    }

    void SpawnObstacle ()
    {
        if (can_spawn == true ){
        Instantiate(parede, new Vector3(5, Random.Range(-3, 3), 0), Quaternion.identity);
        can_spawn = false;
        cooldown_ = 0;
        }
        Cooldown ();
    }

   

   
}
