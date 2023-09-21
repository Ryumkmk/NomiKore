using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    string coreName = "";
    string sceneName = "";

    private void Start()
    {
        //「〜〜Button」の「〜〜」の部分だけを取り出す
        coreName = GetCoreName(name);
        if(coreName == "error")
        {
            print("エラー：ボタン名が取得できませんでした");
        }

        // ""Scenes/〜〜Scene"" という文字列を作成
        // シーン遷移用
        sceneName = "Scenes/" + coreName + "Scene";

        //確認用
        //print(sceneName);
    }

    //「〜〜Button」の「〜〜」の部分だけを取り出すメソッド
    static string GetCoreName(string ButtonName)
    {
        string targetSubstring = "Button";

        // 指定の文字列「Button」より前の部分を取得
        int indexOfTarget = ButtonName.IndexOf(targetSubstring);
        if (indexOfTarget != -1)
        {
            string beforeSubstring = ButtonName.Substring(0, indexOfTarget);
            return beforeSubstring;
        }
        else
        {
            return "error";
        }
    }

    // ボタンクリックでシーン遷移
    public void OnClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
