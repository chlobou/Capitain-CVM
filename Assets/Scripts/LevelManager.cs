using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    List<Button> buttonList = new List<Button>();

    // Start is called before the first frame update
    void Start()
    {
        buttonList.Add(GameObject.Find("ButtonNiv1").GetComponent<Button>());
        buttonList.Add(GameObject.Find("ButtonNiv2").GetComponent<Button>());
        buttonList.Add(GameObject.Find("ButtonNiv3").GetComponent<Button>());

        for (int i = 0; i < buttonList.Count; i++)
        {
            buttonList[i].interactable = false;
        }

        for (int i = 0; i < GameManager.Instance.PlayerData.maxLevelReached; i++)
        {
            buttonList[i].interactable = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
