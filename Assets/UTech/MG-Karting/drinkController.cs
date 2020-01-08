using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drinkController : MonoBehaviour
{
    GameObject Kart;
    // Start is called before the first frame update
    void Start()
    {
        this.Kart = GameObject.Find("Kart");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime, Space.World);


        Vector3 p1 = transform.position;
        Vector3 p2 = this.Kart.transform.position;
        Vector3 dir = p1 - p2;

        float d = dir.magnitude;
        float r1 = 1.5f;
        float r2 = 1.0f;

        if(d < r1 + r2)
        {
            //あたったときの処理
            Destroy(gameObject);
        }

    }
}
