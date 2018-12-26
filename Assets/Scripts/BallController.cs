using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

//ボールが見える可能性のあるz軸の最大値
        private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            //インスペクターキーの初期設定で、VerticalOverflowはTruncate(削除)と言う風になっているから、
            //はみ出して表示されなくなる。
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}
