using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBounce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Bounce());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Bounce()
    {
        float bouncePosY = -0.1f + Random.Range(-0.025f, 0.01f);

        while(Mathf.Abs(bouncePosY - transform.localPosition.y) >= 0.01f)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(transform.localPosition.x, bouncePosY, transform.localPosition.z), 0.7f);
            yield return null;
        }

        StartCoroutine(Bounce());
    }
}
