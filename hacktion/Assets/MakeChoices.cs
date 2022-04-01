using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MakeChoices : MonoBehaviour
{
    public static int characterType;
    public static int petType;
    public static int setting;
    public static int colour;
    public static int adjective;
    public static int verb;
    public static int food;
    public static int music;
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }
    void TaskOnClick()
    {
        if (gameObject.CompareTag("c1"))
        {
            characterType = 1;
        }
        if (gameObject.CompareTag("c2"))
        {
            characterType = 2;
        }
        if (gameObject.CompareTag("c3"))
        {
            characterType = 3;
        }
        if (gameObject.CompareTag("c4"))
        {
            characterType = 4;
        }
        if (gameObject.CompareTag("p1"))
        {
            petType = 1;
        }
        if (gameObject.CompareTag("p2"))
        {
            petType = 2;
            print(petType);
        }
        if (gameObject.CompareTag("p3"))
        {
            petType = 3;
        }
        if (gameObject.CompareTag("p4"))
        {
            petType = 4;
        }
        if (gameObject.CompareTag("s1"))
        {
            setting = 1;
        }
        if (gameObject.CompareTag("s2"))
        {
            setting = 2;
        }
        if (gameObject.CompareTag("s3"))
        {
            setting = 3;
        }
        if (gameObject.CompareTag("co1"))
        {
            colour = 1;
        }
        if (gameObject.CompareTag("co2"))
        {
            colour = 2;
        }
        if (gameObject.CompareTag("co3"))
        {
            colour = 3;
        }
        if (gameObject.CompareTag("co4"))
        {
            colour = 4;
        }
        if (gameObject.CompareTag("a1"))
        {
            adjective = 1;
        }
        if (gameObject.CompareTag("a2"))
        {
            adjective = 2;
        }
        if (gameObject.CompareTag("a3"))
        {
            adjective = 3;
        }
        if (gameObject.CompareTag("v1"))
        {
            verb = 1;
        }
        if (gameObject.CompareTag("v2"))
        {
            verb = 2;
        }
        if (gameObject.CompareTag("v3"))
        {
            verb = 3;
        }
        if (gameObject.CompareTag("f1"))
        {
            food = 1;
        }
        if (gameObject.CompareTag("f2"))
        {
            food = 2;
        }
        if (gameObject.CompareTag("f3"))
        {
            food = 3;
        }
        if (gameObject.CompareTag("f4"))
        {
            food = 4;
        }
        if (gameObject.CompareTag("m1"))
        {
            music = 1;
        }
        if (gameObject.CompareTag("m2"))
        {
            music = 2;
        }
        if (gameObject.CompareTag("m3"))
        {
            music = 3;
        }
        if (gameObject.CompareTag("m4"))
        {
            music = 4;
        }

    }

    public static int charType()
    {
        return characterType;
    }
    public static int pType()
    {
        return petType;
    }
    public static int sType()
    {
        return setting;
    }
    public static int colourType()
    {
        return colour;
    }
    public static int adj()
    {
        return adjective;
    }
    public static int ver()
    {
        return verb;
    }
    public static int foodType()
    {
        return food;
    }

    public static int musicType()
    {
        return music;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
