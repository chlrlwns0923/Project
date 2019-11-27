using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    protected int _level;

    protected int _goodfeel;

    protected float _exp;

    public int level
    {
        get
        {
            return _level;
        }
        set
        {
        }
    }
    public int goodfeel
    {
        get
        {
            return _goodfeel;
        }
        set
        {
            if (value > 100) _goodfeel = 100;
            else if (value < 0) _goodfeel = 0;
        }
    }

    public float exp
    {
        get
        {
            return _exp;
        }
        set
        {
            if(value > 30 + _level * _level)
            {
                level++;
                exp = 0;
            }
        }
    }

    public Color ColorFromFeel()
    {
        if(goodfeel <20)
            return new Color(0/255f, 0/255f, 0/255f);
        else if(goodfeel < 40)
            return new Color(130 / 255f, 130 / 255f, 130 / 255f);
        else if(goodfeel < 60)
            return new Color(176 / 255f, 114 / 255f, 140 / 255f);
        else if(goodfeel < 80)
            return new Color(255 / 255f, 194 / 255f, 219 / 255f);
        else
            return new Color(255 / 255f, 115 / 255f, 172 / 255f);
    }
    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        exp = 0;
        goodfeel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
