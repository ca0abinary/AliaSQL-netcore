﻿
using Tarantino.Core.DatabaseManager.Model;

namespace Tarantino.Core.DatabaseManager.Services
{
	
	public interface ISchemaInitializer
	{
		void EnsureSchemaCreated(ConnectionSettings settings);
	}
}