using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ozyamamusi : MonoBehaviour
{
    private float angle = 2.0f;
    float speed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
        
        Vector3 velocity = gameObject.transform.rotation * new Vector3(0, 0, speed);
        gameObject.transform.position += velocity * Time.deltaTime;
        if (this.transform.position.z < -6.5f || this.transform.position.z > 6.5f　|| this.transform.position.y < -6.5f)
        {
            transform.position = new Vector3(3f, 5f, 4f);
            
        }

    }
    void OnCollisionEnter(Collision other)
    {


        this.angle = Random.Range(10, 30);
        this.transform.Rotate(0, this.angle, 0);
    }
}
