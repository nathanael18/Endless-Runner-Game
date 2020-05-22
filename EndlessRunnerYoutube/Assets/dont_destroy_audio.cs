using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dont_destroy_audio : MonoBehaviour {

    private static dont_destroy_audio instance = null;
    public static dont_destroy_audio Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }


}
