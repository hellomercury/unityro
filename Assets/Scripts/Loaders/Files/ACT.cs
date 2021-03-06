﻿using UnityEngine;
using System.Collections;

public class ACT
{
    public static string Header = "AC";

    public string filename;
    public string version;

    public string[] sounds;
    public Action[] actions;

    public class Action
    {
        public Animation[] animations;
        public float delay;
    }

    public class Animation
    {
        public Layer[] layers;
        public int soundId;
        public Vector2Int[] pos;
    }

    public class Layer
    {
        public Vector2Int pos;
        public int index;
        public int isMirror;
        public Vector2 scale;
        public Color color;
        public float angle;
        public int sprType;
        public int width;
        public int height;
    }
}
