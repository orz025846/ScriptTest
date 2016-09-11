using UnityEngine;
using System.Collections;

// 発展課題---★
public class Boss
{
    private int mp = 53;   // ★int型の変数mpを宣言し、53で初期化
    
    // ★mpを消費して魔法攻撃をするMagic関数
    public void Magic()
    {
        this.mp -= 5;   // ★Magic関数内でmpを5減らす

        // ★コンソールに「魔法攻撃をした。残りMPは〇〇。」と表示
        // ★mpが足りない場合、「MPが足りないため魔法が使えない。」と表示
        if ( mp > 5)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp); 
        } else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }
}

public class Test : MonoBehaviour {

    void Start()
    {
        // 要素の個数が5の、int型の配列arrayを初期化
        int[] array = { 12, 34, 54, 78, 90 };

        // 配列の各要素の値を順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // 配列の各要素の値を逆順に表示
        for (int s = 4; s >= 0; s--)
        {
            Debug.Log(array[s]);
        }

        // ★Bossクラスの変数を宣言
        Boss magicMaster = new Boss();

        // ★Magic関数を呼び出し、10回使用
        for (int i = 0; i < 10; i++)
        {
            magicMaster.Magic();
        }
    }

    // Update is called once per frame
	void Update () {
	
	}
}