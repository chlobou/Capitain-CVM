using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectables : MonoBehaviour
{
    public string collectable;

    [SerializeField]
    private AudioClip _clip;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.PlayerData.collectables = new List<string>();
        if (collectable != null)
        {
            foreach (string element in GameManager.Instance.PlayerData.collectables)
            {
                if (element == collectable)
                {
                    Destroy(this.gameObject);
                }
                Debug.Log(element);
            }

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
            GameManager.Instance.AudioManager.PlayClipAtPoint(_clip, this.transform.position);
            GameManager.Instance.PlayerData.AjouterCollectable(collectable);
            Destroy(gameObject);
        }
    }
}
