using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Lässt Comics aus dem Land, das auf dem Globus angeklickt wurde, auf zuständigem Canvas erscheinen
public class ShowComic : MonoBehaviour
{
    public GameObject canvas;
    public Image[] image = new Image[4];
    public Sprite[] sprite;
    public Sprite defaultSprite;
    private CameraControllerNeu cC;


    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.FindWithTag("canvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Bei Klick auf MarkerPrefab wird das defaultSprite mit dem jeweiligen ComicSprite ausgetauscht
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

    //Verlässt die Maus das Prefab wird das defaultSprite wieder eingesetzt
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
