﻿using Model;
using System;

namespace Hotfix
{
#if ILRuntime
	public interface IMHandler
	{
		void Handle(AMessage message);
		Type GetMessageType();
	}
#else
	public interface IMHandler : Model.IMHandler
	{
	}
#endif
}