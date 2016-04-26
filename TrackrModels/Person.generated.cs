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
	public partial class Person : System.Runtime.Serialization.ISerializable
	{
		private int _personID;
		public virtual int PersonID
		{
			get
			{
				return this._personID;
			}
			set
			{
				this._personID = value;
			}
		}
		
		private string _fName;
		public virtual string FName
		{
			get
			{
				return this._fName;
			}
			set
			{
				this._fName = value;
			}
		}
		
		private System.Nullable<System.Char> _mInitial;
		public virtual System.Nullable<System.Char> MInitial
		{
			get
			{
				return this._mInitial;
			}
			set
			{
				this._mInitial = value;
			}
		}
		
		private string _lName;
		public virtual string LName
		{
			get
			{
				return this._lName;
			}
			set
			{
				this._lName = value;
			}
		}
		
		private DateTime? _dateOfBirth;
		public virtual DateTime? DateOfBirth
		{
			get
			{
				return this._dateOfBirth;
			}
			set
			{
				this._dateOfBirth = value;
			}
		}
		
		private byte? _gender;
		public virtual byte? Gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				this._gender = value;
			}
		}
		
		private int _clubID;
		public virtual int ClubID
		{
			get
			{
				return this._clubID;
			}
			set
			{
				this._clubID = value;
			}
		}
		
		private int? _userID;
		public virtual int? UserID
		{
			get
			{
				return this._userID;
			}
			set
			{
				this._userID = value;
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
		
		private Club _club;
		public virtual Club Club
		{
			get
			{
				return this._club;
			}
			set
			{
				this._club = value;
			}
		}
		
		private IList<Address> _addresses = new List<Address>();
		public virtual IList<Address> Addresses
		{
			get
			{
				return this._addresses;
			}
		}
		
		private IList<PhoneNumber> _phoneNumbers = new List<PhoneNumber>();
		public virtual IList<PhoneNumber> PhoneNumbers
		{
			get
			{
				return this._phoneNumbers;
			}
		}
		
		private IList<EmailAddress> _emailAddresses = new List<EmailAddress>();
		public virtual IList<EmailAddress> EmailAddresses
		{
			get
			{
				return this._emailAddresses;
			}
		}
		
		#region ISerializable Implementation
		
		public Person()
		{
		}
		
		protected Person(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			this.PersonID = info.GetInt32("PersonID");
			this.FName = info.GetString("FName");
			this.MInitial = (System.Nullable<System.Char>)info.GetValue("MInitial", typeof(System.Nullable<System.Char>));
			this.LName = info.GetString("LName");
			this.DateOfBirth = (DateTime?)info.GetValue("DateOfBirth", typeof(DateTime?));
			this.Gender = (byte?)info.GetValue("Gender", typeof(byte?));
			this.ClubID = info.GetInt32("ClubID");
			this.UserID = (int?)info.GetValue("UserID", typeof(int?));
			this.LastModifiedBy = info.GetInt32("LastModifiedBy");
			this.LastModifiedAt = (DateTime)info.GetValue("LastModifiedAt", typeof(DateTime));
			CustomizeDeserializationProcess(info, context);
		}
		
		public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			info.AddValue("PersonID", this.PersonID, typeof(int));
			info.AddValue("FName", this.FName, typeof(string));
			info.AddValue("MInitial", this.MInitial, typeof(System.Nullable<System.Char>));
			info.AddValue("LName", this.LName, typeof(string));
			info.AddValue("DateOfBirth", this.DateOfBirth, typeof(DateTime?));
			info.AddValue("Gender", this.Gender, typeof(byte?));
			info.AddValue("ClubID", this.ClubID, typeof(int));
			info.AddValue("UserID", this.UserID, typeof(int?));
			info.AddValue("LastModifiedBy", this.LastModifiedBy, typeof(int));
			info.AddValue("LastModifiedAt", this.LastModifiedAt, typeof(DateTime));
			CustomizeSerializationProcess(info, context);
		}
		
		partial void CustomizeSerializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		partial void CustomizeDeserializationProcess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
		#endregion
	}
}
#pragma warning restore 1591
