using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetDialogue : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("t1"))
        {
            text.text = "In order to cook like " + SetName.getCharName() + "'s grandma, you must first adopt a pet " + MakeChoices.pType() + " and name it " + SetName.getPetName();
        }
        if (gameObject.CompareTag("t2"))
        {
            text.text = "Then, with voodoo you will be transported to " + MakeChoices.sType() + " where the skies smell like the ground and the ground tastes like the sky. ";
        }
        if (gameObject.CompareTag("t3"))
        {
            text.text = "Grandma is always watching, no matter where voodoo takes you.";
        }
        if (gameObject.CompareTag("t4"))
        {
            text.text = "Beware of the hot chili peppers, as they will certainly spice up your recipe to the point of no return and stain your kitchen walls " + MakeChoices.colourType() ;
        }
        if (gameObject.CompareTag("t5"))
        {
            text.text = "In case you weren't unaware, grandma likes her food " + MakeChoices.adj() + " and hot. ";
        }
        if (gameObject.CompareTag("t6"))
        {
            text.text = "Make sure to follow the recipe very closely and never stray far from any instructions, otherwise grandma will " + MakeChoices.ver() + " with disappointment.";
        }
        if (gameObject.CompareTag("t7"))
        {
            text.text = "If all goes well, everyone at the dinner table will develop a severe " + MakeChoices.foodType() + " addiction because of your ability to cook like "+ SetName.getCharName() + "’s grandma. ";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
