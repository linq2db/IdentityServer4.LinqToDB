﻿using System;
using Microsoft.Extensions.Logging;

namespace IdentityServer4.LinqToDB.IntegrationTests
{
	public class FakeLogger<T> : FakeLogger, ILogger<T>
	{
		public static ILogger<T> Create()
		{
			return new FakeLogger<T>();
		}
	}

	public class FakeLogger : ILogger, IDisposable
	{
		public void Dispose()
		{
		}

		public IDisposable BeginScope<TState>(TState state)
		{
			return this;
		}

		public bool IsEnabled(LogLevel logLevel)
		{
			return false;
		}

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
			Func<TState, Exception, string> formatter)
		{
		}
	}
}