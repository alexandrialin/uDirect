using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nextCanvas());
        
    }

    public IEnumerator nextCanvas()
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }

}
