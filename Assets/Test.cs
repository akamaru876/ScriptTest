using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        //配列を初期化する
        int[] array = { 20, 15,497,1,34 };
         //配列の要素数のぶんだけ処理を繰り返す
         for(int i = 0; i < array.Length; i++)
        {
            //配列の要素を順番に表示する
            Debug.Log(array[i]);
        }
        //配列の要素数のぶんだけ末尾から処理を繰り返す
        for (int i = array.Length - 1; 0<= i; i--)
        {
            //配列の要素を逆順に表示する
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
