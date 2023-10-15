using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Source : MonoBehaviour
{
    private AudioSource au;
    public Sprite sp1, sp2;
    private Image im;
    bool isPlay=true;
    // Start is called before the first frame update
    void Start()
    {
        au = GetComponent<AudioSource>();
        im = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlay)
        {
            im.sprite = sp1;
            au.volume = 0.5f;
        }
        else
        {
            au.volume = 0;
            im.sprite = sp2;
        }
    }
    public void Click()
    {
        isPlay=!isPlay;
    }
}
