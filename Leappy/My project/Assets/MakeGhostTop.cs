using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeGhostTop : MonoBehaviour
{
    public GameObject ghostTop;
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
            GameObject newGhostTop = Instantiate(ghostTop);
            newGhostTop.transform.position = new Vector3(18, 0, 0);
            timer = 0;
            Destroy(newGhostTop, 5.0f);
        }
    }
}
