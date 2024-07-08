using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPack : MonoBehaviour
{

    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.GetComponent<PlayerMove>().health < 100)
            {            
            collision.gameObject.GetComponent<PlayerMove>().health += 10;
            Destroy(gameObject);
            }
        }
    }
}
