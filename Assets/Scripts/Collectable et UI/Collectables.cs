using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{

    public string collectableName;

    // Start is called before the first frame update
    void Start()
    {

        if (collectableName != null)
        {
            foreach (string collectable in GameManager.Instance.PlayerData.collectables)
            {
                if (collectable == collectableName)
                {
                    Destroy(gameObject);
                }
            }
        }
        else
        {
            collectableName = gameObject.name;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            GameManager.Instance.PlayerData.AjouterCollectable(collectableName);
            Destroy(gameObject);
        }
    }
}
