using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowComic : MonoBehaviour
{
    public GameObject canvas;
    public Image[] image = new Image[4];
    public Sprite[] sprite;
    public Sprite defaultSprite;


    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindWithTag("canvas");
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Transform[] children = new Transform[canvas.transform.childCount];
            for(int i = 0; i < canvas.transform.childCount; i++)
            {
                children[i] = canvas.transform.GetChild(i);
            }

            for(int i = 0; i < sprite.Length; i++)
            {
                
                children[i].GetComponent<Image>().sprite = sprite[i];
            }

            Debug.Log(canvas.transform.childCount);
        }
    }

    private void OnMouseExit()
    {
        Transform[] children = new Transform[canvas.transform.childCount];
        for (int i = 0; i < canvas.transform.childCount; i++)
        {
            children[i] = canvas.transform.GetChild(i);
        }

        for (int i = 0; i < canvas.transform.childCount; i++)
        {
            children[i].GetComponent<Image>().sprite = defaultSprite; 
        }
    }
}
