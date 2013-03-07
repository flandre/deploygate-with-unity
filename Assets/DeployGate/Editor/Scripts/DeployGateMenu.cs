using UnityEditor;
using DeployGate;
using UnityEngine;
using DeployGate.Resources;

namespace DeployGate
{
	public class DeployGateMenu
	{
		[MenuItem("File/DeployGate")]
		static void OpenDeployGatePreferenceWindow ()
		{
			DeployGateWindow.GetWindow ();
		}
	}
}

