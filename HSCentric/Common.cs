﻿using HSCentric.Const;

namespace HSCentric
{
	public static class Common
	{
		public static bool IsBuddyMode(TASK_MODE mode)
		{
			return mode == TASK_MODE.狂野 || mode == TASK_MODE.标准 || mode == TASK_MODE.经典 || mode == TASK_MODE.休闲;
		}

	}
}
