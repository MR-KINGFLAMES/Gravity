using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    private CollectKey keycollect;
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    // Start is called before the first frame update

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("key").Length == 0)
        {
            spriteRenderer.sprite = newSprite;
        }
    }
}
