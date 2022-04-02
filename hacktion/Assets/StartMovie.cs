using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartMovie : MonoBehaviour
{
    public Button yourButton;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    // Update is called once per frame
    void TaskOnClick()
    {
        if (gameObject.CompareTag("char"))
        {
            SceneManager.LoadScene("Scene1");
        }
        if (gameObject.CompareTag("t1") && MakeChoices.sType() == "outer space")
        {
            SceneManager.LoadScene("Scene2A");
        }
        if (gameObject.CompareTag("t1") && MakeChoices.sType() == "the beach")
        {
            SceneManager.LoadScene("Scene2B");
        }
        if (gameObject.CompareTag("t1") && MakeChoices.sType() == "the jungle")
        {
            SceneManager.LoadScene("Scene2C");
        }
        if (gameObject.CompareTag("t2"))
        {
            SceneManager.LoadScene("Scene3");
        }
        if (gameObject.CompareTag("t3"))
        {
            SceneManager.LoadScene("Scene4");
        }
        if (gameObject.CompareTag("t4"))
        {
            SceneManager.LoadScene("Scene5");
        }
        if (gameObject.CompareTag("t5"))
        {
            SceneManager.LoadScene("Scene6");
        }
        if (gameObject.CompareTag("t6"))
        {
            SceneManager.LoadScene("Scene7");
        }
        if (gameObject.CompareTag("t7"))
        {
            SceneManager.LoadScene("CreateScene");
        }

    }
}
