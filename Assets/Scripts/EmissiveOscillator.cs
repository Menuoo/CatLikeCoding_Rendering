﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissiveOscillator : MonoBehaviour {

	MeshRenderer emissiveRenderer;
	Material emissiveMaterial;

	void Start () {
		emissiveRenderer = GetComponent<MeshRenderer>();
		emissiveMaterial = emissiveRenderer.material;
	}

	void Update () {
		Color c = Color.Lerp(Color.white, Color.black,
			Mathf.Sin(Time.time * Mathf.PI) * 0.5f +  0.5f
		);

		emissiveMaterial.SetColor("_Emission", c);
		//emissiveRenderer.UpdateGIMaterials();	   -- for more complex emission than solid
		DynamicGI.SetEmissive(emissiveRenderer, c);
	}
}
