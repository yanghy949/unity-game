using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemy : MonoBehaviour
{
    public GameObject enemydead;
    public float speed = 10;
    public GameObject playerObject;

    // public float deadtime=5;
    /*
    void Start()
    {
        Destroy(gameObject, deadtime);
    }
    */
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.tag == "Player")
    //    {
    //        collision.gameObject.GetComponent<PlayerMove>().health -= 10;
    //        Destroy(gameObject);
    //    }
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log(collision.gameObject.name);
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        Debug.Log("destroy");
    //        collision.gameObject.GetComponent<PlayerMove>().health -= 10;
    //        Destroy(gameObject);
    //    }
    //}
    void OnDestroy()
    {
        Instantiate(enemydead, transform.position, Quaternion.identity);
    }
    void Update()
    {
        Vector2 trans = playerObject.transform.position;

        transform.position = Vector2.MoveTowards(transform.position, trans,speed*Time.deltaTime);
        speed += Random.Range(0.001f, 0.003f);
    }

}
