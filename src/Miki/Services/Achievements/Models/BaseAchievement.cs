﻿
namespace Miki.Accounts.Achievements.Objects
{
        using System.Threading.Tasks;

	public interface IAchievement
	{
                string Name { get; set; }
                string ParentName { get; set; }
                string Icon { get; set; }
                int Points { get; set; }

		ValueTask<bool> CheckAsync(BasePacket packet);
	}
}