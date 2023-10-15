using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMMaker : MonoBehaviour
{
    public static bool isPlaying;
    public GameObject bgm;
    // Start is called before the first frame update
    void Start()
    {
        if (!isPlaying)//如果bgm没有在播放
        {
            isPlaying = true;
            GameObject spawnTile = Instantiate(bgm, transform.position, Quaternion.Euler(0, 0, 0));//生成bgm预制体

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
