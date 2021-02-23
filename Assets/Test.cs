using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    public int mp = 53;    //マジックポイント
    public int mpCons = 5;    //mpの消費量
    //Majic関数
    public void Magic()
    {
        //mpの残りが5以上の場合
        if(this.mp >= 5)
        {
            //mpを5減らす
           this.mp -= this.mpCons;
            Debug.Log("魔法攻撃をした。残りMPは" + mp );
           
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
        
    }
}



public class Test : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //10回繰り返す
        for(int i = 0; i < 10; i++)
        {
            //magic関数を呼び出す
            lastboss.Magic();
        }
        //11回目の呼び出し
        lastboss.Magic();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
