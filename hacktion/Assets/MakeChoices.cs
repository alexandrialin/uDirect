using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MakeChoices : MonoBehaviour
{
    public static int characterType;
    public static string petType;
    public static string setting;
    public static string colour;
    public static string adjective;
    public static string verb;
    public static string food;
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
            petType = "dog";
        }
        if (gameObject.CompareTag("p2"))
        {
            petType = "cat";
            print(petType);
        }
        if (gameObject.CompareTag("p3"))
        {
            petType = "pig";
        }
        if (gameObject.CompareTag("p4"))
        {
            petType = "panda";
        }
        if (gameObject.CompareTag("s1"))
        {
            setting = "outer space";
        }
        if (gameObject.CompareTag("s2"))
        {
            setting = "the beach";
        }
        if (gameObject.CompareTag("s3"))
        {
            setting = "the jungle";
        }
        if (gameObject.CompareTag("co1"))
        {
            colour = "blue";
        }
        if (gameObject.CompareTag("co2"))
        {
            colour = "red";
        }
        if (gameObject.CompareTag("co3"))
        {
            colour = "green";
        }
        if (gameObject.CompareTag("co4"))
        {
            colour = "yellow";
        }
        if (gameObject.CompareTag("a1"))
        {
            adjective = "creepy";
        }
        if (gameObject.CompareTag("a2"))
        {
            adjective = "itchy";
        }
        if (gameObject.CompareTag("a3"))
        {
            adjective = "sassy";
        }
        if (gameObject.CompareTag("v1"))
        {
            verb = "walk";
        }
        if (gameObject.CompareTag("v2"))
        {
            verb = "run";
        }
        if (gameObject.CompareTag("v3"))
        {
            verb = "dance";
        }
        if (gameObject.CompareTag("f1"))
        {
            food = "pizza";
        }
        if (gameObject.CompareTag("f2"))
        {
            food = "burger";
        }
        if (gameObject.CompareTag("f3"))
        {
            food = "spaghetti";
        }
        if (gameObject.CompareTag("f4"))
        {
            food = "taco";
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
    public static string pType()
    {
        return petType;
    }
    public static string sType()
    {
        return setting;
    }
    public static string colourType()
    {
        return colour;
    }
    public static string adj()
    {
        return adjective;
    }
    public static string ver()
    {
        return verb;
    }
    public static string foodType()
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
