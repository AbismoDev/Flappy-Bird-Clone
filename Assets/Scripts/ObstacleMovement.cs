using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        MovePipe();
    }

    void MovePipe()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }
}
