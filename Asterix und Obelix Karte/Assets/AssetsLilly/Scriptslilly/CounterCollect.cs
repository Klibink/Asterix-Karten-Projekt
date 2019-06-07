using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterCollect : MonoBehaviour
{
    private float counterMovePoints;
    private float counterItem1;
    public bool Item1=false;
    public bool Item2 = false;
    public bool Item3 = false;
    public bool Item4 = false;
    public bool Item5 = false;
    public bool Item6 = false;
    public bool Item7 = false;
    public bool Item8 = false;
    public bool Item9 = false;
    public List<int> items = new List<int>();
    public List<string> itemnames = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        counterMovePoints = 0;
        counterItem1 = -5;
        //items[0] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void counter()
    {
        counterMovePoints += 1;
        //Debug.Log(counterMovePoints);
        if (items.Count!=0)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i] <= -1)
                {
                    items[i] += 1;
                    //Debug.Log("item"+i+":"+items[i]);
                }
                else if (items[i] >= -1)
                {

                    //Debug.Log("Item" + i + "Verfault");
                }

            }
        }
       
        /*if (Item1)
        {
            if (counterItem1 < 0)
            {
                counterItem1++;
            }
            else if (counterItem1 >= 0)
            {
                Debug.Log("Item1Verfault");
            }

        }*/
    }

   
}
