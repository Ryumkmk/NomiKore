using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTrueHair : MonoBehaviour
{
   public float moveSpeed = 5f; // 移動速度
    public float fadeSpeed = 1f; // フェードアウト速度
    private bool isClicked = false;
    private Vector3 targetPosition;

    private void Update()
    {
        if (isClicked)
        {
            // クリックされたら目標座標に向かって移動
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            // フェードアウト
            Color objectColor = GetComponent<Renderer>().material.color;
            objectColor.a -= fadeSpeed * Time.deltaTime;
            GetComponent<Renderer>().material.color = objectColor;

            // フェードアウトが完了したらオブジェクトを削除
            if (objectColor.a <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnMouseDown()
    {
        // クリックされたら座標を移動し、フェードアウト開始
        isClicked = true;
        targetPosition = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
    }
}
