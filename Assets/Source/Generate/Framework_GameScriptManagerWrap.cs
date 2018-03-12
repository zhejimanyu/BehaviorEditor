﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Framework_GameScriptManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Framework.GameScriptManager), typeof(Framework.Singleton<Framework.GameScriptManager>));
		L.RegFunction("Init", Init);
		L.RegFunction("AddSearchPath", AddSearchPath);
		L.RegFunction("Require", Require);
		L.RegFunction("DoFile", DoFile);
		L.RegFunction("CallVoidFunc", CallVoidFunc);
		L.RegFunction("SetTable", SetTable);
		L.RegFunction("SetUserData", SetUserData);
		L.RegFunction("GetTableField", GetTableField);
		L.RegFunction("ExecuteTableMethod", ExecuteTableMethod);
		L.RegFunction("ExecuteString", ExecuteString);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Framework.GameScriptManager obj = (Framework.GameScriptManager)ToLua.CheckObject<Framework.GameScriptManager>(L, 1);
			obj.Init();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddSearchPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.GameScriptManager obj = (Framework.GameScriptManager)ToLua.CheckObject<Framework.GameScriptManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.AddSearchPath(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Require(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.GameScriptManager obj = (Framework.GameScriptManager)ToLua.CheckObject<Framework.GameScriptManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			LuaInterface.LuaTable o = obj.Require(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.GameScriptManager obj = (Framework.GameScriptManager)ToLua.CheckObject<Framework.GameScriptManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			LuaInterface.LuaTable o = obj.DoFile(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CallVoidFunc(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.GameScriptManager obj = (Framework.GameScriptManager)ToLua.CheckObject<Framework.GameScriptManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.CallVoidFunc(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Framework.GameScriptManager obj = (Framework.GameScriptManager)ToLua.CheckObject<Framework.GameScriptManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			LuaTable arg1 = ToLua.CheckLuaTable(L, 3);
			obj.SetTable(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetUserData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Framework.GameScriptManager obj = (Framework.GameScriptManager)ToLua.CheckObject<Framework.GameScriptManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			object arg1 = ToLua.ToVarObject(L, 3);
			obj.SetUserData(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTableField(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Framework.GameScriptManager obj = (Framework.GameScriptManager)ToLua.CheckObject<Framework.GameScriptManager>(L, 1);
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			object o = obj.GetTableField(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExecuteTableMethod(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Framework.GameScriptManager obj = (Framework.GameScriptManager)ToLua.CheckObject<Framework.GameScriptManager>(L, 1);
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			object o = obj.ExecuteTableMethod(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExecuteString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Framework.GameScriptManager obj = (Framework.GameScriptManager)ToLua.CheckObject<Framework.GameScriptManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			object o = obj.ExecuteString(arg0);
			ToLua.Push(L, o);
			return 1;
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
}

