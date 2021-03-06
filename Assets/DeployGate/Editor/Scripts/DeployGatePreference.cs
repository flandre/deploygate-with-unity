﻿using UnityEngine;
using UnityEditor;
using DeployGate.Resources;

namespace DeployGate
{
	[System.Serializable]
	public class DeployGatePreference : ScriptableObject
	{
		public UserInfo user;
		public TempPath temp;
		public bool includeReadLog;
		public BuildType buildType = BuildType.APK;
		public bool forceInternetPermission = PlayerSettings.Android.forceInternetPermission;

		public enum BuildType
		{
			APK,
			EclipseProject
		}
	}
}