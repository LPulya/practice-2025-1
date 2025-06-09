using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    public static change Instance;
    public int chs;
    private bool chchs;
    public Animator chA;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        chs = 0;
    }

    void Update()
    {
        if (chs == 1)
        {
            chA.SetBool("chchsB", true);
        }
    }
}
