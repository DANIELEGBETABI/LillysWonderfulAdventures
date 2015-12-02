﻿using System;
using UnityEngine;

namespace VoidInc
{
	public static class InputCheck
	{
		public static RuntimePlatform[] PCPlatforms =
		{
			RuntimePlatform.OSXEditor,
			RuntimePlatform.OSXPlayer,
			RuntimePlatform.WindowsPlayer,
			RuntimePlatform.OSXWebPlayer,
			RuntimePlatform.OSXDashboardPlayer,
			RuntimePlatform.WindowsWebPlayer,
			RuntimePlatform.WindowsEditor,
			RuntimePlatform.LinuxPlayer,
			RuntimePlatform.WebGLPlayer,
			RuntimePlatform.WSAPlayerX86,
			RuntimePlatform.WSAPlayerX64,
			RuntimePlatform.WSAPlayerARM,
			RuntimePlatform.TizenPlayer
		};

		public static RuntimePlatform[] MobilePlatforms =
		{
			RuntimePlatform.IPhonePlayer,
			RuntimePlatform.Android,
			RuntimePlatform.WP8Player
		};

		public static RuntimePlatform[] EditorPlatforms =
		{
			RuntimePlatform.OSXEditor,
			RuntimePlatform.WindowsEditor
		};

		public static bool IsPCPlatforms
		{
			get
			{
				if (Array.Exists(PCPlatforms, element => element == Application.platform))
				{
					return true;
				}

				return false;
			}
		}

		public static bool IsMobilePlatforms
		{
			get
			{
				if (Array.Exists(MobilePlatforms, element => element == Application.platform))
				{
					return true;
				}

				return false;
			}
		}

		public static bool IsEditorPlatforms
		{
			get
			{
				if (Array.Exists(MobilePlatforms, element => element == Application.platform))
				{
					return true;
				}

				return false;
			}
		}

		public static bool TestInput(RuntimePlatform currentPlatform)
		{
			if (Application.platform == currentPlatform)
			{
				return true;
			}

			return false;
		}

		public static bool TestInput(RuntimePlatform[] currentPlatform)
		{
			if (Array.Exists(currentPlatform, element => element == Application.platform))
			{
				return true;
			}

			return false;
		}
	}
}
