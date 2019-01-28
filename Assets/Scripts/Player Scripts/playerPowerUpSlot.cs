using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPowerUpSlot : MonoBehaviour {

    public static playerPowerUpSlot current;
    public GameObject speedbuff;
    public GameObject shieldbuff;

    private void Awake()
    {
        playerPowerUpSlot.current = this;
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}
    //When no buff is active
    public void NoBuff()
    {
        speedbuff.SetActive(false);
        shieldbuff.SetActive(false);
    }
    //When shieldbuff is active
    public void ShieldBuff()
    {
        NoBuff();
        shieldbuff.SetActive(true);

    }
    public void SpeedBuff()
    {
        NoBuff();
        speedbuff.SetActive(true);
    }
}
