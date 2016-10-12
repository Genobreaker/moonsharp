﻿using System;

namespace MoonSharp.Interpreter
{
	internal static class Utils
	{
		internal static bool IsDbNull(this object p)
		{
#if PCL || ENABLE_DOTNET || NETFX_CORE
			return p != null && p.GetType().FullName.StartsWith("System.DBNull");
#else
			return p != null && Convert.IsDBNull(p);
#endif
		}


	}
}
