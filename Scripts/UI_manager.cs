using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

using UnityEngine;

public class UI_manager : MonoBehaviour
{
    [SerializeField] Text _text;
    [SerializeField] GameObject _parrent;
    // Start is called before the first frame update
   void start()
    {
        ShowGameoverPanel(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowGameoverPanel(bool val)
    {
        _parrent.gameObject.SetActive(val);
    }

    public void SetScoreText(string strings)
    {
        _text.text = "X " + strings;
    }
}
