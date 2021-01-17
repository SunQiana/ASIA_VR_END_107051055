using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class snowman : MonoBehaviour
{
    public static int Score;
    public Text Scoreborad;

    private void OnTriggerEnter(Collider other)
    {
        //如果雪球碰撞
        if (other.tag == "snowball") 
        {
            //雪人bang不見
            Destroy(this.gameObject);
            Score = Score + 1;
        }
    }

    void Update()
    {
        Scoreborad.text = Score.ToString();
    }
}
