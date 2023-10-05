using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KePlacer : MonoBehaviour
{
    public GameObject trueHair; // 配置するオブジェクト
    public GameObject fakeHair; // 配置するオブジェクト
    private bool hasPlacedFakeHair = false; // fakeHairを配置済みかどうかのフラグ

    void Start()
    {
        for (int i = 0; i < 9; i++)
        {
            // i/4 - 1をX座標に使ってオブジェクトを配置
            float xPosition = i / 4f - 1f;
            Vector3 position = new Vector3(xPosition, Random.Range(-0.1f, 0.1f), 1f);

            if (!hasPlacedFakeHair && Random.Range(0, 9) == 0 || !hasPlacedFakeHair && i == 8)
            {
                PlaceHair(fakeHair, position);
                hasPlacedFakeHair = true; // fakeHairを配置済みに設定
            }
            else
            {
                PlaceHair(trueHair, position);
            }
        }
    }

    void PlaceHair(GameObject hairObject, Vector3 position)
    {
        // 配置するオブジェクトを生成
        GameObject newObject = Instantiate(hairObject, position, Quaternion.identity);
    }
}
