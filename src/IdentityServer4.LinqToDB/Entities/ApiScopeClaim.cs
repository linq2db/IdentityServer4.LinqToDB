﻿namespace IdentityServer4.Contrib.LinqToDB.Entities
{
	/// <summary>
	///     Represents claims of <see cref="Models.ApiResource.Scopes" /> in database
	/// </summary>
	public class ApiScopeClaim : UserClaim
	{
		/// <summary>
		///     <see cref="ApiScope.Id" />
		/// </summary>
		public int ApiScopeId { get; set; }
	}
}