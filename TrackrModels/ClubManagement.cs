﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ContextGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using TrackrModels;

namespace TrackrModels	
{
	public partial class ClubManagement : OpenAccessContext, IClubManagementUnitOfWork
	{
		private static string connectionStringName = @"ClubManagementConnection";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
				
		private static MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("ClubManagement.rlinq");
		
		public ClubManagement()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public ClubManagement(string connection)
			:base(connection, backend, metadataSource)
		{ }
		
		public ClubManagement(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public ClubManagement(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public ClubManagement(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<WebUserInfo> WebUserInfos 
		{
			get
			{
				return this.GetAll<WebUserInfo>();
			}
		}
		
		public IQueryable<TransactionType> TransactionTypes 
		{
			get
			{
				return this.GetAll<TransactionType>();
			}
		}
		
		public IQueryable<Transaction> Transactions 
		{
			get
			{
				return this.GetAll<Transaction>();
			}
		}
		
		public IQueryable<Team> Teams 
		{
			get
			{
				return this.GetAll<Team>();
			}
		}
		
		public IQueryable<Program> Programs 
		{
			get
			{
				return this.GetAll<Program>();
			}
		}
		
		public IQueryable<Player> Players 
		{
			get
			{
				return this.GetAll<Player>();
			}
		}
		
		public IQueryable<Club> Clubs 
		{
			get
			{
				return this.GetAll<Club>();
			}
		}
		
		public IQueryable<PlayerPass> PlayerPasses 
		{
			get
			{
				return this.GetAll<PlayerPass>();
			}
		}
		
		public IQueryable<TeamPlayer> TeamPlayers 
		{
			get
			{
				return this.GetAll<TeamPlayer>();
			}
		}
		
		public IQueryable<Person> People 
		{
			get
			{
				return this.GetAll<Person>();
			}
		}
		
		public IQueryable<Guardian> Guardians 
		{
			get
			{
				return this.GetAll<Guardian>();
			}
		}
		
		public IQueryable<Address> Addresses 
		{
			get
			{
				return this.GetAll<Address>();
			}
		}
		
		public IQueryable<PhoneNumber> PhoneNumbers 
		{
			get
			{
				return this.GetAll<PhoneNumber>();
			}
		}
		
		public IQueryable<EmailAddress> EmailAddresses 
		{
			get
			{
				return this.GetAll<EmailAddress>();
			}
		}
		
		public IQueryable<TeamSchedule> TeamSchedules 
		{
			get
			{
				return this.GetAll<TeamSchedule>();
			}
		}
		
		public IQueryable<Attendance> Attendances 
		{
			get
			{
				return this.GetAll<Attendance>();
			}
		}
		
		public IQueryable<RegistrationRule> RegistrationRules 
		{
			get
			{
				return this.GetAll<RegistrationRule>();
			}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "MySql";
			backend.ProviderName = "MySql.Data.MySqlClient";
			backend.Logging.LogEvents = LoggingLevel.Normal;
			backend.Logging.EventStoreCapacity = 10000;
			backend.Logging.MetricStoreCapacity = 3600;
			backend.SecondLevelCache.Enabled = true;
			backend.SecondLevelCache.CacheQueryResults = true;
		
			CustomizeBackendConfiguration(ref backend);
		
			return backend;
		}
		
		/// <summary>
		/// Allows you to customize the BackendConfiguration of ClubManagement.
		/// </summary>
		/// <param name="config">The BackendConfiguration of ClubManagement.</param>
		static partial void CustomizeBackendConfiguration(ref BackendConfiguration config);
		
	}
	
	public interface IClubManagementUnitOfWork : IUnitOfWork
	{
		IQueryable<WebUserInfo> WebUserInfos
		{
			get;
		}
		IQueryable<TransactionType> TransactionTypes
		{
			get;
		}
		IQueryable<Transaction> Transactions
		{
			get;
		}
		IQueryable<Team> Teams
		{
			get;
		}
		IQueryable<Program> Programs
		{
			get;
		}
		IQueryable<Player> Players
		{
			get;
		}
		IQueryable<Club> Clubs
		{
			get;
		}
		IQueryable<PlayerPass> PlayerPasses
		{
			get;
		}
		IQueryable<TeamPlayer> TeamPlayers
		{
			get;
		}
		IQueryable<Person> People
		{
			get;
		}
		IQueryable<Guardian> Guardians
		{
			get;
		}
		IQueryable<Address> Addresses
		{
			get;
		}
		IQueryable<PhoneNumber> PhoneNumbers
		{
			get;
		}
		IQueryable<EmailAddress> EmailAddresses
		{
			get;
		}
		IQueryable<TeamSchedule> TeamSchedules
		{
			get;
		}
		IQueryable<Attendance> Attendances
		{
			get;
		}
		IQueryable<RegistrationRule> RegistrationRules
		{
			get;
		}
	}
}
#pragma warning restore 1591
