﻿using UnityEngine;
using UnityEditor;
using DeployGate;
using DeployGate.Resources;

namespace DeployGate
{
	public class DeployGateMenu
	{
		[MenuItem("Window/DeployGate")]
		static void OpenDeployGatePreferenceWindow ()
		{
			DeployGateWindow.GetWindow ();
		}
	}
}

