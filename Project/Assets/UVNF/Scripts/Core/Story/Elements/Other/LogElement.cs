﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UVNF.Core.UI;
using UVNF.Extensions;

namespace UVNF.Core.Story.Other
{
    public class LogElement : StoryElement
    {
        public override string ElementName => "Log";

        public override Color32 DisplayColor => _displayColor;
        private Color32 _displayColor = new Color32().Other();

        public override StoryElementTypes Type => StoryElementTypes.Other;

        public string LogText;

        public override void DisplayLayout(Rect layoutRect, GUIStyle label)
        {
#if UNITY_EDITOR
            LogText = EditorGUILayout.TextField("Log Text", LogText);
#endif
        }

        public override IEnumerator Execute(GameManager managerCallback, UVNFCanvas canvas)
        {
            Debug.Log(LogText);
            return null;
        }
    }
}