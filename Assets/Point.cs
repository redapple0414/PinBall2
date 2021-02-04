using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    private GameObject tensuuText;

    private float visiblePosZ = -6.5f;

    private int tokuten;

    private GameObject gameoverText;

    private int finish = 0;


    // Use this for initialization
    void Start()
    {
        
        this.tensuuText = GameObject.Find("tensuu");
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    { 
      
            
        this.tensuuText.GetComponent<Text>().text = "Point:" + this.tokuten;
        if (this.tokuten >= 100)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Clear";
            this.finish = 1;
        }
        if (this.transform.position.z < this.visiblePosZ)
        {
            if (this.finish == 0)
            {
                //GameoverTextにゲームオーバを表示
                this.gameoverText.GetComponent<Text>().text = "Game Over";
            }
        }
        
    }



    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.tokuten += 1;
        }
        if (other.gameObject.tag == "LargeStarTag")
        {
            this.tokuten += 3;
        }
        if (other.gameObject.tag == "SmallCloudTag" || other.gameObject.tag == "LargeCloudTag")
        {
            this.tokuten += 5;
        }
        if (other.gameObject.tag == "bad")
        {
            this.tokuten -= 3;
        }

        Debug.Log(tokuten);

       
    }

}