using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public float timeToWait = 0f;
    public float timeWaited = 0f;
    public float heightOffset = 0f;

    public GameObject pipes;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipes = Instantiate(pipes);
        newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-heightOffset, heightOffset), 0);
        Destroy(newPipes, 5);

    }

    // Update is called once per frame
    void Update()
    {
        if(timeWaited > timeToWait)
        {
            GameObject newPipes = Instantiate(pipes);
            newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-heightOffset, heightOffset), 0);
            timeWaited = 0f;
            Destroy(newPipes, 5);
        }
        else
        {
            timeWaited += Time.deltaTime;   
        }
    }
}
