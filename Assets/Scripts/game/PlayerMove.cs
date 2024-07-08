using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public static float speed=20f;
    public Vector3 playerInput;
    Animator anim;
    float noInputTime;
    public GameObject enemy;
    public int health=100;
    public VariableJoystick variableJoystick;
    public GameObject rock;
    public GameObject over;
    public GameObject ctrl;
    public GameObject restart;
    public GameObject Stone;
    public GameObject exit;
    public GameObject wbq;
    void Start()
    {
        Time.timeScale = 1f;
        wbq.SetActive(false);
        anim = gameObject.GetComponent<Animator>();
        Stone.SetActive(true);
        //ctrl
        over.SetActive(false);
        restart.SetActive(false);
       // Instantiate(enemy, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        //不动
        if (noInputTime < 5)
        {
            noInputTime = noInputTime + Time.deltaTime;
        }
        anim.SetFloat("noInput", noInputTime);

        //Runing
        if (playerInput != Vector3.zero)
        {
            anim.SetBool("isRunning", true);
            noInputTime = 0;
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        //键盘移动
        playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.position = (playerInput * speed * Time.deltaTime) + transform.position;
        //触屏移动
        if (variableJoystick.Vertical != 0 || variableJoystick.Horizontal != 0)
        {
            Vector3 move = new Vector3(variableJoystick.Horizontal, variableJoystick.Vertical, 0);
            transform.Translate(move * speed * Time.deltaTime);
            noInputTime = 0;
            anim.SetBool("isRunning", true);
        }

        if (Input.GetKeyDown("space")) {
            stone();
        }
        if (health <= 0)
        {
            over.SetActive(true);
            restart.SetActive(true);
            wbq.SetActive(true);
            Time.timeScale = 0f;
            ctrl.SetActive(false);
            Stone.SetActive(false);
            exit.SetActive(false);
            gameObject.SetActive(false);


        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "enemy")
        {
            health -= 10;
            Destroy(collision.gameObject);
        }
    }

    public void stone()
    {
       // Instantiate(rock, transform.position, Quaternion.identity);
        
    }
    public void OnDestroy()
    {
        GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>();
        foreach (GameObject obj in allObjects)
        {
            Destroy(obj);
        }

    }

}
