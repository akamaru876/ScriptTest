using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    public int mp = 53;    //マジックポイント
    public int hp = 100;   //ボス体力
    public int mpAttack = 10;  //魔法の攻撃力
    public int mpCons = 5;    //mpの消費量
    //mpの残量
    public void Majic()
    {
        for (int i = 0; i < 10; i++)
        {
            //残りmpを減らす
            this.mp -= this.mpCons;

            if (mp >= 5)
            {
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp +"。" + "ボスは" + mpAttack  + "のダメージを受けた");
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない");
            }
        }
    }

    //ボスの残りの体力
    public void Stamina()
    {
        for (int n = 0; n < 9; n++)
        {
            //残りhpを減らす
            this.hp -= mpAttack;
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

        //マジックポイントの関数を呼び出す
        lastboss.Majic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
