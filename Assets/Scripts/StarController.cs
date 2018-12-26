using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//MonoBehaviorはStarControllerの親クラスで継承している。だからtransform変数が使える。
public class StarController : MonoBehaviour {
    // 回転速度
    //float型は浮動小数点数を扱う変数です。
    //float型の変数に値を代入するときは、値の最後に「f」を書いてください。
    private float rotSpeed = 1.0f;

    // Use this for initialization
    void Start () {
        //回転を開始する角度を設定
        //Randomクラスの「Range」関数は、
        //第一引数以上、第二引数未満の整数をランダムに返します。
        //transform変数.関数名（Rotate）,Random←クラス名、Range←関数名、C#のルール、見分け方クラス名は大文字、
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }
	
	// Update is called once per frame
	void Update () {
        //回転
        this.transform.Rotate(0, this.rotSpeed, 0);
    }
}

