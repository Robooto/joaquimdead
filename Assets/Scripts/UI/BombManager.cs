using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BombManager : MonoBehaviour {

    public static int bombCount;
    public int bombcount = 3;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        bombCount = bombcount;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Bombs: " + bombCount;
    }
}
