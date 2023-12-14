﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ToonKitOS
{
    [ExecuteAlways]
    public class SetLighting : MonoBehaviour
    {
        Light mainLight;

        [SerializeField, ColorUsage(false, true)]
        Color ambientLight = Color.white;

        [SerializeField, Range(0,1)]
        float shadowStrength = 1f;

        private void Start()
        {
            mainLight = GetComponent<Light>();
        }

        // Update is called once per frame
        void Update()
        {
            Shader.SetGlobalFloat("_LIGHTINTENSITY", mainLight.intensity);
            Shader.SetGlobalColor("_AMBIENTLIGHT", ambientLight);
            Shader.SetGlobalFloat("_ShadowStrengthToonKit", shadowStrength);
        }
    }
}
