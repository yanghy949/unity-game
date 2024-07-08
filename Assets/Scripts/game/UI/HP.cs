using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider s;
    public GameObject player;
    void Start()
    {
        s.value = 100;
    }

    // Update is called once per frame
    void Update()
    {
        s.value = player.GetComponent<PlayerMove>().health;
    }
}
