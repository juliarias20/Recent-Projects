using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class addInventory : MonoBehaviour
{
    public List<string> itemList = new List<string>();
    public GameObject Canvas;
    public GameObject StoneCanvas;
    public GameObject WoodenStickCanvas;

    // Start is called before the first frame update
    void Start()
    {
        Canvas.SetActive(false);
        StoneCanvas.SetActive(false);
        WoodenStickCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void Sword()
    {
        Canvas.SetActive(true);
    }

    public void StoneSword()
    {
        StoneCanvas.SetActive(true);
    }

    public void Stick()
    {
        WoodenStickCanvas.SetActive(true);
    }
    
}
