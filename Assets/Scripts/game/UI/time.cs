using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timetext;
    float timenum;
    void Start()
    {
        timenum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timenum += Time.deltaTime;
        timetext.text = "¥ÊªÓ ±º‰£∫" + timenum.ToString("F");
    }
}
