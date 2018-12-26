using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{

    //最小サイズ
    private float minimum = 1.0f;
    //拡大縮小スピード
    private float magSpeed = 10.0f;
    //拡大率
    private float magnification = 0.07f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //雲を拡大縮小
        //ここでは、X軸方向（横方向）とZ軸方向（縦方向）に拡大縮小したいので、
        //Vector3の第一引数と第三引数に拡大縮小するための値を指定し、
        //Y軸方向（高さ方向）に拡大縮小する必要はないので、第二引数にはオブジェクト自身の大きさを指定しています。
        //また、オブジェクトが一定の速さで滑らかに拡大縮小するために、Sin関数を使っています。
        //Timeクラスの「time」は、ゲーム開始から何秒経ったかを取得することができます。
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);

    }
}