using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManager targetPrefab;

    public void SpawnTarget() 
    {
        var newTarget = Instantiate(targetPrefab, GenerateRandomPosition(), targetPrefab.transform.rotation);


    }

    private void GenerateRandomPosition()
    {
        var randomPosition = new Vector3(Random.Range(BoxCollider.bounds.min.x, BoxCollider.bounds.max.x), 
                                                       Random.Range(box.bounds.min.y, box.bounds.max.y),
                                                       Random.Range(box.bounds.min.z, box.bounds.max.z));)
    }

    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
