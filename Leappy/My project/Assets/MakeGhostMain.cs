using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeGhostMain : MonoBehaviour
{
    public GameObject ghostMain;
    public float timeDiff;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newGhostMain = Instantiate(ghostMain);
            newGhostMain.transform.position = new Vector3(0, Random.Range(-2f, 0.3f), 0);
            timer = 0;
            Destroy(newGhostMain, 5.0f);
        }
    }
}
