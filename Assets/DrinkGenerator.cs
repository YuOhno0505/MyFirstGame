using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkGenerator : MonoBehaviour
{
    public GameObject DrinkPrefab;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(DrinkPrefab) as GameObject;
            /*アイテムが枠範囲の指定
             * int px = Random.Range(最小,最大);
             * int py = Random.Range(最小,最大);
             * go.transform.position = new Vector3 (px,py,1);
             */
        }
    }
}