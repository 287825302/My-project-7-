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
        if (!isPlaying)//���bgmû���ڲ���
        {
            isPlaying = true;
            GameObject spawnTile = Instantiate(bgm, transform.position, Quaternion.Euler(0, 0, 0));//����bgmԤ����

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
