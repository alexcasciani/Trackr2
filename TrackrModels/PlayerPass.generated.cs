#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
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
	[System.Serializable()]
	public partial class PlayerPass : System.Runtime.Serialization.ISerializable
	{
		private int _playerPassID;
		public virtual int PlayerPassID
		{
			get
			{
				return this._playerPassID;
			}
			set
			{
				this._playerPassID = value;
			}
		}
		
		private byte[] _photo;
		public virtual byte[] Photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				this._photo = value;
			}
		}
		
		private string _passNumber;
		public virtual string PassNumber
		{
			get
			{
				return this._passNumber;
			}
			set
			{
				this._passNumber = value;
			}
		}
		
		private DateTime _expires;
		public virtual DateTime Expires
		{
			get
			{
				return this._expires;
			}
			set
			{
				this._expires = value;
			}
		}
		
		private int _playerID;
		public virtual int PlayerID
		{
			get
			{
				return this._playerID;
			}
			set
			{
				this._playerID = value;
			}
		}
		
		private int _lastModifiedBy;
		public virtual int LastModifiedBy
		{
			get
			{
				return this._lastModifiedBy;
			}
			set
			{
				this._lastModifiedBy = value;
			}
		}
		
		private DateTime _lastModifiedAt;
		public virtual DateTime LastModifiedAt
		{
			get
			{
				return this._lastModifiedAt;
			}
			set
			{
				this._lastModifiedAt = value;
			}
		}
		
		private bool _active;
		public virtual bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				this._active = value;
			}
		}
		
		private Player _player;
		public virtual Player Player
		{
			get
			{
				return this._player;
			}
			set
			{
				this._player = value;
			}
		}
		
		private IList<TeamPlayer> _teamPlayers = new List<TeamPlayer>();
		public virtual IList<TeamPlayer> TeamPlayers
		{
			get
			{
				return this._teamPlayers;
			}
		}
		
		#region ISerializable Implementation
		
		public PlayerPass()
		{
		}
		
		protected PlayerPass(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.PlayerPassID = info.GetInt32("PlayerPassID");
			this.Photo = (byte[])info.GetValue("Photo", typeof(byte[]));
			this.PassNumber = info.GetString("PassNumber");
			this.Expires = (DateTime)info.GetValue("Expires", typeof(DateTime));
			this.PlayerID = info.GetInt32("PlayerID");
			this.LastModifiedBy = info.GetInt32("LastModifiedBy");
			this.LastModifiedAt = (DateTime)info.GetValue("LastModifiedAt", typeof(DateTime));
			this.Active = info.GetBoolean("Active");
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("PlayerPassID", this.PlayerPassID, typeof(int));
			info.AddValue("Photo", this.Photo, typeof(byte[]));
			info.AddValue("PassNumber", this.PassNumber, typeof(string));
			info.AddValue("Expires", this.Expires, typeof(DateTime));
			info.AddValue("PlayerID", this.PlayerID, typeof(int));
			info.AddValue("LastModifiedBy", this.LastModifiedBy, typeof(int));
			info.AddValue("LastModifiedAt", this.LastModifiedAt, typeof(DateTime));
			info.AddValue("Active", this.Active, typeof(bool));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
