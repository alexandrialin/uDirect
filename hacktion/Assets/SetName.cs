using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetName : MonoBehaviour
{
    [SerializeField]
    public InputField input;
    public static string characterName;
    public static string petName;
    [SerializeField]
    private Text text;
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        
    }
    void TaskOnClick()
    {
        if (gameObject.CompareTag("char"))
        {
            characterName = text.text;
            print(characterName);
        }
        if (gameObject.CompareTag("pet")){
            petName = text.text;
            print(petName);
        }
       
    }
    public static string getCharName()
    {
        return characterName;
    }
    public static string getPetName()
    {
        return petName;
    }
    // Update is called once per frame
    void Update()
    {
        
    }


}
