﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpSystems.Task.Forum.Repository.Entities
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ForumDb")]
	public partial class ForumDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPost(Post instance);
    partial void UpdatePost(Post instance);
    partial void DeletePost(Post instance);
    partial void InsertThread(Thread instance);
    partial void UpdateThread(Thread instance);
    partial void DeleteThread(Thread instance);
    partial void InsertTopic(Topic instance);
    partial void UpdateTopic(Topic instance);
    partial void DeleteTopic(Topic instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public ForumDataContextDataContext() : 
				base(global::HelpSystems.Task.Forum.Repository.Properties.Settings.Default.ForumDbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ForumDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ForumDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ForumDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ForumDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Post> Posts
		{
			get
			{
				return this.GetTable<Post>();
			}
		}
		
		public System.Data.Linq.Table<Thread> Threads
		{
			get
			{
				return this.GetTable<Thread>();
			}
		}
		
		public System.Data.Linq.Table<Topic> Topics
		{
			get
			{
				return this.GetTable<Topic>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Posts")]
	public partial class Post : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Description;
		
		private System.DateTime _Date;
		
		private System.Nullable<int> _UserId;
		
		private System.Nullable<int> _ThreadId;
		
		private EntityRef<Thread> _Thread;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnUserIdChanging(System.Nullable<int> value);
    partial void OnUserIdChanged();
    partial void OnThreadIdChanging(System.Nullable<int> value);
    partial void OnThreadIdChanged();
    #endregion
		
		public Post()
		{
			this._Thread = default(EntityRef<Thread>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int")]
		public System.Nullable<int> UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThreadId", DbType="Int")]
		public System.Nullable<int> ThreadId
		{
			get
			{
				return this._ThreadId;
			}
			set
			{
				if ((this._ThreadId != value))
				{
					if (this._Thread.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnThreadIdChanging(value);
					this.SendPropertyChanging();
					this._ThreadId = value;
					this.SendPropertyChanged("ThreadId");
					this.OnThreadIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Thread_Post", Storage="_Thread", ThisKey="ThreadId", OtherKey="Id", IsForeignKey=true)]
		public Thread Thread
		{
			get
			{
				return this._Thread.Entity;
			}
			set
			{
				Thread previousValue = this._Thread.Entity;
				if (((previousValue != value) 
							|| (this._Thread.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Thread.Entity = null;
						previousValue.Posts.Remove(this);
					}
					this._Thread.Entity = value;
					if ((value != null))
					{
						value.Posts.Add(this);
						this._ThreadId = value.Id;
					}
					else
					{
						this._ThreadId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Thread");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Post", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Posts.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Posts.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Threads")]
	public partial class Thread : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Title;
		
		private string _Description;
		
		private int _UserId;
		
		private int _TopicId;
		
		private System.Nullable<System.DateTime> _Date;
		
		private bool _IsClosed;
		
		private EntitySet<Post> _Posts;
		
		private EntityRef<Topic> _Topic;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnTopicIdChanging(int value);
    partial void OnTopicIdChanged();
    partial void OnDateChanging(System.Nullable<System.DateTime> value);
    partial void OnDateChanged();
    partial void OnIsClosedChanging(bool value);
    partial void OnIsClosedChanged();
    #endregion
		
		public Thread()
		{
			this._Posts = new EntitySet<Post>(new Action<Post>(this.attach_Posts), new Action<Post>(this.detach_Posts));
			this._Topic = default(EntityRef<Topic>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TopicId", DbType="Int NOT NULL")]
		public int TopicId
		{
			get
			{
				return this._TopicId;
			}
			set
			{
				if ((this._TopicId != value))
				{
					if (this._Topic.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTopicIdChanging(value);
					this.SendPropertyChanging();
					this._TopicId = value;
					this.SendPropertyChanged("TopicId");
					this.OnTopicIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsClosed", DbType="Bit")]
		public bool IsClosed
		{
			get
			{
				return this._IsClosed;
			}
			set
			{
				if ((this._IsClosed != value))
				{
					this.OnIsClosedChanging(value);
					this.SendPropertyChanging();
					this._IsClosed = value;
					this.SendPropertyChanged("IsClosed");
					this.OnIsClosedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Thread_Post", Storage="_Posts", ThisKey="Id", OtherKey="ThreadId")]
		public EntitySet<Post> Posts
		{
			get
			{
				return this._Posts;
			}
			set
			{
				this._Posts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Topic_Thread", Storage="_Topic", ThisKey="TopicId", OtherKey="Id", IsForeignKey=true)]
		public Topic Topic
		{
			get
			{
				return this._Topic.Entity;
			}
			set
			{
				Topic previousValue = this._Topic.Entity;
				if (((previousValue != value) 
							|| (this._Topic.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Topic.Entity = null;
						previousValue.Threads.Remove(this);
					}
					this._Topic.Entity = value;
					if ((value != null))
					{
						value.Threads.Add(this);
						this._TopicId = value.Id;
					}
					else
					{
						this._TopicId = default(int);
					}
					this.SendPropertyChanged("Topic");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Thread", Storage="_User", ThisKey="UserId", OtherKey="Id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Threads.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Threads.Add(this);
						this._UserId = value.Id;
					}
					else
					{
						this._UserId = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.Thread = this;
		}
		
		private void detach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.Thread = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Topics")]
	public partial class Topic : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private EntitySet<Thread> _Threads;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Topic()
		{
			this._Threads = new EntitySet<Thread>(new Action<Thread>(this.attach_Threads), new Action<Thread>(this.detach_Threads));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Topic_Thread", Storage="_Threads", ThisKey="Id", OtherKey="TopicId")]
		public EntitySet<Thread> Threads
		{
			get
			{
				return this._Threads;
			}
			set
			{
				this._Threads.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Threads(Thread entity)
		{
			this.SendPropertyChanging();
			entity.Topic = this;
		}
		
		private void detach_Threads(Thread entity)
		{
			this.SendPropertyChanging();
			entity.Topic = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Username;
		
		private string _Password;
		
		private string _City;
		
		private string _Country;
		
		private System.DateTime _RegisterDate;
		
		private string _Roles;
		
		private EntitySet<Post> _Posts;
		
		private EntitySet<Thread> _Threads;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnRegisterDateChanging(System.DateTime value);
    partial void OnRegisterDateChanged();
    partial void OnRolesChanging(string value);
    partial void OnRolesChanged();
    #endregion
		
		public User()
		{
			this._Posts = new EntitySet<Post>(new Action<Post>(this.attach_Posts), new Action<Post>(this.detach_Posts));
			this._Threads = new EntitySet<Thread>(new Action<Thread>(this.attach_Threads), new Action<Thread>(this.detach_Threads));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RegisterDate", DbType="Date NOT NULL")]
		public System.DateTime RegisterDate
		{
			get
			{
				return this._RegisterDate;
			}
			set
			{
				if ((this._RegisterDate != value))
				{
					this.OnRegisterDateChanging(value);
					this.SendPropertyChanging();
					this._RegisterDate = value;
					this.SendPropertyChanged("RegisterDate");
					this.OnRegisterDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Roles", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Roles
		{
			get
			{
				return this._Roles;
			}
			set
			{
				if ((this._Roles != value))
				{
					this.OnRolesChanging(value);
					this.SendPropertyChanging();
					this._Roles = value;
					this.SendPropertyChanged("Roles");
					this.OnRolesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Post", Storage="_Posts", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<Post> Posts
		{
			get
			{
				return this._Posts;
			}
			set
			{
				this._Posts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Thread", Storage="_Threads", ThisKey="Id", OtherKey="UserId")]
		public EntitySet<Thread> Threads
		{
			get
			{
				return this._Threads;
			}
			set
			{
				this._Threads.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Posts(Post entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Threads(Thread entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Threads(Thread entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591
