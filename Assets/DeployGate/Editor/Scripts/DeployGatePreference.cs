using UnityEngine;
using UnityEditor;
using System.IO;
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
	
	public class Asset
	{
		public static void  Save <T> (T asset) where T : ScriptableObject
		{
			Directory.CreateDirectory (DeployGateUtility.settingsFolderPath);
			string assetPath = DeployGateUtility.settingsFolderPath + typeof(T).Name + ".asset";
			T _asset = (T)AssetDatabase.LoadAssetAtPath (assetPath, typeof(T));
			if (_asset == null)
				AssetDatabase.CreateAsset (asset, assetPath);
			AssetDatabase.SaveAssets ();
			AssetDatabase.Refresh ();
		}
		
		public static T Load<T> () where T : ScriptableObject
		{
			string assetPath = DeployGateUtility.settingsFolderPath + typeof(T).Name + ".asset";
			T asset = (T)AssetDatabase.LoadAssetAtPath (assetPath, typeof(T));
			if (asset == null) {
				asset = ScriptableObject.CreateInstance<T> ();
				Save<T> (asset);
			}
			return asset;
		}
	}
}