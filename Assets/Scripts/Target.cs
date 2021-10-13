using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float moveSpeed;
    public float moveAmount;
    public float spinUpAmount;

    private Vector3 StartPosition;
    public float manager;



    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
        manager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

        var newPosition = transform.position;
            
        newPosition.x = StartPosition.x + Mathf.Sin(Time.time * moveSpeed) * moveAmount;
        newPosition.y = StartPosition.y + Mathf.Sin(Time.time * moveSpeed * 5) * moveAmount;
        transform.position = newPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var food = collision.gameObject.GetComponent<ThrowableObject>();

        if(food != null)
        {

        }



    }

}
