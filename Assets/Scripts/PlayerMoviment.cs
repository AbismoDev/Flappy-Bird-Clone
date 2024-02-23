using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{

    EntityStats entity_stats;

    public GameObject game_over;

    float move_speed;

    // Start is called before the first frame update
    void Start()
    {
        entity_stats = gameObject.GetComponent<EntityStats>();
        move_speed = entity_stats.base_speed;
    }

    // Update is called once per frame
    void Update()
    {
        UpToFly();
    }

    void UpToFly()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * move_speed, ForceMode2D.Impulse);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Obstacle")
        {
            this.enabled = false;
            game_over.SetActive(true);
        }
    }
}
