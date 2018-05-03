using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCounter : MonoBehaviour {

    public int FPS { get; private set; }

    int[] fpses;
    int fpsesIndex;

	private void Awake()
	{
        FPS = 60;
        fpses = new int[10];
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {
        fpses[fpsesIndex++] = (int)(1f / Time.unscaledDeltaTime);
        if (fpsesIndex > fpses.Length-1) {
            fpsesIndex = 0;
        }
        int sum = 0;
        for (int i = 0; i < fpses.Length; i++) {
            sum += fpses[i];
        }
        FPS = sum / fpses.Length;
    }
}
