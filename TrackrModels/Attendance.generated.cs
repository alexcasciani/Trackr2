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
	public partial class Attendance : System.Runtime.Serialization.ISerializable
	{
		private int _attendanceID;
		public virtual int AttendanceID
		{
			get
			{
				return this._attendanceID;
			}
			set
			{
				this._attendanceID = value;
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
		
		private int _teamScheduleID;
		public virtual int TeamScheduleID
		{
			get
			{
				return this._teamScheduleID;
			}
			set
			{
				this._teamScheduleID = value;
			}
		}
		
		private string _notes;
		public virtual string Notes
		{
			get
			{
				return this._notes;
			}
			set
			{
				this._notes = value;
			}
		}
		
		private bool _isActive;
		public virtual bool IsActive
		{
			get
			{
				return this._isActive;
			}
			set
			{
				this._isActive = value;
			}
		}
		
		private DateTime _createDate;
		public virtual DateTime CreateDate
		{
			get
			{
				return this._createDate;
			}
			set
			{
				this._createDate = value;
			}
		}
		
		private int _createUserID;
		public virtual int CreateUserID
		{
			get
			{
				return this._createUserID;
			}
			set
			{
				this._createUserID = value;
			}
		}
		
		private DateTime? _modifyDate;
		public virtual DateTime? ModifyDate
		{
			get
			{
				return this._modifyDate;
			}
			set
			{
				this._modifyDate = value;
			}
		}
		
		private int? _modifyUserID;
		public virtual int? ModifyUserID
		{
			get
			{
				return this._modifyUserID;
			}
			set
			{
				this._modifyUserID = value;
			}
		}
		
		private TeamSchedule _teamSchedule;
		public virtual TeamSchedule TeamSchedule
		{
			get
			{
				return this._teamSchedule;
			}
			set
			{
				this._teamSchedule = value;
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
		
		#region ISerializable Implementation
		
		public Attendance()
		{
		}
		
		protected Attendance(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.AttendanceID = info.GetInt32("AttendanceID");
			this.PlayerID = info.GetInt32("PlayerID");
			this.TeamScheduleID = info.GetInt32("TeamScheduleID");
			this.Notes = info.GetString("Notes");
			this.IsActive = info.GetBoolean("IsActive");
			this.CreateDate = (DateTime)info.GetValue("CreateDate", typeof(DateTime));
			this.CreateUserID = info.GetInt32("CreateUserID");
			this.ModifyDate = (DateTime?)info.GetValue("ModifyDate", typeof(DateTime?));
			this.ModifyUserID = (int?)info.GetValue("ModifyUserID", typeof(int?));
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("AttendanceID", this.AttendanceID, typeof(int));
			info.AddValue("PlayerID", this.PlayerID, typeof(int));
			info.AddValue("TeamScheduleID", this.TeamScheduleID, typeof(int));
			info.AddValue("Notes", this.Notes, typeof(string));
			info.AddValue("IsActive", this.IsActive, typeof(bool));
			info.AddValue("CreateDate", this.CreateDate, typeof(DateTime));
			info.AddValue("CreateUserID", this.CreateUserID, typeof(int));
			info.AddValue("ModifyDate", this.ModifyDate, typeof(DateTime?));
			info.AddValue("ModifyUserID", this.ModifyUserID, typeof(int?));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
