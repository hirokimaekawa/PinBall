using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Textにアクセスするために必要
using UnityEngine.UI;

public class GetPointer : MonoBehaviour {

    public GameObject textScore;
    
    private int score = 0;

    //private int LargeStarGetScore = 20;
    //private int SmallCloudGetScore = 30;
    //private int LargeCloudGetScore = 30;

    void RefreshScoretext()
    {
        //メンバ変数内の自分で定義したtextScoreクラス？のGetComponent関数
        this.textScore.GetComponent<Text>().text="得点："+score;

    }
	// Use this for initialization
	void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {
	}
    //衝突時のデータがcolに渡され、
    void OnCollisionEnter(Collision col)
    {
        //colのgameObjectの、CompareTag関数で衝突したオブジェクトのタグが"LargeStarTag"だったら、
        if (col.gameObject.CompareTag("LargeStarTag"))
        {
            //scoreを２０加え、
            score += 20;
            RefreshScoretext();
        }else if(col.gameObject.CompareTag("SmallCloudTag")){
            score += 30;
            RefreshScoretext();

        }else if(col.gameObject.CompareTag("LargeCloudTag")){
            score += 40;
            RefreshScoretext();
        }
    }
}
