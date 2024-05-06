using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLoader : MonoBehaviour
{
    private BoardManager go;
    public string stageName;

    // Start is called before the first frame update
    void Start()
    {
        go = GetComponent<BoardManager>();
        go.LoadStage(stageName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
