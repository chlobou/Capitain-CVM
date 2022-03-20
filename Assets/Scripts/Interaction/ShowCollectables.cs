using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCollectables : MonoBehaviour
{
    [SerializeField]
    private string collectableName;

    // Start is called before the first frame update
    void Start()
    {
        foreach (string element in GameManager.Instance.PlayerData.collectables)
        {
            if (element != collectableName)
            {
                this.gameObject.SetActive(false);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
