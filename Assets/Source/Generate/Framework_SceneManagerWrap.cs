﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_SceneManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.SceneManager), typeof(Framework.Singleton<Framework.SceneManager>));
		L.RegFunction("LoadScene", LoadScene);
		L.RegFunction("LoadSceneByName", LoadSceneByName);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegFunction("LoadSceneCallback", Framework_SceneManager_LoadSceneCallback);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadScene(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Framework.SceneManager obj = (Framework.SceneManager)ToLua.CheckObject<Framework.SceneManager>(L, 1);
			UnityEngine.AssetBundle arg0 = (UnityEngine.AssetBundle)ToLua.CheckObject(L, 2, typeof(UnityEngine.AssetBundle));
			Framework.SceneManager.LoadSceneCallback arg1 = (Framework.SceneManager.LoadSceneCallback)ToLua.CheckDelegate<Framework.SceneManager.LoadSceneCallback>(L, 3);
			obj.LoadScene(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadSceneByName(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Framework.SceneManager obj = (Framework.SceneManager)ToLua.CheckObject<Framework.SceneManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			Framework.SceneManager.LoadSceneCallback arg1 = (Framework.SceneManager.LoadSceneCallback)ToLua.CheckDelegate<Framework.SceneManager.LoadSceneCallback>(L, 3);
			obj.LoadSceneByName(arg0, arg1);
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
	static int Framework_SceneManager_LoadSceneCallback(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<Framework.SceneManager.LoadSceneCallback>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<Framework.SceneManager.LoadSceneCallback>.Create(func, self);
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
