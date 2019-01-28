using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboTracker : MonoBehaviour {

    public static ComboTracker current;
    private List<Color> imageColor = new List<Color>();
    [SerializeField]
    private int comboNo = 10;
    public int currentCombo = 0;

    private void Awake()
    {
        current = this;
    }

    // Use this for initialization
    void Start () {
		for(int i = 0; i < comboNo; i++)
        {
            imageColor.Add(new Color(((float)i / comboNo), ((float)(comboNo - i) / comboNo), 0, 0.3f));
            Debug.Log(imageColor[i]);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Combo(int comboCount)
    {
        currentCombo += comboCount;
        this.GetComponentInChildren<Text>().text = "Combo\n\n" + currentCombo;
        if (currentCombo < comboNo)
        {
            this.GetComponent<Image>().color = imageColor[currentCombo];
            Debug.Log(imageColor[currentCombo]);
        } else
        {
            this.GetComponent<Image>().color = new Color(1, 0, 0, 0.3f);
        }
        if (currentCombo % comboNo == 0 && currentCombo > 0)
        {
            playerBehavior.current.Health(1, this.transform.position + new Vector3(0,3,0));
        }
    }
    public void Combo(string reset)
    {
        if (reset == "reset")
        {
            currentCombo = 0;
            this.GetComponentInChildren<Text>().text = "Combo\n\n" + currentCombo;
            this.GetComponent<Image>().color = imageColor[0];
        }
    }
}
