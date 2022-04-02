using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMC : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject char1;
    public GameObject char2;
    public GameObject char3;
    public GameObject char4;
    void Start()
    {
        if (gameObject.CompareTag("char"))
        {
            if (MakeChoices.charType() == 1)
            {
                char1.SetActive(true);
            }
            if (MakeChoices.charType() == 2)
            {
                char2.SetActive(true);
            }
            if (MakeChoices.charType() == 3)
            {
                char3.SetActive(true);
            }
            if (MakeChoices.charType() == 4)
            {
                char4.SetActive(true);
            }
        }
        if (gameObject.CompareTag("pet"))
        {
            if (MakeChoices.pType() == "dog")
            {
                char1.SetActive(true);
            }
            if (MakeChoices.pType() == "cat")
            {
                char2.SetActive(true);
            }
            if (MakeChoices.pType() == "pig")
            {
                char3.SetActive(true);
            }
            if (MakeChoices.pType() == "panda")
            {
                char4.SetActive(true);
            }
        }
        if (gameObject.CompareTag("colour"))
        {
            if (MakeChoices.colourType() == "blue")
            {
                char1.SetActive(true);
            }
            if (MakeChoices.colourType() == "red")
            {
                char2.SetActive(true);
            }
            if (MakeChoices.colourType() == "green")
            {
                char3.SetActive(true);
            }
            if (MakeChoices.colourType() == "yellow")
            {
                char4.SetActive(true);
            }
        }
        if (gameObject.CompareTag("verb"))
        {
            if (MakeChoices.ver() == "walk")
            {
                char1.SetActive(true);
            }
            if (MakeChoices.ver() == "run")
            {
                char2.SetActive(true);
            }
            if (MakeChoices.ver() == "dance")
            {
                char3.SetActive(true);
            }

        }
        if (gameObject.CompareTag("food"))
        {
            if (MakeChoices.colourType() == "pizza")
            {
                char1.SetActive(true);
            }
            if (MakeChoices.colourType() == "burger")
            {
                char2.SetActive(true);
            }
            if (MakeChoices.colourType() == "spaghetti")
            {
                char3.SetActive(true);
            }
            if (MakeChoices.colourType() == "taco")
            {
                char4.SetActive(true);
            }
        }
        if (gameObject.CompareTag("music"))
        {
            if (MakeChoices.musicType() == 1)
            {
                Instantiate(char1);
            }
            if (MakeChoices.musicType() == 2)
            {
                Instantiate(char2);
            }
            if (MakeChoices.musicType() == 3)
            {
                Instantiate(char3);
            }
            if (MakeChoices.musicType() == 4)
            {
                Instantiate(char4);
            }
        }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
