using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour
{
    public Text UsernameBox;
    // Start is called before the first frame update
    void Start()
    {
        UsernameBox.text = PlayerPrefs.GetString("username");
    }
    public void clickReset()
    {
        PlayerPrefs.DeleteKey("username");
        SceneManager.LoadScene("firstScene");

    }
}
