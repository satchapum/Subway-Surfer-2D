using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject SpawnerLeft;
    [SerializeField] private GameObject SpawnerMiddle;
    [SerializeField] private GameObject SpawnerRight;
    [SerializeField] private GameObject FencePrefab;
    [SerializeField] private GameObject TrainPrefab;
    [SerializeField] private float Delay;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ObstructionSpawn", Delay);
    }

    // Update is called once per frame
    void ObstructionSpawn()
    {
        float ObstructionRandom = Random.Range(1,3);
        float PositionRandom = Random.Range(1, 4);
        Debug.Log(ObstructionRandom);
        Debug.Log(PositionRandom);
        switch (PositionRandom)
        {
            case 1:
                if (ObstructionRandom == 1)
                    Instantiate(FencePrefab, SpawnerLeft.transform.position, transform.rotation);
                else
                    Instantiate(TrainPrefab, SpawnerLeft.transform.position, transform.rotation);
                break;
            case 2:
                if (ObstructionRandom == 1)
                    Instantiate(FencePrefab, SpawnerMiddle.transform.position, transform.rotation);
                else
                    Instantiate(TrainPrefab, SpawnerMiddle.transform.position, transform.rotation);
                break;
            case 3:
                if (ObstructionRandom == 1)
                    Instantiate(FencePrefab, SpawnerRight.transform.position, transform.rotation);
                else
                    Instantiate(TrainPrefab, SpawnerRight.transform.position, transform.rotation);
                break;
        }
        Invoke("ObstructionSpawn", Delay);
    }
}
