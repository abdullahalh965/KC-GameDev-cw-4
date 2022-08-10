using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GAMEmanager : MonoBehaviour
{
    int score = 0;
    int increment = 1;

    public text text1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void increase()
    {
        score += increment;
        text1.text = score.ToString();
    }
    public void test()
    {

    }

}




