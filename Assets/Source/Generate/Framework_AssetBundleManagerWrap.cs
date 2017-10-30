﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_AssetBundleManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.AssetBundleManager), typeof(Framework.Singleton<Framework.AssetBundleManager>));
		L.RegFunction("LoadAssetBundle", LoadAssetBundle);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegFunction("LoadBundleCallback", Framework_AssetBundleManager_LoadBundleCallback);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadAssetBundle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Framework.AssetBundleManager obj = (Framework.AssetBundleManager)ToLua.CheckObject<Framework.AssetBundleManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Framework.AssetBundleManager.LoadBundleCallback arg1 = (Framework.AssetBundleManager.LoadBundleCallback)ToLua.CheckDelegate<Framework.AssetBundleManager.LoadBundleCallback>(L, 3);
			obj.LoadAssetBundle(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Framework_AssetBundleManager_LoadBundleCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<Framework.AssetBundleManager.LoadBundleCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<Framework.AssetBundleManager.LoadBundleCallback>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

