using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkBounce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Bounce()
    {
        float bouncePosY = Random.Range(-0.00005f, 0.00005f);

        while (Mathf.Abs(bouncePosY - transform.localPosition.y) >= 0.00001f)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(transform.localPosition.x, bouncePosY, transform.localPosition.z), 0.3f);
            yield return null;
        }

        StartCoroutine(Bounce());
    }
}
