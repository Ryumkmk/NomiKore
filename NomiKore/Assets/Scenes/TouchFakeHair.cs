using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TouchFakeHair : MonoBehaviour
{
    public string sceneName; // 遷移先のシーン名

    private void OnMouseDown()
    {
        // オブジェクトがクリックされたときにシーンを遷移
        SceneManager.LoadScene(sceneName);
    }
}
