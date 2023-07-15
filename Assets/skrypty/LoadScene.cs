using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public int IndexOfLevel;
    public GameObject textToOutput;
    string outPutText;

    // Use this for initialization
    void Start()
    {
        outPutText = "PRESS E";
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            textToOutput.GetComponent<Text>().text = outPutText;

            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(IndexOfLevel);
            }
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            textToOutput.GetComponent<Text>().text = "";

        }
    }
}